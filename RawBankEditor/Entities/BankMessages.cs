namespace RawBankEditor.Entities;

public abstract class RawBankMessage
{
    public abstract MessageType Type { get; }

    public abstract string Message { get; }

    public abstract string ResolveMessage { get; }

    public abstract void Resolve();
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
        Directory.CreateDirectory(Language.GetAbsPath());
        Language.Directory = new DirectoryElement(Language.GetAbsPath());
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
        Directory.CreateDirectory(Group.GetAbsPath());
        Group.Directory = new DirectoryElement(Group.GetAbsPath());
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
        var grp = Sound.Group;
        grp.Sounds.Remove(Sound);
    }
}