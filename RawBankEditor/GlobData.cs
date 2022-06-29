using ExControls;
using RawBankEditor.Entities;
using RawBankEditor.XML;
using ToolsCore.Entities;
using ToolsCore.Tools;
using ToolsCore.XML;

namespace RawBankEditor;

internal static class GlobData
{
    public static RawBankProject OpenedProject;

    public static RawBankEditorConfig Config;
    public static Styles<RawBankEditorStyle> Styles;
    public static Style UsingStyle;

    public static readonly ExBindingList<RawBankMessage> Messages = new();

    public static void PrepareGlobalData(string pathToINISS)
    {
        Messages.Clear();

        if (string.IsNullOrEmpty(pathToINISS))
            throw new ArgumentNullException(nameof(pathToINISS));

        var pathToBank = pathToINISS + FileConsts.DIR_RAWBANK;

        OpenedProject = new RawBankProject
        {
            AbsPathToINISS = pathToINISS,
            AbsPathToBank = pathToBank,
            Languages = new ExBindingList<FyzLanguage>(RawBankParser.ReadFyzBankFile(pathToBank, out _))
        };
    }
}