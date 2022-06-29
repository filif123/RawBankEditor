using RawBankEditor.Forms;
using ToolsCore.Entities;

namespace RawBankEditor.Entities;

public abstract class RawBankMessage
{
    public abstract MessageType Type { get; }

    public abstract string Message { get; }

    public abstract string ResolveMessage { get; }

    /// <summary>
    ///     Resolves the issue. WARNING! - Reset bindings after this call.
    /// </summary>
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
    public override MessageType Type => MessageType.Error;

    public override string Message => $"Jazyk {Language.Key} je definovaný, ale neexistuje v súborovom systéme.";

    public override string ResolveMessage => $"Vytvoriť priečinok {Language.Key}.";

    public FyzLanguage Language { get; }

    public LanguageDirMissing(FyzLanguage language)
    {
        Language = language;
    }

    public override void Resolve()
    {
        Directory.CreateDirectory(Language.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
        Language.Directory = new DirectoryElement(Language.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
    }

    /// <inheritdoc />
    public override void Show()
    {
        throw new NotImplementedException();
    }
}

public class GroupDirMissing : RawBankMessage
{
    public override MessageType Type => MessageType.Error;

    public override string Message => $"Skupina {Group.Name} je definovaná, ale neexistuje v súborovom systéme.";

    public override string ResolveMessage => $"Vytvoriť priečinok {Group.Name} pre jazyk {Group.Language.Key}.";

    public FyzGroup Group { get; }

    public GroupDirMissing(FyzGroup group)
    {
        Group = group;
    }

    public override void Resolve()
    {
        Directory.CreateDirectory(Group.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
        Group.Directory = new DirectoryElement(Group.GetAbsPath(GlobData.OpenedProject.AbsPathToBank));
    }

    /// <inheritdoc />
    public override void Show()
    {
        throw new NotImplementedException();
    }    
}

public class SoundFileMissing : RawBankMessage
{
    public override MessageType Type => MessageType.Error;

    public override string Message => $"Zvuk {Sound.Name} je definovaný, ale neexistuje v súborovom systéme.";

    public override string ResolveMessage => $"Odstrániť dáta o zvuku {Sound.FileName}.";

    public FyzSound Sound { get; }

    public SoundFileMissing(FyzSound sound)
    {
        Sound = sound;
    }

    public override void Resolve()
    {
        Sound.Group.Sounds.Remove(Sound);
    }

    /// <inheritdoc />
    public override void Show()
    {
        throw new NotImplementedException();
    }
}

public class SoundDataMissing : RawBankMessage
{
    public override MessageType Type => MessageType.Error;

    public override string Message => $"Zvuk {File.Name} existuje v súborovom systéme, ale nie je definovaný.";

    public override string ResolveMessage => $"Pridať dáta o zvuku {File.Name}.";

    public SoundFileElement File { get; }

    public SoundDataMissing(SoundFileElement file)
    {
        File = file;
    }
    
    public override void Resolve()
    {
        var form = new FAddSound(File);
        if (form.ShowDialog() == DialogResult.OK) 
            File.Parent.Group?.Add(form.NewSound);
    }

    /// <inheritdoc />
    public override void Show()
    {
        throw new NotImplementedException();
    }
}