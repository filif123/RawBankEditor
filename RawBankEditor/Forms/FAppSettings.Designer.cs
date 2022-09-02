namespace RawBankEditor.Forms
{
    partial class FAppSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAppSettings));
            this.exGroupBox2 = new ExControls.ExGroupBox();
            this.cboxAutoRecalculateSoundDurations = new ExControls.ExCheckBox();
            this.cboxAutoInsertSoundData = new ExControls.ExCheckBox();
            this.cboxShowAfterInsertSoundDlg = new ExControls.ExCheckBox();
            this.pGeneral.SuspendLayout();
            this.pConcreteGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsView)).BeginInit();
            this.pDesktopComponents.SuspendLayout();
            this.pLocalization.SuspendLayout();
            this.exGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pConcreteGeneral
            // 
            this.pConcreteGeneral.Controls.Add(this.exGroupBox2);
            this.pConcreteGeneral.Size = new System.Drawing.Size(521, 270);
            // 
            // optionsView
            // 
            this.optionsView.HeaderNodeNameVisible = true;
            this.optionsView.SearchBoxVisible = true;
            this.optionsView.Size = new System.Drawing.Size(800, 440);
            // 
            // 
            // 
            this.optionsView.TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsView.TreeView.FullRowSelect = true;
            this.optionsView.TreeView.HideSelection = false;
            this.optionsView.TreeView.ImageIndex = 0;
            this.optionsView.TreeView.ItemHeight = 20;
            this.optionsView.TreeView.Name = "treeView";
            this.optionsView.TreeView.PathSeparator = " / ";
            this.optionsView.TreeView.SelectedImageIndex = 0;
            this.optionsView.TreeView.ShowLines = false;
            this.optionsView.TreeView.ShowNodeToolTips = true;
            this.optionsView.TreeView.Style = ExControls.ExTreeViewStyle.Light;
            this.optionsView.TreeView.TabIndex = 0;
            // 
            // exGroupBox2
            // 
            this.exGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exGroupBox2.AutoSize = true;
            this.exGroupBox2.Controls.Add(this.cboxShowAfterInsertSoundDlg);
            this.exGroupBox2.Controls.Add(this.cboxAutoInsertSoundData);
            this.exGroupBox2.Controls.Add(this.cboxAutoRecalculateSoundDurations);
            this.exGroupBox2.Location = new System.Drawing.Point(0, 6);
            this.exGroupBox2.Name = "exGroupBox2";
            this.exGroupBox2.Size = new System.Drawing.Size(521, 101);
            this.exGroupBox2.TabIndex = 0;
            this.exGroupBox2.TabStop = false;
            this.exGroupBox2.Text = "Program";
            // 
            // cboxAutoRecalculateSoundDurations
            // 
            this.cboxAutoRecalculateSoundDurations.AutoSize = true;
            this.cboxAutoRecalculateSoundDurations.BoxBackColor = System.Drawing.Color.White;
            this.cboxAutoRecalculateSoundDurations.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxAutoRecalculateSoundDurations.Location = new System.Drawing.Point(7, 19);
            this.cboxAutoRecalculateSoundDurations.Name = "cboxAutoRecalculateSoundDurations";
            this.cboxAutoRecalculateSoundDurations.Size = new System.Drawing.Size(215, 17);
            this.cboxAutoRecalculateSoundDurations.TabIndex = 0;
            this.cboxAutoRecalculateSoundDurations.Text = "Automaticky prepočítavať dĺžky zvukov";
            // 
            // cboxAutoInsertSoundData
            // 
            this.cboxAutoInsertSoundData.AutoSize = true;
            this.cboxAutoInsertSoundData.BoxBackColor = System.Drawing.Color.White;
            this.cboxAutoInsertSoundData.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxAutoInsertSoundData.Location = new System.Drawing.Point(7, 42);
            this.cboxAutoInsertSoundData.Name = "cboxAutoInsertSoundData";
            this.cboxAutoInsertSoundData.Size = new System.Drawing.Size(382, 17);
            this.cboxAutoInsertSoundData.TabIndex = 1;
            this.cboxAutoInsertSoundData.Text = "Automaticky vytvárať dáta zvukov pridaných do priečinkov zvukovej banky";
            this.cboxAutoInsertSoundData.CheckedChanged += new System.EventHandler(this.CboxAutoInsertSoundData_CheckedChanged);
            // 
            // cboxShowAfterInsertSoundDlg
            // 
            this.cboxShowAfterInsertSoundDlg.AutoSize = true;
            this.cboxShowAfterInsertSoundDlg.BoxBackColor = System.Drawing.Color.White;
            this.cboxShowAfterInsertSoundDlg.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.cboxShowAfterInsertSoundDlg.Location = new System.Drawing.Point(7, 65);
            this.cboxShowAfterInsertSoundDlg.Name = "cboxShowAfterInsertSoundDlg";
            this.cboxShowAfterInsertSoundDlg.Size = new System.Drawing.Size(390, 17);
            this.cboxShowAfterInsertSoundDlg.TabIndex = 2;
            this.cboxShowAfterInsertSoundDlg.Text = "Otvoriť dialóg s úpravou dát zvukov pri pridaní do priečinkov zvukovej banky";
            // 
            // FAppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAppSettings";
            this.pGeneral.ResumeLayout(false);
            this.pGeneral.PerformLayout();
            this.pConcreteGeneral.ResumeLayout(false);
            this.pConcreteGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsView)).EndInit();
            this.pDesktopComponents.ResumeLayout(false);
            this.pDesktopComponents.PerformLayout();
            this.pLocalization.ResumeLayout(false);
            this.pLocalization.PerformLayout();
            this.exGroupBox2.ResumeLayout(false);
            this.exGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExControls.ExGroupBox exGroupBox2;
        private ExControls.ExCheckBox cboxAutoRecalculateSoundDurations;
        private ExControls.ExCheckBox cboxAutoInsertSoundData;
        private ExControls.ExCheckBox cboxShowAfterInsertSoundDlg;
    }
}