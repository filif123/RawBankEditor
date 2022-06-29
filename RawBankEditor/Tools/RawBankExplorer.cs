using RawBankEditor.Entities;
using ToolsCore.Entities;
using ToolsCore.Tools;

namespace RawBankEditor.Tools;

internal static class RawBankExplorer
{
    public static DirectoryElement ExploreFileSystem() => new(new DirectoryInfo(GlobData.OpenedProject.AbsPathToBank));

    public static List<RawBankMessage> MergeFilesAndData(DirectoryElement root, FyzLanguage lang)
    {
        var messages = new List<RawBankMessage>();

        //languages
        var dirEl = root.Children.FirstOrDefault(n => EqualsPathNames(n.Name, lang.Key));
        if (dirEl is not DirectoryElement dir)
        {
            messages.Add(new LanguageDirMissing(lang));
            return messages;
        }

        lang.Directory = dir;

        //groups
        foreach (var grpElement in dir.Children)
        {
            if (grpElement is not DirectoryElement de)
                continue;

            foreach (var grp in lang.Groups)
            {
                if (!EqualsPathNames(de.Name, grp.RelativePath.Replace("\\","")))
                    continue;

                grp.Directory = de;
                de.Group = grp;

                //sounds
                foreach (var sndElement in de.Children)
                {
                    if (sndElement is not SoundFileElement sfe)
                        continue;

                    foreach (var snd in grp.Sounds)
                    {
                        if (!RawBankParser.AddPathIsEmpty(snd.AdditionalRelativePath))
                        {
                            snd.File = new SoundFileElement(snd.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
                            snd.File.Sound = snd;
                        }
                        else if (EqualsPathNames(sfe.Name, snd.FileName))
                        {
                            snd.File = sfe;
                            snd.File.Sound = snd;
                        }
                    }
                }
            }
        }

        //check files (link LOGICAL -> FILE)
        foreach (var langGroup in lang.Groups)
        {
            if (langGroup.Directory == null) 
                messages.Add(new GroupDirMissing(langGroup));

            foreach (var sound in langGroup.Sounds)
            {
                if (sound.File == null) 
                    messages.Add(new SoundFileMissing(sound));
            }
        }

        //check files (link FILE -> LOGICAL)
        CheckDefOfFile(dir);
        
        return messages;
        
        void CheckDefOfFile(DirectoryElement de)
        {
            foreach (var child in de.Children)
            {
                if (child is DirectoryElement d)
                {
                    CheckDefOfFile(d);
                }
                else if (child is SoundFileElement {Sound: null} sfe) 
                    messages.Add(new SoundDataMissing(sfe));
            }
        }
    }

    public static bool EqualsPathNames(string name1, string name2) => string.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase);

    public static FileSystemElement GetElement(string fullpath, DirectoryElement root, SearchOperation op = SearchOperation.None)
    {
        var path = Utils.GetRelativePath(fullpath, GlobData.OpenedProject.AbsPathToBank);

        var direlem = root;
        var splitted = path.Split('\\');
        for (var i = 1; i < splitted.Length; i++)
        {
            var slice = splitted[i];
            var elem = GetElem(direlem, slice);
            if (op == SearchOperation.Delete && elem != null && i == splitted.Length - 1)
            {
                direlem.Children.Remove(elem);
                return elem;
            }

            switch (elem)
            {
                case null when op == SearchOperation.Create && i == splitted.Length - 1:
                    if (File.GetAttributes(fullpath).HasFlag(FileAttributes.Directory))
                    {
                        var newElement = new DirectoryElement(fullpath);
                        newElement.Parent = direlem;
                        direlem.Children.Add(newElement);
                        return newElement;
                    }
                    else
                    {
                        FileElement newElement;
                        if (Path.GetExtension(fullpath).ToUpper() is SoundFileElement.EWA_EXT
                            or SoundFileElement.WAV_EXT)
                            newElement = new SoundFileElement(fullpath);
                        else
                            newElement = new OtherFileElement(fullpath);

                        newElement.Parent = direlem;
                        direlem.Children.Add(newElement);
                        return newElement;
                    }
                case null:
                    return null;
                case DirectoryElement de when i != splitted.Length - 1:
                    direlem = de;
                    continue;
                case FileElement when i != splitted.Length - 1:
                    return null;
                default:
                    return elem;
            }
        }

        return null;

        FileSystemElement GetElem(DirectoryElement de, string slice)
        {
            foreach (var child in de.Children)
            {
                if (child.Name == slice)
                    return child;
            }
            return null;
        }
    }

    public enum SearchOperation
    {
        None,
        Create,
        Delete
    }

    public static List<FyzSound> CheckBankWAVs(FyzLanguage lang, BackgroundWorker worker = null, bool checkDuration = false)
    {
        var sounds = new List<FyzSound>();

        worker?.ReportProgress(0, lang.Groups.Count);

        var i = 0;
        foreach (var grp in lang.Groups)
        {
            foreach (var sound in grp.Sounds)
            {
                var path = $"{GlobData.OpenedProject.AbsPathToBank}{lang.RelativePath}{grp.RelativePath}{sound.AdditionalRelativePath}";
                if (!File.Exists(path))
                    //Sound has no WAV
                    sounds.Add(sound);
                else if (checkDuration) sound.Duration = SoundUtils.GetSoundDuration(path);
            }

            worker?.ReportProgress(++i);
        }

        return sounds;
    }
}