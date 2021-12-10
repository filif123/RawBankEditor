namespace RawBankEditor.Entities;
/*internal class MenuItem
{
    public MenuItemType Type { get; set; }
    public Shortcut Shortcut { get; set; }

    /// <summary>Returns a string that represents the current object.</summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString()
    {
        return $"Type:{Type}, Shortcut:{Shortcut}";
    }
}*/

internal enum MainMenuItemType
{
    OpenDir,
    Save,
    SaveAll,
    Import,
    Export,

    Undo,
    Redo,
    AddSound,
    DeleteSounds,
    MoveSounds,

    GoBack,
    GoForward,
    Search,

    LangSettings,
    AnalyzeBank,
    AppSettings,
    ConvertSounds,

    InfoApp,
    UpdateNotes
}