using System;
using ExControls;
using RawBankEditor.Entities;
using RawBankEditor.Forms;
using RawBankEditor.Tools;
using RawBankEditor.XML;
using ToolsCore.XML;

namespace RawBankEditor
{
    internal static class GlobData
    {
        public static string AbsPathToBank;
        public static string AbsPathToINISS;
        public static ExBindingList<FyzLanguage> Languages;

        public static RawBankEditorConfig Config;
        public static Styles<RawBankEditorStyle> Styles;
        public static Style UsingStyle;

        public static ExBindingList<RawBankMessage> Messages = new();

        public static void PrepareGlobalData(string pathToINISS)
        {
            Messages.Clear();

            if (string.IsNullOrEmpty(pathToINISS))
                throw new ArgumentNullException(nameof(pathToINISS));

            AbsPathToINISS = pathToINISS;
            AbsPathToBank = pathToINISS + FileConsts.DIR_RAWBANK;
            Languages = new ExBindingList<FyzLanguage>(RawBankParser.ReadFyzBankFile());
        }
    }
}