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
    public static RawBankEditorStyle UsingStyle;

    public static void PrepareGlobalData(string pathToINISS)
    {
        if (string.IsNullOrEmpty(pathToINISS))
            throw new ArgumentNullException(nameof(pathToINISS));

        var pathToBank = pathToINISS + FileConsts.DIR_RAWBANK;

        OpenedProject = new RawBankProject
        {
            AbsPathToINISS = pathToINISS,
            AbsPathToBank = pathToBank,
            Languages = new ExBindingList<FyzLanguage>(RawBankParser.ReadFyzBankFile(pathToBank, out _)),
            Messages = new Dictionary<FyzLanguage, List<IRawBankMessage>>()
        };
    }
}