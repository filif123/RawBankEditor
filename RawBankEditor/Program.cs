using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ExControls;
using RawBankEditor.Forms;
using RawBankEditor.XML;
using ToolsCore;
using ToolsCore.Properties;
using ToolsCore.Tools;
using ToolsCore.XML;

namespace RawBankEditor
{
    #nullable enable
    internal static class Program
    {
        private static readonly string appGuid = 
            ((GuidAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(GuidAttribute), true)[0]).Value;

        /// <summary>
        ///     Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Log.AppDirPath = Application.StartupPath;
            GlobSettings.LinkUpdater = "http://iniss.6f.sk/gvdeditor-updater/update.txt";

            using var mutex = new Mutex(false, "Global\\" + appGuid);

            try
            {
                GlobData.Config = XMLSerialization.ReadData<RawBankEditorConfig>(Utils.CombinePath(Application.StartupPath, FileConsts.FILE_CONFIG));
                GlobSettings.Fonts = GlobData.Config.Fonts;
            }
            catch (Exception e)
            {
                Log.Error($"Chyba pri načítaní konfiguračného súboru: {e.Message}");
                throw;
            }

            Log.DoAppLogs = GlobData.Config.LoggingInfo;
            Log.DoErrorLogs = GlobData.Config.LoggingError;

            try
            {
                GlobData.Styles = Styles<RawBankEditorStyle>.ReadData(Utils.CombinePath(Application.StartupPath, FileConsts.FILE_STYLES));
                GlobData.UsingStyle = GlobData.Styles[GlobData.Styles.UsingStyleID];
                GlobSettings.UsingStyle = GlobData.UsingStyle;
            }
            catch (Exception e)
            {
                Log.Error($"Chyba pri načítaní súboru so štýlmi: {e.Message}");
                throw;
            }

            if (!mutex.WaitOne(0, false) && !GlobData.Config.MoreInstance)
            {
                Log.AppInfo("Duplicitná inštancia ukončená");
                return;
            }

            if (GlobData.Config.ClassicGUI)
            {
                Application.SetCompatibleTextRenderingDefault(true);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
            }

            var culture = CultureInfo.CreateSpecificCulture(GlobData.Config.Language == Config.AppLanguage.Czech ? "cs" : "sk");

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            ExMessageBox.ButtonOKText = GlobalResources.Global_OK;
            ExMessageBox.ButtonCancelText = GlobalResources.Global_Cancel;
            ExMessageBox.ButtonRetryText = GlobalResources.Global_Retry;
            ExMessageBox.ButtonIgnoreText = GlobalResources.Global_Ignore;
            ExMessageBox.ButtonAbortText = GlobalResources.Global_Abort;
            ExMessageBox.ButtonYesText = GlobalResources.Global_Yes;
            ExMessageBox.ButtonNoText = GlobalResources.Global_No;

            var style = new ExMessageBoxStyle
            {
                UseDarkTitleBar = GlobData.UsingStyle.DarkTitleBar,
                ForeColor = GlobData.UsingStyle.ControlsColorScheme.Box.ForeColor,
                BackColor = GlobData.UsingStyle.ControlsColorScheme.Box.BackColor,
                FooterBackColor = GlobData.UsingStyle.ControlsColorScheme.Panel.BackColor,
                DefaultStyle = GlobData.UsingStyle.ControlsDefaultStyle,
                ButtonBackColor = GlobData.UsingStyle.ControlsColorScheme.Button.BackColor,
                ButtonBorderColor = GlobData.UsingStyle.ControlsColorScheme.Border.ForeColor,
                ButtonForeColor = GlobData.UsingStyle.ControlsColorScheme.Button.ForeColor,
                ButtonBorderSize = 1,
                ButtonMouseDownColor = GlobData.UsingStyle.ControlsColorScheme.Highlight.BackColor,
                ButtonMouseOverColor = GlobData.UsingStyle.ControlsColorScheme.Highlight.BackColor,
                ButtonsFont = GlobData.Config.Fonts.Buttons
            };

            ExMessageBox.Style = style;

            foreach (var s in GlobData.Styles.StyleList) SettingsNaming.NameColorSettings(s);

            SettingsNaming.NameAppFontSetting(GlobData.Config.Fonts);
            RawBankEditorSettingsNaming.NameDesktopColsSetting(GlobData.Config.DesktopCols);
            RawBankEditorSettingsNaming.NameShortcutCommands(GlobData.Config.Shortcuts);

            Log.AppInfo($"Program spustený - v.{Application.ProductVersion} - \"{Application.ExecutablePath}\"");

            Application.Run(new FMain());

            Log.AppInfo("Program sa ukončuje\r\n");
        }
    }
}