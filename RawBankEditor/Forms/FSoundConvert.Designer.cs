
using ExControls;

namespace RawBankEditor.Forms
{
    partial class FSoundConvert
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
            this.groupBox1 = new ExGroupBox();
            this.rbEWAtoWAV = new ExRadioButton();
            this.rbWAVtoEWA = new ExRadioButton();
            this.groupBox2 = new ExGroupBox();
            this.rbOneFile = new ExRadioButton();
            this.rbGroups = new ExRadioButton();
            this.rbWholeBank = new ExRadioButton();
            this.groupBox3 = new ExGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputFilePath = new ExTextBox();
            this.bBrowseInput = new ExControls.ExButton();
            this.pOneFile = new System.Windows.Forms.Panel();
            this.pGroups = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.clistboxGroups = new ExCheckedListBox();
            this.groupBox4 = new ExGroupBox();
            this.rbReplace = new ExRadioButton();
            this.rbAdd = new ExRadioButton();
            this.rbToNewFolder = new ExRadioButton();
            this.pNewOutputFolder = new System.Windows.Forms.Panel();
            this.tbOutputFolderPath = new ExTextBox();
            this.bBrowseOutputFolder = new ExControls.ExButton();
            this.bConvert = new ExControls.ExButton();
            this.bStorno = new ExControls.ExButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pOneFile.SuspendLayout();
            this.pGroups.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pNewOutputFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWAVtoEWA);
            this.groupBox1.Controls.Add(this.rbEWAtoWAV);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Formát";
            // 
            // rbEWAtoWAV
            // 
            this.rbEWAtoWAV.AutoSize = true;
            this.rbEWAtoWAV.Location = new System.Drawing.Point(30, 31);
            this.rbEWAtoWAV.Name = "rbEWAtoWAV";
            this.rbEWAtoWAV.Size = new System.Drawing.Size(136, 21);
            this.rbEWAtoWAV.TabIndex = 0;
            this.rbEWAtoWAV.Text = "Z .EWA na .WAV";
            this.rbEWAtoWAV.UseVisualStyleBackColor = true;
            // 
            // rbWAVtoEWA
            // 
            this.rbWAVtoEWA.AutoSize = true;
            this.rbWAVtoEWA.Checked = true;
            this.rbWAVtoEWA.Location = new System.Drawing.Point(237, 31);
            this.rbWAVtoEWA.Name = "rbWAVtoEWA";
            this.rbWAVtoEWA.Size = new System.Drawing.Size(136, 21);
            this.rbWAVtoEWA.TabIndex = 1;
            this.rbWAVtoEWA.TabStop = true;
            this.rbWAVtoEWA.Text = "Z .WAV na .EWA";
            this.rbWAVtoEWA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWholeBank);
            this.groupBox2.Controls.Add(this.rbGroups);
            this.groupBox2.Controls.Add(this.rbOneFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Počet zvukových súborov";
            // 
            // rbOneFile
            // 
            this.rbOneFile.AutoSize = true;
            this.rbOneFile.Location = new System.Drawing.Point(30, 23);
            this.rbOneFile.Name = "rbOneFile";
            this.rbOneFile.Size = new System.Drawing.Size(77, 21);
            this.rbOneFile.TabIndex = 0;
            this.rbOneFile.Text = "1 súbor";
            this.rbOneFile.UseVisualStyleBackColor = true;
            // 
            // rbGroups
            // 
            this.rbGroups.AutoSize = true;
            this.rbGroups.Checked = true;
            this.rbGroups.Location = new System.Drawing.Point(152, 23);
            this.rbGroups.Name = "rbGroups";
            this.rbGroups.Size = new System.Drawing.Size(128, 21);
            this.rbGroups.TabIndex = 1;
            this.rbGroups.TabStop = true;
            this.rbGroups.Text = "Skupina zvukov";
            this.rbGroups.UseVisualStyleBackColor = true;
            // 
            // rbWholeBank
            // 
            this.rbWholeBank.AutoSize = true;
            this.rbWholeBank.Location = new System.Drawing.Point(328, 23);
            this.rbWholeBank.Name = "rbWholeBank";
            this.rbWholeBank.Size = new System.Drawing.Size(100, 21);
            this.rbWholeBank.TabIndex = 2;
            this.rbWholeBank.Text = "Celá banka";
            this.rbWholeBank.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pGroups);
            this.groupBox3.Controls.Add(this.pOneFile);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 317);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Výber vstupných zvukových súborov";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 súbor:";
            // 
            // tbInputFilePath
            // 
            this.tbInputFilePath.Location = new System.Drawing.Point(69, 15);
            this.tbInputFilePath.Name = "tbInputFilePath";
            this.tbInputFilePath.ReadOnly = true;
            this.tbInputFilePath.Size = new System.Drawing.Size(263, 22);
            this.tbInputFilePath.TabIndex = 1;
            // 
            // bBrowseInput
            // 
            this.bBrowseInput.AutoSize = true;
            this.bBrowseInput.Location = new System.Drawing.Point(338, 12);
            this.bBrowseInput.Name = "bBrowseInput";
            this.bBrowseInput.Size = new System.Drawing.Size(105, 29);
            this.bBrowseInput.TabIndex = 2;
            this.bBrowseInput.Text = "Prehľadávať";
            this.bBrowseInput.UseVisualStyleBackColor = true;
            // 
            // pOneFile
            // 
            this.pOneFile.Controls.Add(this.label1);
            this.pOneFile.Controls.Add(this.bBrowseInput);
            this.pOneFile.Controls.Add(this.tbInputFilePath);
            this.pOneFile.Location = new System.Drawing.Point(6, 21);
            this.pOneFile.Name = "pOneFile";
            this.pOneFile.Size = new System.Drawing.Size(459, 48);
            this.pOneFile.TabIndex = 3;
            // 
            // pGroups
            // 
            this.pGroups.Controls.Add(this.clistboxGroups);
            this.pGroups.Controls.Add(this.label2);
            this.pGroups.Location = new System.Drawing.Point(6, 76);
            this.pGroups.Name = "pGroups";
            this.pGroups.Size = new System.Drawing.Size(459, 229);
            this.pGroups.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Výber skupiny zvukov:";
            // 
            // clistboxGroups
            // 
            this.clistboxGroups.FormattingEnabled = true;
            this.clistboxGroups.Location = new System.Drawing.Point(3, 31);
            this.clistboxGroups.Name = "clistboxGroups";
            this.clistboxGroups.Size = new System.Drawing.Size(450, 191);
            this.clistboxGroups.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pNewOutputFolder);
            this.groupBox4.Controls.Add(this.rbToNewFolder);
            this.groupBox4.Controls.Add(this.rbAdd);
            this.groupBox4.Controls.Add(this.rbReplace);
            this.groupBox4.Location = new System.Drawing.Point(12, 484);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(471, 139);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "4. Umiestnenie výstupných súborov";
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Checked = true;
            this.rbReplace.Location = new System.Drawing.Point(12, 22);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(210, 21);
            this.rbReplace.TabIndex = 0;
            this.rbReplace.TabStop = true;
            this.rbReplace.Text = "Nahradiť v pôvodnom mieste";
            this.rbReplace.UseVisualStyleBackColor = true;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Location = new System.Drawing.Point(237, 22);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(207, 21);
            this.rbAdd.TabIndex = 1;
            this.rbAdd.Text = "Pridať do pôvodného miesta";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbToNewFolder
            // 
            this.rbToNewFolder.AutoSize = true;
            this.rbToNewFolder.Location = new System.Drawing.Point(12, 50);
            this.rbToNewFolder.Name = "rbToNewFolder";
            this.rbToNewFolder.Size = new System.Drawing.Size(149, 21);
            this.rbToNewFolder.TabIndex = 2;
            this.rbToNewFolder.Text = "Vložiť do priečinka:";
            this.rbToNewFolder.UseVisualStyleBackColor = true;
            // 
            // pNewOutputFolder
            // 
            this.pNewOutputFolder.Controls.Add(this.bBrowseOutputFolder);
            this.pNewOutputFolder.Controls.Add(this.tbOutputFolderPath);
            this.pNewOutputFolder.Location = new System.Drawing.Point(12, 78);
            this.pNewOutputFolder.Name = "pNewOutputFolder";
            this.pNewOutputFolder.Size = new System.Drawing.Size(453, 55);
            this.pNewOutputFolder.TabIndex = 3;
            // 
            // tbOutputFolderPath
            // 
            this.tbOutputFolderPath.Location = new System.Drawing.Point(3, 16);
            this.tbOutputFolderPath.Name = "tbOutputFolderPath";
            this.tbOutputFolderPath.ReadOnly = true;
            this.tbOutputFolderPath.Size = new System.Drawing.Size(323, 22);
            this.tbOutputFolderPath.TabIndex = 0;
            // 
            // bBrowseOutputFolder
            // 
            this.bBrowseOutputFolder.AutoSize = true;
            this.bBrowseOutputFolder.Location = new System.Drawing.Point(332, 13);
            this.bBrowseOutputFolder.Name = "bBrowseOutputFolder";
            this.bBrowseOutputFolder.Size = new System.Drawing.Size(105, 29);
            this.bBrowseOutputFolder.TabIndex = 3;
            this.bBrowseOutputFolder.Text = "Prehľadávať";
            this.bBrowseOutputFolder.UseVisualStyleBackColor = true;
            // 
            // bConvert
            // 
            this.bConvert.AutoSize = true;
            this.bConvert.Location = new System.Drawing.Point(126, 631);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(95, 33);
            this.bConvert.TabIndex = 4;
            this.bConvert.Text = "Konvertovať";
            this.bConvert.UseVisualStyleBackColor = true;
            // 
            // bStorno
            // 
            this.bStorno.AutoSize = true;
            this.bStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bStorno.Location = new System.Drawing.Point(273, 631);
            this.bStorno.Name = "bStorno";
            this.bStorno.Size = new System.Drawing.Size(95, 33);
            this.bStorno.TabIndex = 5;
            this.bStorno.Text = "Zrušiť";
            this.bStorno.UseVisualStyleBackColor = true;
            // 
            // FSoundConvert
            // 
            this.AcceptButton = this.bConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bStorno;
            this.ClientSize = new System.Drawing.Size(495, 676);
            this.Controls.Add(this.bStorno);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSoundConvert";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Konvertovanie zvukov";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.pOneFile.ResumeLayout(false);
            this.pOneFile.PerformLayout();
            this.pGroups.ResumeLayout(false);
            this.pGroups.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pNewOutputFolder.ResumeLayout(false);
            this.pNewOutputFolder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExGroupBox groupBox1;
        private ExRadioButton rbWAVtoEWA;
        private ExRadioButton rbEWAtoWAV;
        private ExGroupBox groupBox2;
        private ExRadioButton rbWholeBank;
        private ExRadioButton rbGroups;
        private ExRadioButton rbOneFile;
        private ExGroupBox groupBox3;
        private System.Windows.Forms.Panel pGroups;
        private ExCheckedListBox clistboxGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pOneFile;
        private System.Windows.Forms.Label label1;
        private ExControls.ExButton bBrowseInput;
        private ExTextBox tbInputFilePath;
        private ExGroupBox groupBox4;
        private System.Windows.Forms.Panel pNewOutputFolder;
        private ExControls.ExButton bBrowseOutputFolder;
        private ExTextBox tbOutputFolderPath;
        private ExRadioButton rbToNewFolder;
        private ExRadioButton rbAdd;
        private ExRadioButton rbReplace;
        private ExControls.ExButton bConvert;
        private ExControls.ExButton bStorno;
    }
}