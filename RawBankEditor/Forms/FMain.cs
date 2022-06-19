using ExControls;
using ExControls.Providers;
using RawBankEditor.Entities;
using RawBankEditor.Properties;
using RawBankEditor.Tools;
using ToolsCore.Tools;
using ToolsCore.XML;
using ProgressBarStyle = System.Windows.Forms.ProgressBarStyle;

namespace RawBankEditor.Forms;

public partial class FMain : Form
{
    private readonly ShellIcon error, warning, info;
    private readonly ExBindingList<FileSystemElement> ExplorerContent = new();

    //private readonly Stack<MoveAction> MoveBackActions = new();
    //private readonly Stack<MoveAction> MoveForwardActions = new();
    //private readonly Stack<ChangeAction> RedoActions = new();
    //private readonly Stack<ChangeAction> UndoActions = new();
    
    private readonly UndoRedoManager moveManager = new();
    private readonly UndoRedoManager changeManager = new();

    private MovePosition lastMovePosition;

    private string cellOldValue;

    private BackButtonElement explorerBack;

    private bool langAlreadySet;
    private bool programSelection;
    private bool saved = true;

    private bool programmaticChange;

    //private ExBindingList<RawBankMessage> ActualMessages;

    internal static FyzLanguage CurrentLanguage { get; set; }
    internal static FyzGroup CurrentGroup { get; set; }

    internal DirectoryElement Root { get; set; }
    internal DirectoryElement CurrentDirectory { get; set; }

    internal FMain()
    {
        InitializeComponent();

        FormUtils.SetFormFont(this);
        menuStripMain.Renderer = new ToolStripProfessionalRenderer(new FormUtils.LightColorTable());

        moveManager.ManagerEnabled = true;
        changeManager.ManagerEnabled = true;

        switch (GlobData.Config.DesktopMenuMode)
        {
            case Config.DesktopMenu.MsTs:
                menuStripMain.Visible = true;
                toolStripMain.Visible = true;
                menuStripMain.Items.Remove(tscboxLanguages);
                break;
            case Config.DesktopMenu.MsOnly:
                menuStripMain.Visible = true;
                toolStripMain.Visible = false;
                menuStripMain.Items.Add(tscboxLanguages);
                break;
            case Config.DesktopMenu.TsOnly:
                menuStripMain.Visible = false;
                toolStripMain.Visible = true;
                menuStripMain.Items.Remove(tscboxLanguages);
                break;
        }

        var dirs = AppRegistry.GetRecentDirs(Application.ProductName);

        foreach (var recentDir in dirs)
        {
            ToolStripItem item1 = new ToolStripMenuItem(recentDir);
            ToolStripItem item2 = new ToolStripMenuItem(recentDir);

            item1.Click += nedavneDirsClick;
            item2.Click += nedavneDirsClick;
            tsmimRecent.DropDownItems.Add(item1);
            tsbRecent.DropDownItems.Add(item2);
        }

        if (dirs.Count == 0 || dirs[0] == "")
        {
            tsmimRecent.Enabled = false;
            tsbRecent.Enabled = false;
        }
        else
        {
            tsmimRecent.Enabled = true;
            tsbRecent.Enabled = true;
        }

        error = new ShellIcon(ShellIconType.Error, ShellIconSize.Small);
        warning = new ShellIcon(ShellIconType.Warning, ShellIconSize.Small);
        info = new ShellIcon(ShellIconType.Info, ShellIconSize.Small);
        tsbErrors.Image = error.ToBitmap();
        tsbWarnings.Image = warning.ToBitmap();
        tsbInfos.Image = info.ToBitmap();

        dgvExplorer.DataSource = ExplorerContent;

        this.ApplyTheme();

        GlobData.Messages.ListChanged += Messages_ListChanged;
    }

    private bool Saved
    {
        get => saved;
        set
        {
            saved = value;
            if (!saved)
                Text += @" *";
            else
                Text = Text.Replace("*", "");
        }
    }

    private void ChangeStatus(string status)
    {
        tsslStatus.Text = status;
    }

    private void ChangeStatusReady()
    {
        tsslStatus.Text = "Pripravený";
    }

    private void PrepareGlobalData(string dirpath)
    {
        dgvErrors.DataSource = null;

        if (GlobData.Config.DebugModeGUI != Config.DebugMode.AppCrash)
            try
            {
                GlobData.PrepareGlobalData(dirpath);
            }
            catch (Exception exception)
            {
                Log.Exception(exception);

                switch (GlobData.Config.DebugModeGUI)
                {
                    case Config.DebugMode.OnlyMessage:
                        Utils.ShowError(exception.Message);
                        break;
                    case Config.DebugMode.DetailedInfo:
                        Utils.ShowError(exception.ToString());
                        break;
                }
            }
        else
            GlobData.PrepareGlobalData(dirpath);

        FyzLanguage lang = null;

        switch (GlobData.Languages.Count)
        {
            case 0:
                Utils.ShowWarning("V banke sa nenachádza žiadnen jazyk.\r\nMôžete pridať nový jazyk.");
                break;
            case 1:
                lang = GlobData.Languages[0];
                break;
            default:
                var flang = new FLangChoose();
                var result = flang.ShowDialog();
                if (result == DialogResult.OK)
                    lang = flang.Selected;
                break;
        }

        if (lang == null)
            return;

        CurrentLanguage = lang;

        langAlreadySet = true;
        tscboxLanguages.ComboBox.DataSource = GlobData.Languages;
        langAlreadySet = false;

        tspbProgress.Visible = true;
        ChangeStatus("Načítanie súborov banky");
        bWorkerReadDat.RunWorkerAsync(lang);
        
        moveManager.Clear();
        changeManager.Clear();
    }

    private void nedavneDirsClick(object sender, EventArgs e)
    {
        var menuItem = (ToolStripMenuItem)sender;
        var menuText = menuItem.Text;

        PrepareGlobalData(menuText);
    }

    private void DoOpenDir()
    {
        var dialog = new ExFolderBrowserDialog { Title = "Vyberte priečinok s INISS.exe" };
        if (!dialog.Show(Handle))
            return;

        var selectedPath = dialog.FileName;

        PrepareGlobalData(selectedPath);
        AppRegistry.SetNewRecentDir(Application.ProductName, selectedPath);
    }

    private void bWorkerReadDat_DoWork(object sender, DoWorkEventArgs e)
    {
        //part 1 - read and analyze all files in rawbank
        var progressFiles = new ProgressStatus("Načítavanie súborového systému", 0);
        bWorkerReadDat.ReportProgress(-1, progressFiles);
        Root = RawBankParser.ExploreFileSystem();

        //part 2 - analyze FYZZVUK.dat file
        var lang = (FyzLanguage)e.Argument;
        RawBankParser.ReadFyzZvukFile(lang, bWorkerReadDat);

        //part 3 - merge physical files and logical data
        foreach (var msg in RawBankParser.MergeFilesAndData(Root, lang))
        {
            Invoke((MethodInvoker) delegate
            {
                GlobData.Messages.Add(msg);
            });
        }
    }

    private void bWorkerReadDat_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        if (e.UserState != null)
        {
            var status = (ProgressStatus)e.UserState;
            tspbProgress.Maximum = status.TotalProgress;
            tsslStatus.Text = status.ProgressPartName;
        }

        tspbProgress.Style = e.ProgressPercentage == -1 ? ProgressBarStyle.Marquee : ProgressBarStyle.Blocks;
        if (e.ProgressPercentage != -1) tspbProgress.Value = e.ProgressPercentage;
    }

    private void bWorkerReadDat_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        tspbProgress.Visible = false;

        if (GlobData.Config.DebugModeGUI != Config.DebugMode.AppCrash)
            if (e.Error != null)
            {
                Log.Exception(e.Error);

                ChangeStatus("Vznikla chyba pri načítaní banky");

                switch (GlobData.Config.DebugModeGUI)
                {
                    case Config.DebugMode.OnlyMessage:
                        Utils.ShowError(e.Error.Message);
                        break;
                    case Config.DebugMode.DetailedInfo:
                        Utils.ShowError(e.Error.ToString());
                        break;
                }

                return;
            }

        programmaticChange = true;
        dgvSounds.DataSource = null;
        lboxGroups.DataSource = CurrentLanguage.Groups;
        tscboxLanguages.Enabled = true;
        programmaticChange = false;

        lastMovePosition = new MovePosition(GetSelectedRows(), CurrentLanguage, CurrentGroup);

        ChangeStatusReady();

        SwitchAddSoundButtons(true);
        SwitchDeleteSoundButtons(true);
        SwitchLangSettingsButtons(true);
        SwitchAnalyzeButtons(true);
        SwitchConvertSoundsButtons(true);
        SwitchSearchButtons(true);
        SwitchImportButtons(true);
        SwitchExportButtons(true);

        SwitchSaveAllButtons(true);

        dgvErrors.DataSource = GlobData.Messages;
    }

    private void RegisterNewAction(ICommand action)
    {
        changeManager.AddCommand(action);
        EnableUndoRedo();
    }

    private void DoSave()
    {
    }

    private void DoSaveAll()
    {
    }

    private void DoImport()
    {
    }

    private void DoExport()
    {
    }

    private void DoUndo()
    {
        changeManager.Undo();
        EnableUndoRedo();
    }

    private void DoRedo()
    {
        changeManager.Redo();
        EnableUndoRedo();
    }

    private void EnableUndoRedo()
    {
        SwitchUndoButtons(changeManager.CanUndo);
        SwitchRedoButtons(changeManager.CanRedo);
    }

    private void EnableGoBackForward()
    {
        SwitchGoBackButtons(moveManager.CanUndo);
        SwitchGoForwardButtons(moveManager.CanRedo);
    }

    private void DoGoBack()
    {
        moveManager.Undo();
        EnableGoBackForward();
    }

    private void DoGoForward()
    {
        moveManager.Redo();
        EnableGoBackForward();
    }

    private void DoSearch()
    {
        var fsearch = new FSearch(this);
        fsearch.Show(this);
    }

    private void DoAddSound()
    {
    }

    private void DoDeleteSounds()
    {
        if (dgvSounds.SelectedRows.Count == 0 || lboxGroups.SelectedIndex == -1)
            return;

        var grp = (FyzGroup)lboxGroups.SelectedItem;

        var sounds = new List<FyzSoundPos>();
        var action = new RemovedSoundsAction(this, CurrentLanguage, grp) { Sounds = sounds };

        foreach (DataGridViewRow row in dgvSounds.SelectedRows)
        {
            var pos = new FyzSoundPos(row.DataBoundItem as FyzSound, row.Index);
            sounds.Add(pos);
            CurrentLanguage.Groups[lboxGroups.SelectedIndex].Sounds.RemoveAt(row.Index);
        }

        RegisterNewAction(action);
    }

    private void DoMoveSounds()
    {
    }

    private void ShowLangSettings()
    {
    }

    private void ShowAppSettings()
    {
    }

    private static void ShowInfoApp()
    {
        var iform = new FInfoApp();
        iform.ShowDialog();
    }

    private void ShowAnalyzer()
    {
    }

    private void ShowConverter()
    {
        var cform = new FSoundConvert();
        cform.ShowDialog();
    }

    private static void ShowUpdates()
    {
        Process.Start("http://iniss.6f.sk/gvdeditor/novinky/");
    }

    private void tscboxLanguages_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tscboxLanguages.SelectedIndex != -1 && !langAlreadySet)
        {
            CurrentLanguage = tscboxLanguages.SelectedItem as FyzLanguage;
            if (!bWorkerReadDat.IsBusy) 
                bWorkerReadDat.RunWorkerAsync(tscboxLanguages.SelectedItem);
        }
    }

    private void MainMenuItemClicked(object sender, EventArgs e)
    {
        if (sender is not ToolStripItem c)
            return;
        var type = (MainMenuItemType)c.Tag;
        switch (type)
        {
            case MainMenuItemType.OpenDir: DoOpenDir(); break;
            case MainMenuItemType.Save: DoSave(); break;
            case MainMenuItemType.SaveAll: DoSaveAll(); break;
            case MainMenuItemType.Import: DoImport(); break;
            case MainMenuItemType.Export: DoExport(); break;
            case MainMenuItemType.Undo: DoUndo(); break;
            case MainMenuItemType.Redo: DoRedo(); break;
            case MainMenuItemType.AddSound: DoAddSound(); break;
            case MainMenuItemType.DeleteSounds: DoDeleteSounds(); break;
            case MainMenuItemType.MoveSounds: DoMoveSounds(); break;
            case MainMenuItemType.GoBack: DoGoBack(); break;
            case MainMenuItemType.GoForward: DoGoForward(); break;
            case MainMenuItemType.Search: DoSearch(); break;
            case MainMenuItemType.LangSettings: ShowLangSettings(); break;
            case MainMenuItemType.AnalyzeBank: ShowAnalyzer(); break;
            case MainMenuItemType.AppSettings: ShowAppSettings(); break;
            case MainMenuItemType.ConvertSounds: ShowConverter(); break;
            case MainMenuItemType.InfoApp: ShowInfoApp(); break;
            case MainMenuItemType.UpdateNotes: ShowUpdates(); break;
            default: return;
        }
    }

    private void tsbAddGroup_Click(object sender, EventArgs e)
    {
        var fedit = new FEditGroup();
        if (fedit.ShowDialog(this) == DialogResult.OK)
        {
        }
    }

    private void tsbEditGroup_Click(object sender, EventArgs e)
    {
    }

    private void tsbDeleteGroup_Click(object sender, EventArgs e)
    {
    }

    private void lboxGroups_SelectedIndexChanged(object sender, EventArgs e)
    {
        CurrentGroup = (FyzGroup)lboxGroups.SelectedItem;
        if (lboxGroups.SelectedIndex != -1)
        {
            dgvSounds.DataSource = CurrentGroup.Sounds;
            FillExplorerList(CurrentGroup.Directory);

            foreach (DataGridViewRow row in dgvSounds.Rows) 
                ValidateRow(row.Index);
        }
    }

    private void dgvSounds_SelectionChanged(object sender, EventArgs e)
    {
            
        var rows = GetSelectedRows();
        if (rows.Length == 0)
            return;

        if (!programmaticChange)
        {
            var newPosition = new MovePosition(rows, CurrentLanguage, CurrentGroup);
            var action = new SelectedCellSoundMoveAction(this, lastMovePosition, newPosition);
            moveManager.AddCommand(action);
            EnableGoBackForward();
            lastMovePosition = newPosition;
        }

        var item = (FyzSound)dgvSounds.Rows[dgvSounds.SelectedRows[0].Index].DataBoundItem;
        if (item is not null)
            //this folder
            if (string.IsNullOrEmpty(item.AdditionalRelativePath) || item.AdditionalRelativePath == "\\")
            {
                dgvExplorer.ClearSelection();
                for (var j = 0; j < ExplorerContent.Count; j++)
                {
                    var element = ExplorerContent[j];
                    if (element is SoundFileElement sfe && sfe.Name == item.FileName)
                    {
                        dgvExplorer.Rows[j].Selected = true;
                        dgvExplorer.FirstDisplayedScrollingRowIndex = dgvExplorer.Rows[j].Index;
                    }
                }
            }
        //another folder
        /*var index = listVExplorer.Items.IndexOfKey(item.FileName);
            if (index != -1)
            {
                listVExplorer.SelectedIndices.Add(index);
                listVExplorer.Select();
                listVExplorer.EnsureVisible(index);
            }*/
    }

    private object[] GetSelectedRows()
    {
        var count = dgvSounds.SelectedRows.Count;
        if (count == 0 || programSelection)
            return Array.Empty<object>();

        var rows = new object[count];

        for (var i = 0; i < count; i++)
        {
            var row = dgvSounds.SelectedRows[i];
            rows[i] = row.DataBoundItem;
        }

        return rows;
    }

    private void dgvSounds_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        // TODO ak zadany wav subor neexistuje, zafarbi sa na cerveno
    }

    private void SwitchGoBackButtons(bool enabled)
    {
        tsbGoBack.Enabled = enabled;
        tsmimGoBack.Enabled = enabled;
    }

    private void SwitchGoForwardButtons(bool enabled)
    {
        tsbGoForward.Enabled = enabled;
        tsmimGoForward.Enabled = enabled;
    }

    private void SwitchUndoButtons(bool enabled)
    {
        tsbUndo.Enabled = enabled;
        tsmimUndo.Enabled = enabled;
    }

    private void SwitchRedoButtons(bool enabled)
    {
        tsbRedo.Enabled = enabled;
        tsmimRedo.Enabled = enabled;
    }

    private void SwitchSaveButtons(bool enabled)
    {
        tsbSave.Enabled = enabled;
        tsmimSave.Enabled = enabled;
    }

    private void SwitchSaveAllButtons(bool enabled)
    {
        tsbSaveAll.Enabled = enabled;
        tsmimSaveAll.Enabled = enabled;
    }

    private void SwitchImportButtons(bool enabled)
    {
        tsbImport.Enabled = enabled;
        tsmimImport.Enabled = enabled;
    }

    private void SwitchExportButtons(bool enabled)
    {
        tsbExport.Enabled = enabled;
        tsmimExport.Enabled = enabled;
    }

    private void SwitchLangSettingsButtons(bool enabled)
    {
        tsbLangsSettings.Enabled = enabled;
        tsmimLangsSettings.Enabled = enabled;
    }

    private void SwitchAnalyzeButtons(bool enabled)
    {
        tsbAnalyze.Enabled = enabled;
        tsmimAnalyze.Enabled = enabled;
    }

    private void SwitchConvertSoundsButtons(bool enabled)
    {
        tsbConvertSounds.Enabled = enabled;
        tsmimConvertSounds.Enabled = enabled;
    }

    private void SwitchSearchButtons(bool enabled)
    {
        tsbSearch.Enabled = enabled;
        tsmimSearch.Enabled = enabled;
    }

    private void SwitchAddSoundButtons(bool enabled)
    {
        tsbAddSound.Enabled = enabled;
        tsmimAddSound.Enabled = enabled;
    }

    private void SwitchDeleteSoundButtons(bool enabled)
    {
        tsbDeleteSound.Enabled = enabled;
        tsmimDeleteSound.Enabled = enabled;
    }

    private void mmErrors_Click(object sender, EventArgs e)
    {
        if (!splitSoundsErrors.Panel2Collapsed)
        {
            splitSoundsErrors.Panel2Collapsed = true;
        }
    }

    private void tssbErrors_Click(object sender, EventArgs e)
    {
        splitSoundsErrors.Panel2Collapsed = false;
    }

    private void FMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!string.IsNullOrEmpty(GlobData.AbsPathToBank) && !Saved)
        {
            var result = Utils.ShowQuestion(Resources.FMain_Save_Changes, MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Yes:
                    DoSave();
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = false;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }
    }

    private void FMain_FormClosed(object sender, FormClosedEventArgs e)
    {
        error.Dispose();
        warning.Dispose();
        info.Dispose();
    }

    private void lboxGroups_KeyDown(object sender, KeyEventArgs e)
    {
        if (lboxGroups.SelectedIndex == -1)
            return;

        if (e.KeyCode == Keys.PageUp)
        {
            var sel = lboxGroups.SelectedIndex;

            if (sel - 1 >= 0)
            {
                CurrentLanguage.Groups.RemoveAt(sel);
                CurrentLanguage.Groups.Insert(sel - 1, CurrentGroup);
                lboxGroups.ClearSelected();
                lboxGroups.SelectedIndex = sel - 1;
            }
        }
        else if (e.KeyCode == Keys.PageDown)
        {
            var sel = lboxGroups.SelectedIndex;

            if (sel + 1 < CurrentLanguage.Groups.Count)
            {
                CurrentLanguage.Groups.RemoveAt(sel);
                CurrentLanguage.Groups.Insert(sel + 1, CurrentGroup);
                lboxGroups.ClearSelected();
                lboxGroups.SelectedIndex = sel + 1;
            }
        }

        e.Handled = true;
    }

    private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
    {
        //e.
    }

    private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
    {
    }

    private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
    {
            
    }

    private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
    {
            
    }

    private void dgvExplorer_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        //TODO na zmenu cesty a nazvu suboru zvuku
        if (dgvSounds.SelectedRows.Count == 0 || dgvExplorer.Rows[e.RowIndex].DataBoundItem is not SoundFileElement sfe)
            return;

        if (dgvSounds.SelectedRows[0].DataBoundItem is FyzSound snd)
        {
            snd.File = sfe;
            snd.FileName = sfe.Name;
            if (CurrentGroup.Directory != sfe.Parent)
            {
                snd.AdditionalRelativePath = Path.GetDirectoryName(Utils.GetRelativePath(sfe.FileInfo.FullName, CurrentLanguage.GetAbsPath())) + Path.DirectorySeparatorChar;
            }
        }

        dgvSounds.ResetBindings();
        dgvSounds.Refresh();
    }

    private void dgvExplorer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvExplorer.SelectedRows.Count == 0)
            return;

        switch (dgvExplorer.SelectedRows[0].DataBoundItem)
        {
            case BackButtonElement b:
                var dirinfo = b.ParentDirectory;
                if (dirinfo != null)
                    FillExplorerList(dirinfo);
                break;
            case SoundFileElement sf:
                SoundUtils.Play(sf.FileInfo.FullName);
                break;
            case DirectoryElement de:
                FillExplorerList(de);
                break;
        }
    }

    private void dgvSounds_UserAddedRow(object sender, DataGridViewRowEventArgs e)
    {
        var action = new AddSoundAction(this, CurrentLanguage, CurrentGroup, e.Row.Index);
        RegisterNewAction(action);
    }

    private void dgvSounds_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        //DELETE
    }

    private void dgvSounds_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
    {
        ValidateRow(e.RowIndex);
    }

    private void dgvSounds_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        Utils.ShowError("Tabuľka obsahuje nesprávny údaj: " + e.Exception.Message);
    }

    private void dgvSounds_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
        var val = dgvSounds.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        cellOldValue = val == null ? "" : val.ToString();
    }

    private void dgvSounds_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        var newval = dgvSounds.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        if (newval is not string s || s == cellOldValue)
            return;

        var action = new EditSoundAction(this, CurrentLanguage, CurrentGroup);
        action.Type = dgvSounds.Columns[e.ColumnIndex].Name switch
        {
            "key" => PropertyType.Key,
            "name" => PropertyType.Name,
            "file" => PropertyType.FileName,
            "relativePath" => PropertyType.RelativePath,
            "text" => PropertyType.Text,
            _ => action.Type
        };

        action.OldValue = cellOldValue;
        action.NewValue = s;
        action.Row = e.RowIndex;

        RegisterNewAction(action);
    }

    private void dgvExplorer_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex == -1)
            return;

        if (dgvExplorer.Columns["cType"] != null && e.ColumnIndex == dgvExplorer.Columns["cType"].Index)
        {
            e.Value = dgvExplorer.Rows[e.RowIndex].DataBoundItem switch
            {
                BackButtonElement => Resources.back,
                DirectoryElement => Resources.open,
                SoundFileElement => Resources.sound,
                _ => Resources.file
            };
        }
        else if (dgvExplorer.Columns["cDuration"] != null && e.ColumnIndex == dgvExplorer.Columns["cDuration"].Index)
        {
            var item = dgvExplorer.Rows[e.RowIndex].DataBoundItem as FileSystemElement;
            e.Value = item switch
            {
                SoundFileElement se => se.DurationText,
                DirectoryElement de => de.GetCountChildren() + " položiek",
                _ => null
            };
        }
    }

    private void dgvExplorer_SelectionChanged(object sender, EventArgs e)
    {
        if (dgvExplorer.SelectedRows.Count != 0)
        {
            var item = dgvExplorer.SelectedRows[0].DataBoundItem;

            tsbOpenInExplorer.Enabled = true;
            tsbRenameFileDir.Enabled = true;
            tsbRemoveFileDir.Enabled = true;
            tsbPlay.Enabled = item is SoundFileElement;
        }
        else
        {
            tsbOpenInExplorer.Enabled = false;
            tsbPlay.Enabled = false;
            tsbRenameFileDir.Enabled = false;
            tsbRemoveFileDir.Enabled = false;
        }
    }

    private void tsbOpenInExplorer_Click(object sender, EventArgs e)
    {
        if (dgvExplorer.SelectedRows.Count == 0)
            return;

        var item = dgvExplorer.SelectedRows[0].DataBoundItem as FileSystemElement;

        switch (item)
        {
            case DirectoryElement de:
                Process.Start(de.DirInfo.FullName);
                break;
            case FileElement fe:
            {
                if (fe.FileInfo.DirectoryName != null)
                    Process.Start(fe.FileInfo.DirectoryName);
                break;
            }
        }
    }

    private void tsbPlay_Click(object sender, EventArgs e)
    {
        if (dgvExplorer.SelectedRows.Count == 0)
            return;

        var item = dgvExplorer.SelectedRows[0].DataBoundItem as FileSystemElement;

        if (item is SoundFileElement se)
            SoundUtils.Play(se.FileInfo.FullName);
    }

    private void ValidateRow(int row)
    {
        if (row == dgvSounds.NewRowIndex || CurrentGroup == null)
            return;

        dgvSounds.Rows[row].Cells["file"].ErrorText = null;
        var value = (string)dgvSounds.Rows[row].Cells["file"].Value;

        if (string.IsNullOrEmpty(value))
            dgvSounds.Rows[row].Cells["file"].ErrorText = "Neplatný názov súboru";

        var path = GlobData.AbsPathToBank + CurrentLanguage.RelativePath + CurrentGroup.RelativePath + value;
        if (!File.Exists(path))
            dgvSounds.Rows[row].Cells["file"].ErrorText = "Súbor v priečinku neexistuje";
    }

    private void FillExplorerList(DirectoryElement dir)
    {
        ExplorerContent.Clear();
        explorerBack = null;

        //skupina neexistuje v suborovom systeme
        if (dir is null)
        {
            explorerBack = new BackButtonElement(CurrentDirectory);
            ExplorerContent.Add(explorerBack);
            return;
        }

        CurrentDirectory = dir;

        if (dir.DirInfo.Exists)
        {
            if (!IsRootPath(dir))
            {
                explorerBack = new BackButtonElement(dir.Parent);
                ExplorerContent.Add(explorerBack);
            }

            foreach (var element in dir.Children)
            {
                ExplorerContent.Add(element);

                if (element is SoundFileElement { Duration: -1 } sound) 
                    sound.Duration = SoundUtils.GetSoundDuration(sound.FileInfo.FullName);
            }
        }
    }

    private void tsbErrors_CheckedChanged(object sender, EventArgs e)
    {
        ShowHideMessages();
    }

    private void tsbWarnings_CheckedChanged(object sender, EventArgs e)
    {
        ShowHideMessages();
    }

    private void tsbInfos_CheckedChanged(object sender, EventArgs e)
    {
        ShowHideMessages();
    }

    private void ShowHideMessages()
    {
        var showErrors = tsbErrors.Checked;
        var showWarnings = tsbWarnings.Checked;
        var showInfos = tsbInfos.Checked;

        //https://stackoverflow.com/questions/18942017/unable-to-set-row-visible-false-of-a-datagridview
        var currencyManager = (CurrencyManager)BindingContext[dgvErrors.DataSource];
        currencyManager.SuspendBinding();
            
        foreach (DataGridViewRow row in dgvErrors.Rows)
        {
            if (row.DataBoundItem is RawBankMessage message)
            {
                if (showErrors && message.Type == MessageType.Error)
                    row.Visible = true;
                else if (showWarnings && message.Type == MessageType.Warning)
                    row.Visible = true;
                else if (showInfos && message.Type == MessageType.Info)
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        currencyManager.ResumeBinding();
    }

    private void dgvErrors_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (dgvErrors.Columns["dgvicType"]?.Index == e.ColumnIndex)
        {
            if (dgvErrors.Rows[e.RowIndex].DataBoundItem is RawBankMessage msg)
            {
                switch (msg.Type)
                {
                    case MessageType.Info:
                        e.Value = info.ToBitmap();
                        dgvErrors.Rows[e.RowIndex].Cells["dgvicType"].ToolTipText = "Informácia";
                        break;
                    case MessageType.Warning:
                        e.Value = warning.ToBitmap();
                        dgvErrors.Rows[e.RowIndex].Cells["dgvicType"].ToolTipText = "Upozornenie";
                        break;
                    case MessageType.Error:
                        e.Value = error.ToBitmap();
                        dgvErrors.Rows[e.RowIndex].Cells["dgvicType"].ToolTipText = "Chyba";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
                
        }
    }

    private static bool IsRootPath(DirectoryElement dir)
    {
        return string.Compare(
            Path.GetFullPath(dir.DirInfo.FullName).TrimEnd('\\'),
            Path.GetFullPath(GlobData.AbsPathToBank + CurrentLanguage.RelativePath).TrimEnd('\\'),
            StringComparison.InvariantCultureIgnoreCase) == 0;
    }

    private void Messages_ListChanged(object sender, ListChangedEventArgs e)
    {
        var errorCount = 0;
        var warningCount = 0;
        var infoCount = 0;

        foreach (var message in GlobData.Messages)
        {
            switch (message.Type)
            {
                case MessageType.Info:
                    infoCount++;
                    break;
                case MessageType.Warning:
                    warningCount++;
                    break;
                case MessageType.Error:
                    errorCount++;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        Invoke(new MethodInvoker(() =>
        {
            tsbErrors.Text = $"{errorCount} chýb";
            tsbWarnings.Text = $"{warningCount} upozornení";
            tsbInfos.Text = $"{infoCount} správ";

            if (errorCount != 0)
            {
                tssbErrors.Image = error.ToBitmap();
                tssbErrors.Text = $"{errorCount} chýb";
                tssbErrors.ForeColor = Color.Red;
            }
            else
            {
                tssbErrors.Image = Resources.correct;
                tssbErrors.Text = "";
                tssbErrors.ForeColor = GlobData.UsingStyle.ControlsColorScheme.Panel.ForeColor;
            }
        }));
    }
}