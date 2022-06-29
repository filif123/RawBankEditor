
using ExControls;
using RawBankEditor.Entities;
using RawBankEditor.Tools;
using ToolsCore.Entities;

namespace RawBankEditor.Forms
{
    public partial class FMain
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmimSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmimImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimExport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmimAddSound = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimDeleteSound = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimMoveSounds = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimGoForward = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmimSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimLangsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmimAppSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimConvertSounds = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimInfoApp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new ExControls.ExTableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripGroups = new System.Windows.Forms.ToolStrip();
            this.tsbAddGroup = new System.Windows.Forms.ToolStripButton();
            this.tsbEditGroup = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteGroup = new System.Windows.Forms.ToolStripButton();
            this.lboxGroups = new System.Windows.Forms.ListBox();
            this.contextMenuGroups = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiEditGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new ExControls.ExTableLayoutPanel();
            this.dgvExplorer = new System.Windows.Forms.DataGridView();
            this.cType = new System.Windows.Forms.DataGridViewImageColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuExplorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.otvoriťVPrieskumníkoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prehraťZvukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.premenovaťSúborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstrániťSúborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripExplorer = new System.Windows.Forms.ToolStrip();
            this.tsbOpenInExplorer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRenameFileDir = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveFileDir = new System.Windows.Forms.ToolStripButton();
            this.splitSoundsErrors = new System.Windows.Forms.SplitContainer();
            this.dgvSounds = new System.Windows.Forms.DataGridView();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalRelativePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuSounds = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiAddSound = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDeleteSound = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.konvertovaťNaWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konvertovaťNaEWAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fyzSoundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new ExControls.ExTableLayoutPanel();
            this.toolStripErrors = new System.Windows.Forms.ToolStrip();
            this.tsbErrors = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbWarnings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInfos = new System.Windows.Forms.ToolStripButton();
            this.tsbSolve = new System.Windows.Forms.ToolStripButton();
            this.tsbFindProblem = new System.Windows.Forms.ToolStripButton();
            this.dgvErrors = new System.Windows.Forms.DataGridView();
            this.dgvicType = new System.Windows.Forms.DataGridViewImageColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolveMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuErrors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiFindProblem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiSolve = new System.Windows.Forms.ToolStripMenuItem();
            this.rawBankMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel5 = new ExControls.ExTableLayoutPanel();
            this.mmErrors = new RawBankEditor.Controls.MinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new ExControls.ExTableLayoutPanel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbErrors = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbRecent = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGoBack = new System.Windows.Forms.ToolStripButton();
            this.tsbGoForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tscboxLanguages = new ExControls.ExToolStripComboBox();
            this.tsbLangsSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbConvertSounds = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAppSettings = new System.Windows.Forms.ToolStripButton();
            this.tsbInfoApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddSound = new System.Windows.Forms.ToolStripButton();
            this.tsbMoveSounds = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteSound = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.bWorkerReadDat = new System.ComponentModel.BackgroundWorker();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStripGroups.SuspendLayout();
            this.contextMenuGroups.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplorer)).BeginInit();
            this.contextMenuExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemElementBindingSource)).BeginInit();
            this.toolStripExplorer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSoundsErrors)).BeginInit();
            this.splitSoundsErrors.Panel1.SuspendLayout();
            this.splitSoundsErrors.Panel2.SuspendLayout();
            this.splitSoundsErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSounds)).BeginInit();
            this.contextMenuSounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fyzSoundBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.toolStripErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).BeginInit();
            this.contextMenuErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rawBankMessageBindingSource)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiShow,
            this.tsmiTools,
            this.tsmiHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripMain.Size = new System.Drawing.Size(1001, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimOpen,
            this.tsmimRecent,
            this.toolStripSeparator2,
            this.tsmimSave,
            this.tsmimSaveAll,
            this.toolStripSeparator3,
            this.tsmimImport,
            this.tsmimExport});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(50, 20);
            this.tsmiFile.Text = "Súbor";
            // 
            // tsmimOpen
            // 
            this.tsmimOpen.Image = global::RawBankEditor.Properties.Resources.open;
            this.tsmimOpen.Name = "tsmimOpen";
            this.tsmimOpen.Size = new System.Drawing.Size(142, 22);
            this.tsmimOpen.Tag = RawBankEditor.Entities.MainMenuItemType.OpenDir;
            this.tsmimOpen.Text = "Otvoriť...";
            this.tsmimOpen.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimRecent
            // 
            this.tsmimRecent.Image = global::RawBankEditor.Properties.Resources.recent_gvds;
            this.tsmimRecent.Name = "tsmimRecent";
            this.tsmimRecent.Size = new System.Drawing.Size(142, 22);
            this.tsmimRecent.Text = "Nedávne";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmimSave
            // 
            this.tsmimSave.Enabled = false;
            this.tsmimSave.Image = global::RawBankEditor.Properties.Resources.save;
            this.tsmimSave.Name = "tsmimSave";
            this.tsmimSave.Size = new System.Drawing.Size(142, 22);
            this.tsmimSave.Tag = RawBankEditor.Entities.MainMenuItemType.Save;
            this.tsmimSave.Text = "Uložiť";
            this.tsmimSave.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimSaveAll
            // 
            this.tsmimSaveAll.Enabled = false;
            this.tsmimSaveAll.Image = global::RawBankEditor.Properties.Resources.save_all;
            this.tsmimSaveAll.Name = "tsmimSaveAll";
            this.tsmimSaveAll.Size = new System.Drawing.Size(142, 22);
            this.tsmimSaveAll.Tag = RawBankEditor.Entities.MainMenuItemType.SaveAll;
            this.tsmimSaveAll.Text = "Uložiť všetko";
            this.tsmimSaveAll.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmimImport
            // 
            this.tsmimImport.Enabled = false;
            this.tsmimImport.Image = global::RawBankEditor.Properties.Resources.import;
            this.tsmimImport.Name = "tsmimImport";
            this.tsmimImport.Size = new System.Drawing.Size(142, 22);
            this.tsmimImport.Tag = RawBankEditor.Entities.MainMenuItemType.Import;
            this.tsmimImport.Text = "Importovať";
            this.tsmimImport.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimExport
            // 
            this.tsmimExport.Enabled = false;
            this.tsmimExport.Image = global::RawBankEditor.Properties.Resources.export;
            this.tsmimExport.Name = "tsmimExport";
            this.tsmimExport.Size = new System.Drawing.Size(142, 22);
            this.tsmimExport.Tag = RawBankEditor.Entities.MainMenuItemType.Export;
            this.tsmimExport.Text = "Exportovať";
            this.tsmimExport.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimUndo,
            this.tsmimRedo,
            this.toolStripSeparator11,
            this.tsmimAddSound,
            this.tsmimDeleteSound,
            this.tsmimMoveSounds});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(58, 20);
            this.tsmiEdit.Text = "Upraviť";
            // 
            // tsmimUndo
            // 
            this.tsmimUndo.Enabled = false;
            this.tsmimUndo.Image = global::RawBankEditor.Properties.Resources.undo;
            this.tsmimUndo.Name = "tsmimUndo";
            this.tsmimUndo.Size = new System.Drawing.Size(177, 22);
            this.tsmimUndo.Tag = RawBankEditor.Entities.MainMenuItemType.Undo;
            this.tsmimUndo.Text = "Späť";
            this.tsmimUndo.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimRedo
            // 
            this.tsmimRedo.Enabled = false;
            this.tsmimRedo.Image = global::RawBankEditor.Properties.Resources.redo;
            this.tsmimRedo.Name = "tsmimRedo";
            this.tsmimRedo.Size = new System.Drawing.Size(177, 22);
            this.tsmimRedo.Tag = RawBankEditor.Entities.MainMenuItemType.Redo;
            this.tsmimRedo.Text = "Znovu";
            this.tsmimRedo.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(174, 6);
            // 
            // tsmimAddSound
            // 
            this.tsmimAddSound.Enabled = false;
            this.tsmimAddSound.Image = global::RawBankEditor.Properties.Resources.add;
            this.tsmimAddSound.Name = "tsmimAddSound";
            this.tsmimAddSound.Size = new System.Drawing.Size(177, 22);
            this.tsmimAddSound.Tag = RawBankEditor.Entities.MainMenuItemType.AddSound;
            this.tsmimAddSound.Text = "Pridať zvuk...";
            this.tsmimAddSound.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimDeleteSound
            // 
            this.tsmimDeleteSound.Enabled = false;
            this.tsmimDeleteSound.Image = global::RawBankEditor.Properties.Resources.delete;
            this.tsmimDeleteSound.Name = "tsmimDeleteSound";
            this.tsmimDeleteSound.Size = new System.Drawing.Size(177, 22);
            this.tsmimDeleteSound.Tag = RawBankEditor.Entities.MainMenuItemType.DeleteSounds;
            this.tsmimDeleteSound.Text = "Odstrániť zvuky";
            this.tsmimDeleteSound.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimMoveSounds
            // 
            this.tsmimMoveSounds.Enabled = false;
            this.tsmimMoveSounds.Image = global::RawBankEditor.Properties.Resources.move;
            this.tsmimMoveSounds.Name = "tsmimMoveSounds";
            this.tsmimMoveSounds.Size = new System.Drawing.Size(177, 22);
            this.tsmimMoveSounds.Tag = RawBankEditor.Entities.MainMenuItemType.MoveSounds;
            this.tsmimMoveSounds.Text = "Premiestniť zvuky...";
            this.tsmimMoveSounds.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmiShow
            // 
            this.tsmiShow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimGoBack,
            this.tsmimGoForward,
            this.toolStripSeparator18,
            this.tsmimSearch});
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(63, 20);
            this.tsmiShow.Text = "Zobraziť";
            // 
            // tsmimGoBack
            // 
            this.tsmimGoBack.Enabled = false;
            this.tsmimGoBack.Image = global::RawBankEditor.Properties.Resources.back;
            this.tsmimGoBack.Name = "tsmimGoBack";
            this.tsmimGoBack.Size = new System.Drawing.Size(152, 22);
            this.tsmimGoBack.Tag = RawBankEditor.Entities.MainMenuItemType.GoBack;
            this.tsmimGoBack.Text = "Prejsť späť";
            this.tsmimGoBack.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimGoForward
            // 
            this.tsmimGoForward.Enabled = false;
            this.tsmimGoForward.Image = global::RawBankEditor.Properties.Resources.forward;
            this.tsmimGoForward.Name = "tsmimGoForward";
            this.tsmimGoForward.Size = new System.Drawing.Size(152, 22);
            this.tsmimGoForward.Tag = RawBankEditor.Entities.MainMenuItemType.GoForward;
            this.tsmimGoForward.Text = "Prejsť dopredu";
            this.tsmimGoForward.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmimSearch
            // 
            this.tsmimSearch.Enabled = false;
            this.tsmimSearch.Image = global::RawBankEditor.Properties.Resources.search;
            this.tsmimSearch.Name = "tsmimSearch";
            this.tsmimSearch.Size = new System.Drawing.Size(152, 22);
            this.tsmimSearch.Tag = RawBankEditor.Entities.MainMenuItemType.Search;
            this.tsmimSearch.Text = "Hľadať";
            this.tsmimSearch.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimLangsSettings,
            this.toolStripSeparator8,
            this.tsmimAppSettings,
            this.tsmimConvertSounds});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(63, 20);
            this.tsmiTools.Text = "Nástroje";
            // 
            // tsmimLangsSettings
            // 
            this.tsmimLangsSettings.Enabled = false;
            this.tsmimLangsSettings.Image = global::RawBankEditor.Properties.Resources.global_settings;
            this.tsmimLangsSettings.Name = "tsmimLangsSettings";
            this.tsmimLangsSettings.Size = new System.Drawing.Size(190, 22);
            this.tsmimLangsSettings.Tag = RawBankEditor.Entities.MainMenuItemType.LangSettings;
            this.tsmimLangsSettings.Text = "Nastavenia jazykov";
            this.tsmimLangsSettings.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmimAppSettings
            // 
            this.tsmimAppSettings.Image = global::RawBankEditor.Properties.Resources.app_settings;
            this.tsmimAppSettings.Name = "tsmimAppSettings";
            this.tsmimAppSettings.Size = new System.Drawing.Size(190, 22);
            this.tsmimAppSettings.Tag = RawBankEditor.Entities.MainMenuItemType.AppSettings;
            this.tsmimAppSettings.Text = "Nastavenia programu";
            this.tsmimAppSettings.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimConvertSounds
            // 
            this.tsmimConvertSounds.Enabled = false;
            this.tsmimConvertSounds.Image = global::RawBankEditor.Properties.Resources.convert;
            this.tsmimConvertSounds.Name = "tsmimConvertSounds";
            this.tsmimConvertSounds.Size = new System.Drawing.Size(190, 22);
            this.tsmimConvertSounds.Tag = RawBankEditor.Entities.MainMenuItemType.ConvertSounds;
            this.tsmimConvertSounds.Text = "Konvertovanie zvukov";
            this.tsmimConvertSounds.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmimInfoApp,
            this.tsmimUpdates});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(73, 20);
            this.tsmiHelp.Text = "Pomocník";
            // 
            // tsmimInfoApp
            // 
            this.tsmimInfoApp.Image = global::RawBankEditor.Properties.Resources.info_app;
            this.tsmimInfoApp.Name = "tsmimInfoApp";
            this.tsmimInfoApp.Size = new System.Drawing.Size(222, 22);
            this.tsmimInfoApp.Tag = RawBankEditor.Entities.MainMenuItemType.InfoApp;
            this.tsmimInfoApp.Text = "Informácie o programe";
            this.tsmimInfoApp.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsmimUpdates
            // 
            this.tsmimUpdates.Name = "tsmimUpdates";
            this.tsmimUpdates.Size = new System.Drawing.Size(222, 22);
            this.tsmimUpdates.Tag = RawBankEditor.Entities.MainMenuItemType.UpdateNotes;
            this.tsmimUpdates.Text = "Poznámky k aktualizáciám...";
            this.tsmimUpdates.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 2);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitSoundsErrors);
            this.splitContainer1.Size = new System.Drawing.Size(997, 476);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Size = new System.Drawing.Size(271, 476);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BorderColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.toolStripGroups, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lboxGroups, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 180);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label1.Size = new System.Drawing.Size(265, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skupiny zvukov";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripGroups
            // 
            this.toolStripGroups.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripGroups.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGroups.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddGroup,
            this.tsbEditGroup,
            this.tsbDeleteGroup});
            this.toolStripGroups.Location = new System.Drawing.Point(3, 27);
            this.toolStripGroups.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.toolStripGroups.Name = "toolStripGroups";
            this.toolStripGroups.Size = new System.Drawing.Size(265, 27);
            this.toolStripGroups.TabIndex = 1;
            this.toolStripGroups.Text = "toolStrip2";
            // 
            // tsbAddGroup
            // 
            this.tsbAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddGroup.Enabled = false;
            this.tsbAddGroup.Image = global::RawBankEditor.Properties.Resources.add;
            this.tsbAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddGroup.Name = "tsbAddGroup";
            this.tsbAddGroup.Size = new System.Drawing.Size(24, 24);
            this.tsbAddGroup.Text = "Pridať skupinu";
            this.tsbAddGroup.Click += new System.EventHandler(this.DoAddGroup);
            // 
            // tsbEditGroup
            // 
            this.tsbEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditGroup.Enabled = false;
            this.tsbEditGroup.Image = global::RawBankEditor.Properties.Resources.edit;
            this.tsbEditGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditGroup.Name = "tsbEditGroup";
            this.tsbEditGroup.Size = new System.Drawing.Size(24, 24);
            this.tsbEditGroup.Text = "Upraviť skupinu";
            this.tsbEditGroup.Click += new System.EventHandler(this.DoEditGroup);
            // 
            // tsbDeleteGroup
            // 
            this.tsbDeleteGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteGroup.Enabled = false;
            this.tsbDeleteGroup.Image = global::RawBankEditor.Properties.Resources.delete;
            this.tsbDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteGroup.Name = "tsbDeleteGroup";
            this.tsbDeleteGroup.Size = new System.Drawing.Size(24, 24);
            this.tsbDeleteGroup.Text = "Odstrániť skupinu";
            this.tsbDeleteGroup.Click += new System.EventHandler(this.DoDeleteGroup);
            // 
            // lboxGroups
            // 
            this.lboxGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lboxGroups.ContextMenuStrip = this.contextMenuGroups;
            this.lboxGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxGroups.FormattingEnabled = true;
            this.lboxGroups.Location = new System.Drawing.Point(3, 57);
            this.lboxGroups.Margin = new System.Windows.Forms.Padding(2);
            this.lboxGroups.Name = "lboxGroups";
            this.lboxGroups.Size = new System.Drawing.Size(265, 120);
            this.lboxGroups.TabIndex = 2;
            this.lboxGroups.SelectedIndexChanged += new System.EventHandler(this.lboxGroups_SelectedIndexChanged);
            this.lboxGroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lboxGroups_KeyDown);
            // 
            // contextMenuGroups
            // 
            this.contextMenuGroups.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAddGroup,
            this.cmiEditGroup,
            this.cmiDeleteGroup});
            this.contextMenuGroups.Name = "contextMenuGroups";
            this.contextMenuGroups.Size = new System.Drawing.Size(174, 82);
            // 
            // cmiAddGroup
            // 
            this.cmiAddGroup.Enabled = false;
            this.cmiAddGroup.Image = global::RawBankEditor.Properties.Resources.add;
            this.cmiAddGroup.Name = "cmiAddGroup";
            this.cmiAddGroup.Size = new System.Drawing.Size(173, 26);
            this.cmiAddGroup.Text = "Pridať skupinu...";
            this.cmiAddGroup.Click += new System.EventHandler(this.DoAddGroup);
            // 
            // cmiEditGroup
            // 
            this.cmiEditGroup.Enabled = false;
            this.cmiEditGroup.Image = global::RawBankEditor.Properties.Resources.edit;
            this.cmiEditGroup.Name = "cmiEditGroup";
            this.cmiEditGroup.Size = new System.Drawing.Size(173, 26);
            this.cmiEditGroup.Text = "Upraviť skupinu...";
            this.cmiEditGroup.Click += new System.EventHandler(this.DoEditGroup);
            // 
            // cmiDeleteGroup
            // 
            this.cmiDeleteGroup.Enabled = false;
            this.cmiDeleteGroup.Image = global::RawBankEditor.Properties.Resources.delete;
            this.cmiDeleteGroup.Name = "cmiDeleteGroup";
            this.cmiDeleteGroup.Size = new System.Drawing.Size(173, 26);
            this.cmiDeleteGroup.Text = "Odstrániť skupinu";
            this.cmiDeleteGroup.Click += new System.EventHandler(this.DoDeleteGroup);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BorderColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvExplorer, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.toolStripExplorer, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(271, 290);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dgvExplorer
            // 
            this.dgvExplorer.AllowUserToAddRows = false;
            this.dgvExplorer.AllowUserToDeleteRows = false;
            this.dgvExplorer.AllowUserToResizeRows = false;
            this.dgvExplorer.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExplorer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExplorer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplorer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cType,
            this.cName,
            this.cDuration});
            this.dgvExplorer.ContextMenuStrip = this.contextMenuExplorer;
            this.dgvExplorer.DataSource = this.fileSystemElementBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExplorer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExplorer.Location = new System.Drawing.Point(3, 59);
            this.dgvExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExplorer.MultiSelect = false;
            this.dgvExplorer.Name = "dgvExplorer";
            this.dgvExplorer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExplorer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExplorer.RowHeadersVisible = false;
            this.dgvExplorer.RowHeadersWidth = 51;
            this.dgvExplorer.RowTemplate.Height = 24;
            this.dgvExplorer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExplorer.Size = new System.Drawing.Size(265, 228);
            this.dgvExplorer.TabIndex = 3;
            this.dgvExplorer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExplorer_CellClick);
            this.dgvExplorer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExplorer_CellDoubleClick);
            this.dgvExplorer.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvExplorer_CellFormatting);
            this.dgvExplorer.SelectionChanged += new System.EventHandler(this.dgvExplorer_SelectionChanged);
            // 
            // cType
            // 
            this.cType.HeaderText = "Typ";
            this.cType.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.cType.MinimumWidth = 50;
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            this.cType.Width = 50;
            // 
            // cName
            // 
            this.cName.DataPropertyName = "Name";
            this.cName.HeaderText = "Názov";
            this.cName.MinimumWidth = 175;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.Width = 175;
            // 
            // cDuration
            // 
            this.cDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cDuration.HeaderText = "Dĺžka";
            this.cDuration.MinimumWidth = 6;
            this.cDuration.Name = "cDuration";
            this.cDuration.ReadOnly = true;
            // 
            // contextMenuExplorer
            // 
            this.contextMenuExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriťVPrieskumníkoviToolStripMenuItem,
            this.prehraťZvukToolStripMenuItem,
            this.toolStripSeparator20,
            this.premenovaťSúborToolStripMenuItem,
            this.odstrániťSúborToolStripMenuItem});
            this.contextMenuExplorer.Name = "contextMenuExplorer";
            this.contextMenuExplorer.Size = new System.Drawing.Size(206, 98);
            // 
            // otvoriťVPrieskumníkoviToolStripMenuItem
            // 
            this.otvoriťVPrieskumníkoviToolStripMenuItem.Enabled = false;
            this.otvoriťVPrieskumníkoviToolStripMenuItem.Image = global::RawBankEditor.Properties.Resources.folder;
            this.otvoriťVPrieskumníkoviToolStripMenuItem.Name = "otvoriťVPrieskumníkoviToolStripMenuItem";
            this.otvoriťVPrieskumníkoviToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.otvoriťVPrieskumníkoviToolStripMenuItem.Text = "Otvoriť v prieskumníkovi";
            this.otvoriťVPrieskumníkoviToolStripMenuItem.Click += new System.EventHandler(this.DoOpenFileInExplorer);
            // 
            // prehraťZvukToolStripMenuItem
            // 
            this.prehraťZvukToolStripMenuItem.Enabled = false;
            this.prehraťZvukToolStripMenuItem.Image = global::RawBankEditor.Properties.Resources.sound;
            this.prehraťZvukToolStripMenuItem.Name = "prehraťZvukToolStripMenuItem";
            this.prehraťZvukToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.prehraťZvukToolStripMenuItem.Text = "Prehrať zvuk";
            this.prehraťZvukToolStripMenuItem.Click += new System.EventHandler(this.DoPlayFile);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(202, 6);
            // 
            // premenovaťSúborToolStripMenuItem
            // 
            this.premenovaťSúborToolStripMenuItem.Enabled = false;
            this.premenovaťSúborToolStripMenuItem.Image = global::RawBankEditor.Properties.Resources.rename;
            this.premenovaťSúborToolStripMenuItem.Name = "premenovaťSúborToolStripMenuItem";
            this.premenovaťSúborToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.premenovaťSúborToolStripMenuItem.Text = "Premenovať súbor";
            this.premenovaťSúborToolStripMenuItem.Click += new System.EventHandler(this.DoRenameFile);
            // 
            // odstrániťSúborToolStripMenuItem
            // 
            this.odstrániťSúborToolStripMenuItem.Enabled = false;
            this.odstrániťSúborToolStripMenuItem.Image = global::RawBankEditor.Properties.Resources.delete;
            this.odstrániťSúborToolStripMenuItem.Name = "odstrániťSúborToolStripMenuItem";
            this.odstrániťSúborToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.odstrániťSúborToolStripMenuItem.Text = "Odstrániť súbor";
            this.odstrániťSúborToolStripMenuItem.Click += new System.EventHandler(this.DoDeleteFile);
            // 
            // fileSystemElementBindingSource
            // 
            this.fileSystemElementBindingSource.DataSource = typeof(ToolsCore.Entities.FileSystemElement);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label2.Size = new System.Drawing.Size(265, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prieskumník súborov";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripExplorer
            // 
            this.toolStripExplorer.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripExplorer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripExplorer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripExplorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenInExplorer,
            this.toolStripSeparator16,
            this.tsbPlay,
            this.toolStripSeparator17,
            this.tsbRenameFileDir,
            this.tsbRemoveFileDir});
            this.toolStripExplorer.Location = new System.Drawing.Point(3, 27);
            this.toolStripExplorer.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripExplorer.Name = "toolStripExplorer";
            this.toolStripExplorer.Size = new System.Drawing.Size(265, 27);
            this.toolStripExplorer.TabIndex = 2;
            this.toolStripExplorer.Text = "toolStrip2";
            this.toolStripExplorer.Click += new System.EventHandler(this.DoRenameFile);
            // 
            // tsbOpenInExplorer
            // 
            this.tsbOpenInExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenInExplorer.Enabled = false;
            this.tsbOpenInExplorer.Image = global::RawBankEditor.Properties.Resources.folder;
            this.tsbOpenInExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenInExplorer.Name = "tsbOpenInExplorer";
            this.tsbOpenInExplorer.Size = new System.Drawing.Size(24, 24);
            this.tsbOpenInExplorer.Text = "Otvoriť v prieskumníkovi";
            this.tsbOpenInExplorer.Click += new System.EventHandler(this.DoOpenFileInExplorer);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Enabled = false;
            this.tsbPlay.Image = global::RawBankEditor.Properties.Resources.sound;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(24, 24);
            this.tsbPlay.Text = "Prehrať zvuk";
            this.tsbPlay.Click += new System.EventHandler(this.DoPlayFile);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbRenameFileDir
            // 
            this.tsbRenameFileDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenameFileDir.Enabled = false;
            this.tsbRenameFileDir.Image = global::RawBankEditor.Properties.Resources.rename;
            this.tsbRenameFileDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenameFileDir.Name = "tsbRenameFileDir";
            this.tsbRenameFileDir.Size = new System.Drawing.Size(24, 24);
            this.tsbRenameFileDir.Text = "Premenovať";
            // 
            // tsbRemoveFileDir
            // 
            this.tsbRemoveFileDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveFileDir.Enabled = false;
            this.tsbRemoveFileDir.Image = global::RawBankEditor.Properties.Resources.delete;
            this.tsbRemoveFileDir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveFileDir.Name = "tsbRemoveFileDir";
            this.tsbRemoveFileDir.Size = new System.Drawing.Size(24, 24);
            this.tsbRemoveFileDir.Text = "Odstrániť";
            this.tsbRemoveFileDir.Click += new System.EventHandler(this.DoDeleteFile);
            // 
            // splitSoundsErrors
            // 
            this.splitSoundsErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSoundsErrors.Location = new System.Drawing.Point(0, 0);
            this.splitSoundsErrors.Margin = new System.Windows.Forms.Padding(2);
            this.splitSoundsErrors.Name = "splitSoundsErrors";
            this.splitSoundsErrors.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSoundsErrors.Panel1
            // 
            this.splitSoundsErrors.Panel1.Controls.Add(this.dgvSounds);
            // 
            // splitSoundsErrors.Panel2
            // 
            this.splitSoundsErrors.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitSoundsErrors.Size = new System.Drawing.Size(720, 476);
            this.splitSoundsErrors.SplitterDistance = 324;
            this.splitSoundsErrors.SplitterWidth = 6;
            this.splitSoundsErrors.TabIndex = 1;
            // 
            // dgvSounds
            // 
            this.dgvSounds.AllowUserToAddRows = false;
            this.dgvSounds.AllowUserToOrderColumns = true;
            this.dgvSounds.AllowUserToResizeRows = false;
            this.dgvSounds.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSounds.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSounds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSounds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.AdditionalRelativePath,
            this.file,
            this.duration,
            this.text});
            this.dgvSounds.ContextMenuStrip = this.contextMenuSounds;
            this.dgvSounds.DataSource = this.fyzSoundBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSounds.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSounds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSounds.Location = new System.Drawing.Point(0, 0);
            this.dgvSounds.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSounds.Name = "dgvSounds";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSounds.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSounds.RowHeadersWidth = 51;
            this.dgvSounds.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSounds.RowTemplate.Height = 24;
            this.dgvSounds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSounds.Size = new System.Drawing.Size(720, 324);
            this.dgvSounds.TabIndex = 0;
            this.dgvSounds.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSounds_CellBeginEdit);
            this.dgvSounds.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSounds_CellEndEdit);
            this.dgvSounds.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSounds_CellFormatting);
            this.dgvSounds.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSounds_DataError);
            this.dgvSounds.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSounds_RowsAdded);
            this.dgvSounds.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvSounds_RowValidating);
            this.dgvSounds.SelectionChanged += new System.EventHandler(this.dgvSounds_SelectionChanged);
            this.dgvSounds.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvSounds_UserAddedRow);
            // 
            // key
            // 
            this.key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.key.DataPropertyName = "Key";
            this.key.HeaderText = "Kľúč zvuku";
            this.key.MinimumWidth = 6;
            this.key.Name = "key";
            this.key.Width = 80;
            // 
            // AdditionalRelativePath
            // 
            this.AdditionalRelativePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AdditionalRelativePath.DataPropertyName = "AdditionalRelativePath";
            this.AdditionalRelativePath.HeaderText = "Prídavná relatívna cesta";
            this.AdditionalRelativePath.MinimumWidth = 6;
            this.AdditionalRelativePath.Name = "AdditionalRelativePath";
            this.AdditionalRelativePath.Width = 95;
            // 
            // file
            // 
            this.file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.file.DataPropertyName = "FileName";
            this.file.HeaderText = "Názov súboru";
            this.file.MinimumWidth = 6;
            this.file.Name = "file";
            this.file.Width = 90;
            // 
            // duration
            // 
            this.duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duration.DataPropertyName = "DurationText";
            this.duration.HeaderText = "Trvanie";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.Width = 68;
            // 
            // text
            // 
            this.text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.text.DataPropertyName = "Text";
            this.text.HeaderText = "Text hlásenia";
            this.text.MinimumWidth = 6;
            this.text.Name = "text";
            // 
            // contextMenuSounds
            // 
            this.contextMenuSounds.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuSounds.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiAddSound,
            this.cmiDeleteSound,
            this.toolStripSeparator19,
            this.konvertovaťNaWAVToolStripMenuItem,
            this.konvertovaťNaEWAToolStripMenuItem});
            this.contextMenuSounds.Name = "contextMenuSounds";
            this.contextMenuSounds.Size = new System.Drawing.Size(207, 114);
            // 
            // cmiAddSound
            // 
            this.cmiAddSound.Enabled = false;
            this.cmiAddSound.Image = global::RawBankEditor.Properties.Resources.add;
            this.cmiAddSound.Name = "cmiAddSound";
            this.cmiAddSound.Size = new System.Drawing.Size(206, 26);
            this.cmiAddSound.Text = "Pridať zvuk";
            // 
            // cmiDeleteSound
            // 
            this.cmiDeleteSound.Enabled = false;
            this.cmiDeleteSound.Image = global::RawBankEditor.Properties.Resources.delete;
            this.cmiDeleteSound.Name = "cmiDeleteSound";
            this.cmiDeleteSound.Size = new System.Drawing.Size(206, 26);
            this.cmiDeleteSound.Text = "Odstrániť vybrané zvuky";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(203, 6);
            // 
            // konvertovaťNaWAVToolStripMenuItem
            // 
            this.konvertovaťNaWAVToolStripMenuItem.Enabled = false;
            this.konvertovaťNaWAVToolStripMenuItem.Image = global::RawBankEditor.Properties.Resources.convert;
            this.konvertovaťNaWAVToolStripMenuItem.Name = "konvertovaťNaWAVToolStripMenuItem";
            this.konvertovaťNaWAVToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.konvertovaťNaWAVToolStripMenuItem.Text = "Konvertovať na .WAV";
            // 
            // konvertovaťNaEWAToolStripMenuItem
            // 
            this.konvertovaťNaEWAToolStripMenuItem.Enabled = false;
            this.konvertovaťNaEWAToolStripMenuItem.Image = global::RawBankEditor.Properties.Resources.convert;
            this.konvertovaťNaEWAToolStripMenuItem.Name = "konvertovaťNaEWAToolStripMenuItem";
            this.konvertovaťNaEWAToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.konvertovaťNaEWAToolStripMenuItem.Text = "Konvertovať na .EWA";
            // 
            // fyzSoundBindingSource
            // 
            this.fyzSoundBindingSource.DataSource = typeof(ToolsCore.Entities.FyzSound);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BorderColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.toolStripErrors, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.dgvErrors, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(720, 146);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // toolStripErrors
            // 
            this.toolStripErrors.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripErrors.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripErrors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripErrors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbErrors,
            this.toolStripSeparator13,
            this.tsbWarnings,
            this.toolStripSeparator14,
            this.tsbInfos,
            this.tsbSolve,
            this.tsbFindProblem});
            this.toolStripErrors.Location = new System.Drawing.Point(3, 33);
            this.toolStripErrors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.toolStripErrors.Name = "toolStripErrors";
            this.toolStripErrors.Size = new System.Drawing.Size(714, 27);
            this.toolStripErrors.TabIndex = 1;
            this.toolStripErrors.Text = "toolStrip2";
            // 
            // tsbErrors
            // 
            this.tsbErrors.Checked = true;
            this.tsbErrors.CheckOnClick = true;
            this.tsbErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbErrors.Image = ((System.Drawing.Image)(resources.GetObject("tsbErrors.Image")));
            this.tsbErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbErrors.Name = "tsbErrors";
            this.tsbErrors.Size = new System.Drawing.Size(66, 24);
            this.tsbErrors.Text = "0 chýb";
            this.tsbErrors.CheckedChanged += new System.EventHandler(this.tsbErrors_CheckedChanged);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbWarnings
            // 
            this.tsbWarnings.Checked = true;
            this.tsbWarnings.CheckOnClick = true;
            this.tsbWarnings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbWarnings.Image = ((System.Drawing.Image)(resources.GetObject("tsbWarnings.Image")));
            this.tsbWarnings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWarnings.Name = "tsbWarnings";
            this.tsbWarnings.Size = new System.Drawing.Size(100, 24);
            this.tsbWarnings.Text = "0 upozornení";
            this.tsbWarnings.CheckedChanged += new System.EventHandler(this.tsbWarnings_CheckedChanged);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbInfos
            // 
            this.tsbInfos.Checked = true;
            this.tsbInfos.CheckOnClick = true;
            this.tsbInfos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbInfos.Image = ((System.Drawing.Image)(resources.GetObject("tsbInfos.Image")));
            this.tsbInfos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfos.Name = "tsbInfos";
            this.tsbInfos.Size = new System.Drawing.Size(68, 24);
            this.tsbInfos.Text = "0 správ";
            this.tsbInfos.CheckedChanged += new System.EventHandler(this.tsbInfos_CheckedChanged);
            // 
            // tsbSolve
            // 
            this.tsbSolve.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSolve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSolve.Enabled = false;
            this.tsbSolve.Image = global::RawBankEditor.Properties.Resources.correct;
            this.tsbSolve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSolve.Name = "tsbSolve";
            this.tsbSolve.Size = new System.Drawing.Size(24, 24);
            this.tsbSolve.Text = "Vyriešiť";
            this.tsbSolve.Click += new System.EventHandler(this.DoSolveProblem);
            // 
            // tsbFindProblem
            // 
            this.tsbFindProblem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbFindProblem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindProblem.Enabled = false;
            this.tsbFindProblem.Image = global::RawBankEditor.Properties.Resources.analyze;
            this.tsbFindProblem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFindProblem.Name = "tsbFindProblem";
            this.tsbFindProblem.Size = new System.Drawing.Size(24, 24);
            this.tsbFindProblem.Text = "Nájsť problém";
            this.tsbFindProblem.Click += new System.EventHandler(this.DoFindProblem);
            // 
            // dgvErrors
            // 
            this.dgvErrors.AllowUserToAddRows = false;
            this.dgvErrors.AllowUserToDeleteRows = false;
            this.dgvErrors.AllowUserToResizeRows = false;
            this.dgvErrors.AutoGenerateColumns = false;
            this.dgvErrors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvicType,
            this.messageDataGridViewTextBoxColumn,
            this.resolveMessageDataGridViewTextBoxColumn});
            this.dgvErrors.ContextMenuStrip = this.contextMenuErrors;
            this.dgvErrors.DataSource = this.rawBankMessageBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErrors.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvErrors.Location = new System.Drawing.Point(3, 63);
            this.dgvErrors.Margin = new System.Windows.Forms.Padding(2);
            this.dgvErrors.MultiSelect = false;
            this.dgvErrors.Name = "dgvErrors";
            this.dgvErrors.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvErrors.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvErrors.RowHeadersVisible = false;
            this.dgvErrors.RowHeadersWidth = 51;
            this.dgvErrors.RowTemplate.Height = 24;
            this.dgvErrors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvErrors.Size = new System.Drawing.Size(714, 80);
            this.dgvErrors.TabIndex = 2;
            this.dgvErrors.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvErrors_CellFormatting);
            // 
            // dgvicType
            // 
            this.dgvicType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvicType.HeaderText = "Typ";
            this.dgvicType.MinimumWidth = 6;
            this.dgvicType.Name = "dgvicType";
            this.dgvicType.ReadOnly = true;
            this.dgvicType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvicType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvicType.Width = 50;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "Message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "Správa";
            this.messageDataGridViewTextBoxColumn.MinimumWidth = 500;
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.ReadOnly = true;
            this.messageDataGridViewTextBoxColumn.Width = 500;
            // 
            // resolveMessageDataGridViewTextBoxColumn
            // 
            this.resolveMessageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.resolveMessageDataGridViewTextBoxColumn.DataPropertyName = "ResolveMessage";
            this.resolveMessageDataGridViewTextBoxColumn.HeaderText = "Riešenie";
            this.resolveMessageDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.resolveMessageDataGridViewTextBoxColumn.Name = "resolveMessageDataGridViewTextBoxColumn";
            this.resolveMessageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuErrors
            // 
            this.contextMenuErrors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiFindProblem,
            this.cmiSolve});
            this.contextMenuErrors.Name = "contextMenuErrors";
            this.contextMenuErrors.Size = new System.Drawing.Size(139, 48);
            // 
            // cmiFindProblem
            // 
            this.cmiFindProblem.Enabled = false;
            this.cmiFindProblem.Image = global::RawBankEditor.Properties.Resources.analyze;
            this.cmiFindProblem.Name = "cmiFindProblem";
            this.cmiFindProblem.Size = new System.Drawing.Size(138, 22);
            this.cmiFindProblem.Text = "Nájsť chybu";
            this.cmiFindProblem.Click += new System.EventHandler(this.DoFindProblem);
            // 
            // cmiSolve
            // 
            this.cmiSolve.Enabled = false;
            this.cmiSolve.Image = global::RawBankEditor.Properties.Resources.correct;
            this.cmiSolve.Name = "cmiSolve";
            this.cmiSolve.Size = new System.Drawing.Size(138, 22);
            this.cmiSolve.Text = "Vyriešiť";
            this.cmiSolve.Click += new System.EventHandler(this.DoSolveProblem);
            // 
            // rawBankMessageBindingSource
            // 
            this.rawBankMessageBindingSource.DataSource = typeof(RawBankEditor.Entities.RawBankMessage);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BorderColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.mmErrors, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(714, 25);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // mmErrors
            // 
            this.mmErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mmErrors.HoverColor = System.Drawing.SystemColors.Highlight;
            this.mmErrors.IconColor = System.Drawing.SystemColors.ControlDark;
            this.mmErrors.IconHoverColor = System.Drawing.Color.White;
            this.mmErrors.Location = new System.Drawing.Point(700, 2);
            this.mmErrors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mmErrors.Name = "mmErrors";
            this.mmErrors.Size = new System.Drawing.Size(12, 13);
            this.mmErrors.TabIndex = 1;
            this.mmErrors.ToolTipText = "Zavrieť";
            this.mmErrors.Click += new System.EventHandler(this.mmErrors_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label3.Size = new System.Drawing.Size(353, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Zoznam chýb";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BorderColor = System.Drawing.Color.Empty;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStripMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 506);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tspbProgress,
            this.toolStripStatusLabel1,
            this.tssbErrors});
            this.statusStripMain.Location = new System.Drawing.Point(0, 480);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStripMain.Size = new System.Drawing.Size(1001, 26);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(141, 21);
            this.tsslStatus.Text = "Neotvorená žiadna banka";
            // 
            // tspbProgress
            // 
            this.tspbProgress.Margin = new System.Windows.Forms.Padding(5, 4, 1, 4);
            this.tspbProgress.Name = "tspbProgress";
            this.tspbProgress.Size = new System.Drawing.Size(75, 18);
            this.tspbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tspbProgress.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(825, 21);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // tssbErrors
            // 
            this.tssbErrors.Image = global::RawBankEditor.Properties.Resources.correct;
            this.tssbErrors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbErrors.Name = "tssbErrors";
            this.tssbErrors.ShowDropDownArrow = false;
            this.tssbErrors.Size = new System.Drawing.Size(24, 24);
            this.tssbErrors.Click += new System.EventHandler(this.tssbErrors_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.tsbRecent,
            this.tsbSave,
            this.tsbSaveAll,
            this.toolStripSeparator1,
            this.tsbImport,
            this.tsbExport,
            this.toolStripSeparator5,
            this.tsbGoBack,
            this.tsbGoForward,
            this.toolStripSeparator9,
            this.tsbUndo,
            this.tsbRedo,
            this.toolStripSeparator10,
            this.toolStripLabel1,
            this.tscboxLanguages,
            this.tsbLangsSettings,
            this.toolStripSeparator6,
            this.tsbConvertSounds,
            this.toolStripSeparator7,
            this.tsbAppSettings,
            this.tsbInfoApp,
            this.toolStripSeparator12,
            this.tsbAddSound,
            this.tsbMoveSounds,
            this.tsbDeleteSound,
            this.toolStripSeparator15,
            this.tsbSearch});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1001, 27);
            this.toolStripMain.TabIndex = 3;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::RawBankEditor.Properties.Resources.open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(24, 24);
            this.tsbOpen.Tag = RawBankEditor.Entities.MainMenuItemType.OpenDir;
            this.tsbOpen.Text = "Otvoriť";
            this.tsbOpen.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbRecent
            // 
            this.tsbRecent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecent.Image = global::RawBankEditor.Properties.Resources.recent_gvds;
            this.tsbRecent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecent.Name = "tsbRecent";
            this.tsbRecent.Size = new System.Drawing.Size(33, 24);
            this.tsbRecent.Text = "Nedávne";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = global::RawBankEditor.Properties.Resources.save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(24, 24);
            this.tsbSave.Tag = RawBankEditor.Entities.MainMenuItemType.Save;
            this.tsbSave.Text = "Uložiť";
            this.tsbSave.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbSaveAll
            // 
            this.tsbSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveAll.Enabled = false;
            this.tsbSaveAll.Image = global::RawBankEditor.Properties.Resources.save_all;
            this.tsbSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAll.Name = "tsbSaveAll";
            this.tsbSaveAll.Size = new System.Drawing.Size(24, 24);
            this.tsbSaveAll.Tag = RawBankEditor.Entities.MainMenuItemType.SaveAll;
            this.tsbSaveAll.Text = "Uložiť všetko";
            this.tsbSaveAll.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbImport
            // 
            this.tsbImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImport.Enabled = false;
            this.tsbImport.Image = global::RawBankEditor.Properties.Resources.import;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(24, 24);
            this.tsbImport.Tag = RawBankEditor.Entities.MainMenuItemType.Import;
            this.tsbImport.Text = "Importovať";
            this.tsbImport.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbExport
            // 
            this.tsbExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExport.Enabled = false;
            this.tsbExport.Image = global::RawBankEditor.Properties.Resources.export;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(24, 24);
            this.tsbExport.Tag = RawBankEditor.Entities.MainMenuItemType.Export;
            this.tsbExport.Text = "Expotovať";
            this.tsbExport.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbGoBack
            // 
            this.tsbGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoBack.Enabled = false;
            this.tsbGoBack.Image = global::RawBankEditor.Properties.Resources.back;
            this.tsbGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoBack.Name = "tsbGoBack";
            this.tsbGoBack.Size = new System.Drawing.Size(24, 24);
            this.tsbGoBack.Tag = RawBankEditor.Entities.MainMenuItemType.GoBack;
            this.tsbGoBack.Text = "Prejsť späť";
            this.tsbGoBack.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbGoForward
            // 
            this.tsbGoForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoForward.Enabled = false;
            this.tsbGoForward.Image = global::RawBankEditor.Properties.Resources.forward;
            this.tsbGoForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoForward.Name = "tsbGoForward";
            this.tsbGoForward.Size = new System.Drawing.Size(24, 24);
            this.tsbGoForward.Tag = RawBankEditor.Entities.MainMenuItemType.GoForward;
            this.tsbGoForward.Text = "Prejsť dopredu";
            this.tsbGoForward.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Enabled = false;
            this.tsbUndo.Image = global::RawBankEditor.Properties.Resources.undo;
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(24, 24);
            this.tsbUndo.Tag = RawBankEditor.Entities.MainMenuItemType.Undo;
            this.tsbUndo.Text = "Späť";
            this.tsbUndo.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbRedo
            // 
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Enabled = false;
            this.tsbRedo.Image = global::RawBankEditor.Properties.Resources.redo;
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(24, 24);
            this.tsbRedo.Tag = RawBankEditor.Entities.MainMenuItemType.Redo;
            this.tsbRedo.Text = "Znovu";
            this.tsbRedo.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 24);
            this.toolStripLabel1.Text = "Jazyk:";
            // 
            // tscboxLanguages
            // 
            this.tscboxLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboxLanguages.DropDownWidth = 150;
            this.tscboxLanguages.Enabled = false;
            this.tscboxLanguages.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tscboxLanguages.Name = "tscboxLanguages";
            this.tscboxLanguages.Size = new System.Drawing.Size(114, 24);
            this.tscboxLanguages.SelectedIndexChanged += new System.EventHandler(this.tscboxLanguages_SelectedIndexChanged);
            // 
            // tsbLangsSettings
            // 
            this.tsbLangsSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLangsSettings.Enabled = false;
            this.tsbLangsSettings.Image = global::RawBankEditor.Properties.Resources.global_settings;
            this.tsbLangsSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLangsSettings.Name = "tsbLangsSettings";
            this.tsbLangsSettings.Size = new System.Drawing.Size(24, 24);
            this.tsbLangsSettings.Tag = RawBankEditor.Entities.MainMenuItemType.LangSettings;
            this.tsbLangsSettings.Text = "Nastavenie jazykov";
            this.tsbLangsSettings.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbConvertSounds
            // 
            this.tsbConvertSounds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbConvertSounds.Enabled = false;
            this.tsbConvertSounds.Image = global::RawBankEditor.Properties.Resources.convert;
            this.tsbConvertSounds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConvertSounds.Name = "tsbConvertSounds";
            this.tsbConvertSounds.Size = new System.Drawing.Size(24, 24);
            this.tsbConvertSounds.Tag = RawBankEditor.Entities.MainMenuItemType.ConvertSounds;
            this.tsbConvertSounds.Text = "Konvertovanie zvukov";
            this.tsbConvertSounds.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbAppSettings
            // 
            this.tsbAppSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAppSettings.Image = global::RawBankEditor.Properties.Resources.app_settings;
            this.tsbAppSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAppSettings.Name = "tsbAppSettings";
            this.tsbAppSettings.Size = new System.Drawing.Size(24, 24);
            this.tsbAppSettings.Tag = RawBankEditor.Entities.MainMenuItemType.AppSettings;
            this.tsbAppSettings.Text = "Nastavenia programu";
            this.tsbAppSettings.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbInfoApp
            // 
            this.tsbInfoApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInfoApp.Image = global::RawBankEditor.Properties.Resources.info_app;
            this.tsbInfoApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfoApp.Name = "tsbInfoApp";
            this.tsbInfoApp.Size = new System.Drawing.Size(24, 24);
            this.tsbInfoApp.Tag = RawBankEditor.Entities.MainMenuItemType.InfoApp;
            this.tsbInfoApp.Text = "Informácie o programe";
            this.tsbInfoApp.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbAddSound
            // 
            this.tsbAddSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddSound.Enabled = false;
            this.tsbAddSound.Image = global::RawBankEditor.Properties.Resources.add;
            this.tsbAddSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddSound.Name = "tsbAddSound";
            this.tsbAddSound.Size = new System.Drawing.Size(24, 24);
            this.tsbAddSound.Tag = RawBankEditor.Entities.MainMenuItemType.AddSound;
            this.tsbAddSound.Text = "Pridať zvuk";
            this.tsbAddSound.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbMoveSounds
            // 
            this.tsbMoveSounds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMoveSounds.Enabled = false;
            this.tsbMoveSounds.Image = global::RawBankEditor.Properties.Resources.move;
            this.tsbMoveSounds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoveSounds.Name = "tsbMoveSounds";
            this.tsbMoveSounds.Size = new System.Drawing.Size(24, 24);
            this.tsbMoveSounds.Tag = RawBankEditor.Entities.MainMenuItemType.MoveSounds;
            this.tsbMoveSounds.Text = "Premiestniť zvuky";
            this.tsbMoveSounds.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // tsbDeleteSound
            // 
            this.tsbDeleteSound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteSound.Enabled = false;
            this.tsbDeleteSound.Image = global::RawBankEditor.Properties.Resources.delete;
            this.tsbDeleteSound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteSound.Name = "tsbDeleteSound";
            this.tsbDeleteSound.Size = new System.Drawing.Size(24, 24);
            this.tsbDeleteSound.Tag = RawBankEditor.Entities.MainMenuItemType.DeleteSounds;
            this.tsbDeleteSound.Text = "Odstrániť zvuk";
            this.tsbDeleteSound.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Enabled = false;
            this.tsbSearch.Image = global::RawBankEditor.Properties.Resources.search;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(24, 24);
            this.tsbSearch.Tag = RawBankEditor.Entities.MainMenuItemType.Search;
            this.tsbSearch.Text = "Hľadať";
            this.tsbSearch.Click += new System.EventHandler(this.MainMenuItemClicked);
            // 
            // bWorkerReadDat
            // 
            this.bWorkerReadDat.WorkerReportsProgress = true;
            this.bWorkerReadDat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bWorkerReadDat_DoWork);
            this.bWorkerReadDat.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bWorkerReadDat_ProgressChanged);
            this.bWorkerReadDat.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bWorkerReadDat_RunWorkerCompleted);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.IncludeSubdirectories = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FMain";
            this.Text = "RawBankEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FMain_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolStripGroups.ResumeLayout(false);
            this.toolStripGroups.PerformLayout();
            this.contextMenuGroups.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplorer)).EndInit();
            this.contextMenuExplorer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemElementBindingSource)).EndInit();
            this.toolStripExplorer.ResumeLayout(false);
            this.toolStripExplorer.PerformLayout();
            this.splitSoundsErrors.Panel1.ResumeLayout(false);
            this.splitSoundsErrors.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSoundsErrors)).EndInit();
            this.splitSoundsErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSounds)).EndInit();
            this.contextMenuSounds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fyzSoundBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.toolStripErrors.ResumeLayout(false);
            this.toolStripErrors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrors)).EndInit();
            this.contextMenuErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rawBankMessageBindingSource)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ExTableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStripGroups;
        private ExTableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private ExTableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private ExControls.ExToolStripComboBox tscboxLanguages;
        private System.Windows.Forms.ToolStripMenuItem tsmimOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmimRecent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmimSave;
        private System.Windows.Forms.ToolStripMenuItem tsmimSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmimImport;
        private System.Windows.Forms.ToolStripMenuItem tsmimExport;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbEditGroup;
        private System.Windows.Forms.ToolStripButton tsbDeleteGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmimInfoApp;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAll;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbLangsSettings;
        private System.Windows.Forms.ToolStripButton tsbInfoApp;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbProgress;
        private System.Windows.Forms.ToolStripMenuItem tsmimLangsSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tsmimAppSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbAppSettings;
        private System.Windows.Forms.ContextMenuStrip contextMenuGroups;
        private System.Windows.Forms.ToolStripMenuItem cmiAddGroup;
        private System.Windows.Forms.ToolStripMenuItem cmiEditGroup;
        private System.Windows.Forms.ToolStripMenuItem cmiDeleteGroup;
        private System.Windows.Forms.ContextMenuStrip contextMenuSounds;
        private System.Windows.Forms.ToolStrip toolStripExplorer;
        private System.Windows.Forms.ToolStripButton tsbGoBack;
        private System.Windows.Forms.ToolStripButton tsbGoForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem tsmimUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmimRedo;
        private System.Windows.Forms.ToolStripMenuItem tsmimGoBack;
        private System.Windows.Forms.ToolStripMenuItem tsmimGoForward;
        private System.Windows.Forms.ToolStripDropDownButton tsbRecent;
        private System.ComponentModel.BackgroundWorker bWorkerReadDat;
        private System.Windows.Forms.ToolStripMenuItem tsmimUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem tsmimAddSound;
        private System.Windows.Forms.ToolStripMenuItem tsmimDeleteSound;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsbAddSound;
        private System.Windows.Forms.ToolStripButton tsbDeleteSound;
        private System.Windows.Forms.ToolStripButton tsbAddGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmimConvertSounds;
        private System.Windows.Forms.BindingSource fyzSoundBindingSource;
        private System.Windows.Forms.ToolStripButton tsbConvertSounds;
        private System.Windows.Forms.ToolStripMenuItem cmiAddSound;
        private System.Windows.Forms.ToolStripMenuItem cmiDeleteSound;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.SplitContainer splitSoundsErrors;
        private ExTableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStripErrors;
        private System.Windows.Forms.ToolStripButton tsbErrors;
        private System.Windows.Forms.ToolStripButton tsbWarnings;
        private System.Windows.Forms.ToolStripButton tsbInfos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.DataGridView dgvErrors;
        private System.Windows.Forms.ToolStripButton tsbOpenInExplorer;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private ExTableLayoutPanel tableLayoutPanel5;
        private Controls.MinButton mmErrors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripMenuItem tsmimMoveSounds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator18;
        private System.Windows.Forms.ToolStripMenuItem tsmimSearch;
        private System.Windows.Forms.DataGridView dgvExplorer;
        private System.Windows.Forms.ToolStripButton tsbMoveSounds;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource fileSystemElementBindingSource;
        private System.Windows.Forms.ToolStripButton tsbRenameFileDir;
        private System.Windows.Forms.ToolStripButton tsbRemoveFileDir;
        private System.Windows.Forms.BindingSource rawBankMessageBindingSource;
        private System.Windows.Forms.ToolStripDropDownButton tssbErrors;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalRelativePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewImageColumn dgvicType;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolveMessageDataGridViewTextBoxColumn;
        private ToolStripSeparator toolStripSeparator19;
        private ToolStripMenuItem konvertovaťNaWAVToolStripMenuItem;
        private ToolStripMenuItem konvertovaťNaEWAToolStripMenuItem;
        internal ListBox lboxGroups;
        internal DataGridView dgvSounds;
        private DataGridViewImageColumn cType;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cDuration;
        private ContextMenuStrip contextMenuExplorer;
        private ToolStripMenuItem otvoriťVPrieskumníkoviToolStripMenuItem;
        private ToolStripMenuItem prehraťZvukToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator20;
        private ToolStripMenuItem premenovaťSúborToolStripMenuItem;
        private ToolStripMenuItem odstrániťSúborToolStripMenuItem;
        private ContextMenuStrip contextMenuErrors;
        private ToolStripMenuItem cmiFindProblem;
        private ToolStripMenuItem cmiSolve;
        private ToolStripButton tsbSolve;
        private ToolStripButton tsbFindProblem;
    }
}

