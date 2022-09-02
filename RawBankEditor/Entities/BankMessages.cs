using RawBankEditor.Forms;
using ToolsCore.Entities;
using ToolsCore.Tools;
// ReSharper disable MemberCanBePrivate.Global

namespace RawBankEditor.Entities;

public abstract class RawBankMessage
{
    public abstract string Code { get; }

    public abstract MessageType Type { get; }

    public abstract string Message { get; }

    public abstract string ResolveMessage { get; }

    public abstract string Path { get; }

    public abstract void Resolve();

    public abstract void Show();
}

public enum MessageType
{
    Info,
    Warning,
    Error
}

public class LanguageDirMissing : RawBankMessage
{
    /// <inheritdoc />
    public override string Code => "LanguageDirMissing";

    /// <inheritdoc />
    public override MessageType Type => MessageType.Error;

    /// <inheritdoc />
    public override string Message => $"Jazyk '{Language.Key}' je definovaný, ale neexistuje v súborovom systéme.";

    /// <inheritdoc />
    public override string ResolveMessage => $"Vytvoriť priečinok '{Language.Key}'.";

    /// <inheritdoc />
    public override string Path => Language.GetAbsPath("");

    public FyzLanguage Language { get; }

    public LanguageDirMissing(FyzLanguage language)
    {
        Language = language;
    }

    public override void Resolve()
    {
        try
        {
            Directory.CreateDirectory(Language.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
            Language.Directory = new DirectoryElement(Language.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
        }
        catch (Exception e)
        {
            Utils.ShowError(e.Message);
        }
    }

    /// <inheritdoc />
    public override void Show()
    {
        // do nothing
    }
}

public class GroupDirMissing : RawBankMessage
{
    /// <inheritdoc />
    public override string Code => "GroupDirMissing";

    /// <inheritdoc />
    public override MessageType Type => MessageType.Error;

    /// <inheritdoc />
    public override string Message => $"Skupina '{Group.Name}' je definovaná, ale neexistuje v súborovom systéme.";

    /// <inheritdoc />
    public override string ResolveMessage => $"Vytvoriť priečinok '{Group.Name}' pre jazyk '{Group.Language.Key}'.";

    /// <inheritdoc />
    public override string Path => Group.GetAbsPath("");

    public FyzGroup Group { get; }

    public GroupDirMissing(FyzGroup group)
    {
        Group = group;
    }

    public override void Resolve()
    {
        try
        {
            Directory.CreateDirectory(Group.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
            Group.Directory = new DirectoryElement(Group.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
        }
        catch (Exception e)
        {
            Utils.ShowError(e.Message);
        }
    }

    /// <inheritdoc />
    public override void Show()
    {
        var index = Program.MainForm.CurrentLanguage.Groups.IndexOf(Group);
        if (index != -1)
        {
            Program.MainForm.dgvGroups.ClearSelection();
            Program.MainForm.dgvGroups.Rows[index].Selected = true;
        }
    }    
}

public class SoundFileMissing : RawBankMessage
{
    /// <inheritdoc />
    public override string Code => "SoundFileMissing";

    /// <inheritdoc />
    public override MessageType Type => MessageType.Error;

    /// <inheritdoc />
    public override string Message => $"Zvuk '{Sound.Name}' je definovaný, ale neexistuje v súborovom systéme.";

    /// <inheritdoc />
    public override string ResolveMessage => $"Odstrániť dáta o zvuku '{Sound.FileName}'.";

    /// <inheritdoc />
    public override string Path => Sound.GetAbsPath("");

    public FyzSound Sound { get; }

    public SoundFileMissing(FyzSound sound)
    {
        Sound = sound;
    }

    public override void Resolve()
    {
        Program.MainForm.RegisterNewAction(new FMain.RemovedSoundsAction(Program.MainForm, Sound));
        Sound.Group.Sounds.Remove(Sound);
    }

    /// <inheritdoc />
    public override void Show()
    {
        var index = Program.MainForm.CurrentLanguage.Groups.IndexOf(Sound.Group);
        if (index == -1) 
            return;

        Program.MainForm.dgvGroups.ClearSelection();
        Program.MainForm.SelectSound(Sound);
    }
}

public class SoundDataMissing : RawBankMessage
{
    /// <inheritdoc />
    public override string Code => "SoundDataMissing";

    /// <inheritdoc />
    public override MessageType Type => MessageType.Warning;

    /// <inheritdoc />
    public override string Message => $"Zvuk '{File.Name}' existuje v súborovom systéme, ale nie je definovaný.";

    /// <inheritdoc />
    public override string ResolveMessage => $"Pridať dáta o zvuku '{File.Name}'.";

    /// <inheritdoc />
    public override string Path => File.FileInfo.FullName;

    public SoundFileElement File { get; }

    public SoundDataMissing(SoundFileElement file)
    {
        File = file;
    }
    
    public override void Resolve()
    {
        var form = new FAddSound(File);
        if (form.ShowDialog() == DialogResult.OK)
        {
            Program.MainForm.RegisterNewAction(new FMain.AddSoundAction(Program.MainForm, form.Sound));
            File.Parent.Group?.Sounds.Add(form.Sound);
        }
    }

    /// <inheritdoc />
    public override void Show()
    {
        var grp = File.Parent.Group;
        var index = Program.MainForm.CurrentLanguage.Groups.IndexOf(grp);
        if (index != -1)
        {
            Program.MainForm.dgvGroups.ClearSelection();
            Program.MainForm.dgvGroups.Rows[index].Selected = true;
            Program.MainForm.SelectElement = File;
        }
        else
        {
            Program.MainForm.SelectElement = File;
            Program.MainForm.FillExplorerList(File.Parent);
        }
    }
}

public class InvalidSoundFile : RawBankMessage
{
    /// <inheritdoc />
    public override string Code => "InvalidSoundFile";

    /// <inheritdoc />
    public override MessageType Type => MessageType.Error;

    /// <inheritdoc />
    public override string Message => $"Zvuk '{File.Name}' je definovaný, ale obsahuje neplatný formát.";

    /// <inheritdoc />
    public override string ResolveMessage => $"Odstrániť súbor so zvukom '{File.Name}'.";

    /// <inheritdoc />
    public override string Path => File.FileInfo.FullName;

    public SoundFileElement File { get; }

    public InvalidSoundFile(SoundFileElement file)
    {
        File = file;
    }    

    /// <inheritdoc />
    public override void Resolve()
    {
        Program.MainForm.RegisterNewAction();
        Utils.DeleteFileToRecycleBin(File.FileInfo.FullName);
    }

    /// <inheritdoc />
    public override void Show()
    {
        var grp = File.Parent.Group;
        var index = Program.MainForm.CurrentLanguage.Groups.IndexOf(grp);
        if (index != -1)
        {
            Program.MainForm.dgvGroups.ClearSelection();
            Program.MainForm.dgvGroups.Rows[index].Selected = true;
        }
        else
        {
            Program.MainForm.FillExplorerList(File.Parent);
        }

        index = Program.MainForm.ExplorerContent.IndexOf(File);
        if (index == -1)
            return;

        Program.MainForm.dgvExplorer.ClearSelection();
        Program.MainForm.dgvExplorer.Rows[index].Selected = true;
    }
}

public class EmptyGroup : RawBankMessage
{
    /// <inheritdoc />
    public override string Code => "EmptyGroup";

    /// <inheritdoc />
    public override MessageType Type => MessageType.Info;

    /// <inheritdoc />
    public override string Message => $"Skupina '{Group.Name}' je prázdna.";

    /// <inheritdoc />
    public override string ResolveMessage => $"Odstrániť skupinu '{Group.Name}'.";

    /// <inheritdoc />
    public override string Path => Group.GetAbsPath(GlobData.OpenedProject.AbsPathToBank);

    public FyzGroup Group { get; }

    public EmptyGroup(FyzGroup group)
    {
        Group = group;
    }

    /// <inheritdoc />
    public override void Resolve()
    {
        Program.MainForm.RegisterNewAction();
        Utils.DeleteDirectoryToRecycleBin(Group.Directory.DirInfo.FullName);
    }

    /// <inheritdoc />
    public override void Show()
    {
        var index = Program.MainForm.CurrentLanguage.Groups.IndexOf(Group);
        if (index != -1)
        {
            Program.MainForm.dgvGroups.ClearSelection();
            Program.MainForm.dgvGroups.Rows[index].Selected = true;
        }
    }
}