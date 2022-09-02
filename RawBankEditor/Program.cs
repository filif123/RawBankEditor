using RawBankEditor.Forms;
using ToolsCore;
using ToolsCore.Tools;

namespace RawBankEditor;

internal static class Program
{
    public static FMain MainForm { get; private set; }

    /// <summary>
    ///     Hlavní vstupní bod aplikace.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        GlobSettings.LinkUpdater = "http://iniss.6f.sk/gvdeditor-updater/update.txt";
        AppInit.Initialization(out GlobData.Config, out GlobData.Styles, out GlobData.UsingStyle);

        MainForm = new FMain();
        Application.Run(MainForm);

        Log.Info("Program sa ukončuje\r\n");
    }
}