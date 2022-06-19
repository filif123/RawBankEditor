using ExControls;
using RawBankEditor.Entities;
using ToolsCore;
using ToolsCore.Tools;

namespace RawBankEditor.Tools;

internal static class RawBankParser
{
    /// <summary>
    ///     Precita subor FyzBank.dat, ktory obsahuje informacie o jazykoch zvukovej banky.
    /// </summary>
    /// <returns>list jazykov zvukovej banky.</returns>
    public static List<FyzLanguage> ReadFyzBankFile()
    {
        var file = Utils.CombinePath(GlobData.AbsPathToBank, FileConsts.FILE_FYZBANK);

        if (!File.Exists(file))
            throw new FileNotFoundException($"Súbor s definíciou priečinkov zvukov sa na zvolenej ceste nenašiel: {file}");

        using var reader = new BinaryReader(File.Open(file, FileMode.Open), Encodings.Win1250);
        var countLangs = reader.ReadInt32();
        var languages = new List<FyzLanguage>(countLangs);

        for (var i = 0; i < countLangs; i++)
        {
            int fileFyzZvukNameL = reader.ReadByte();
            var fileFyzZvukName = reader.ReadBytes(fileFyzZvukNameL).ANSItoUTF();

            int relativePathL = reader.ReadByte();
            var relativePath = reader.ReadBytes(relativePathL).ANSItoUTF();

            int keyL = reader.ReadByte();
            var key = reader.ReadBytes(keyL).ANSItoUTF();

            int nameL = reader.ReadByte();
            var name = reader.ReadBytes(nameL).ANSItoUTF();

            reader.ReadBytes(4);
            languages.Add(new FyzLanguage(key, fileFyzZvukName, name, relativePath));
        }

        return languages;
    }

    /// <summary>
    ///     Precita subor FyzZvuk.dat, ktory obsahuje informacie o skupinach zvukov a zvukoch samotnych.
    /// </summary>
    /// <param name="language">informacia o jazyku zvukovej banky, do ktorej sa budu vkladat informacie o skupinach a zvukoch.</param>
    /// <param name="worker">background worker pre asynchronnost</param>
    public static void ReadFyzZvukFile(FyzLanguage language, BackgroundWorker worker = null)
    {
        if (language == null)
            throw new ArgumentNullException(nameof(language));

        var file = Utils.CombinePath(GlobData.AbsPathToBank, language.RelativePath, language.FileFyzZvukName);

        if (!File.Exists(file))
            throw new FileNotFoundException($"Súbor s definíciou zvukov sa na zvolenej ceste nenašiel: {file}");

        var groups = new List<FyzGroup>();

        using var reader = new BinaryReader(File.Open(file, FileMode.Open), Encodings.Win1250);
        var countGroups = reader.ReadInt32();

        worker?.ReportProgress(0, new ProgressStatus("Analyzovanie súboru banky zvukov", countGroups));

        for (var i = 0; i < countGroups; i++)
        {
            int dirNameL = reader.ReadByte();
            var dirName = reader.ReadBytes(dirNameL).ANSItoUTF();

            int dirKeyL = reader.ReadByte();
            var dirKey = reader.ReadBytes(dirKeyL).ANSItoUTF();

            int dirRelativePathL = reader.ReadByte();
            var dirRelativePath = reader.ReadBytes(dirRelativePathL).ANSItoUTF();

            var countFiles = reader.ReadInt32();

            var grp = new FyzGroup(language, dirKey, dirName, dirRelativePath);

            for (var j = 0; j < countFiles; j++)
            {
                int textL = reader.ReadByte();
                string text;
                if (textL == 0xff)
                {
                    int textL2 = reader.ReadInt16();
                    text = reader.ReadBytes(textL2).ANSItoUTF();
                }
                else
                {
                    text = reader.ReadBytes(textL).ANSItoUTF();
                }

                int sNameL = reader.ReadByte();
                var sName = reader.ReadBytes(sNameL).ANSItoUTF();

                int sKeyL = reader.ReadByte();
                var sKey = reader.ReadBytes(sKeyL).ANSItoUTF();

                int fileNameL = reader.ReadByte();
                var fileName = reader.ReadBytes(fileNameL).ANSItoUTF();
                var relativePath = "";
                if (fileName.Contains("\\"))
                {
                    var index = fileName.LastIndexOf('\\');
                    relativePath = fileName.Substring(0, index + 1);
                    fileName = fileName.Replace(relativePath, "");
                }

                var duration = reader.ReadInt32();

                grp.Add(new FyzSound(grp, sKey, sName, fileName, relativePath, text, duration));
            }

            groups.Add(grp);
            worker?.ReportProgress(i);
        }

        language.Groups = new ExBindingList<FyzGroup>(groups);
    }

    public static DirectoryElement ExploreFileSystem()
    {
        return new DirectoryElement(new DirectoryInfo(GlobData.AbsPathToBank));
    }

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

                //sounds
                foreach (var sndElement in de.Children)
                {
                    if (sndElement is not SoundFileElement sfe)
                        continue;

                    foreach (var snd in grp.Sounds)
                    {
                        if (!AddPathIsEmpty(snd.AdditionalRelativePath))
                        {
                            snd.File = new SoundFileElement(snd.GetAbsPath()); //SearchFromLangRoot(dir, snd);
                        }
                        else if (EqualsPathNames(sfe.Name, snd.FileName))
                        {
                            snd.File = sfe;
                        }
                    }
                }
            }
        }

        //check files
        foreach (var langGroup in lang.Groups)
        {
            if (langGroup.Directory == null)
            {
                messages.Add(new GroupDirMissing(langGroup));
            }

            foreach (var sound in langGroup.Sounds)
            {
                if (sound.File == null)
                {
                    messages.Add(new SoundFileMissing(sound));
                }
            }
        }

        return messages;
    }

    public static bool AddPathIsEmpty(string path)
    {
        return string.IsNullOrEmpty(path) || path is "." or ".\\";
    }

    public static bool EqualsPathNames(string name1, string name2)
    {
        return string.Equals(name1, name2, StringComparison.CurrentCultureIgnoreCase);
    }

    /*private static SoundFileElement SearchFromLangRoot(DirectoryElement langDir, FyzSound sound)
    {
        foreach (var groups in langDir.Children)
        {
            
        }
    }*/
}