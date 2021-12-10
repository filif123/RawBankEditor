
namespace RawBankEditor.Forms
{
    partial class FAddSound
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lboxSounds = new System.Windows.Forms.ListBox();
            this.bSave = new ExControls.ExButton();
            this.bStorno = new ExControls.ExButton();
            this.tbRelativePath = new ExControls.ExTextBox();
            this.tbName = new ExControls.ExTextBox();
            this.tbKey = new ExControls.ExTextBox();
            this.rtbText = new ExControls.ExRichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kľúč zvuku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Názov zvuku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text hlásenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prídavná relatívna cesta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Súbor so zvukom:";
            // 
            // lboxSounds
            // 
            this.lboxSounds.FormattingEnabled = true;
            this.lboxSounds.ItemHeight = 16;
            this.lboxSounds.Location = new System.Drawing.Point(15, 263);
            this.lboxSounds.MultiColumn = true;
            this.lboxSounds.Name = "lboxSounds";
            this.lboxSounds.Size = new System.Drawing.Size(536, 100);
            this.lboxSounds.TabIndex = 9;
            // 
            // bSave
            // 
            this.bSave.AutoSize = true;
            this.bSave.Location = new System.Drawing.Point(179, 378);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 27);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Uložiť";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bStorno
            // 
            this.bStorno.AutoSize = true;
            this.bStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bStorno.Location = new System.Drawing.Point(309, 378);
            this.bStorno.Name = "bStorno";
            this.bStorno.Size = new System.Drawing.Size(75, 27);
            this.bStorno.TabIndex = 11;
            this.bStorno.Text = "Zrušiť";
            this.bStorno.UseVisualStyleBackColor = true;
            // 
            // tbRelativePath
            // 
            this.tbRelativePath.BorderColor = System.Drawing.Color.DimGray;
            this.tbRelativePath.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbRelativePath.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbRelativePath.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbRelativePath.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbRelativePath.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbRelativePath.HintText = "(Nepovinné) Napr. CISLO/";
            this.tbRelativePath.Location = new System.Drawing.Point(179, 46);
            this.tbRelativePath.Name = "tbRelativePath";
            this.tbRelativePath.Size = new System.Drawing.Size(372, 22);
            this.tbRelativePath.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.BorderColor = System.Drawing.Color.DimGray;
            this.tbName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbName.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbName.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbName.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbName.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbName.HintText = "(Povinné)";
            this.tbName.Location = new System.Drawing.Point(379, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbKey
            // 
            this.tbKey.BorderColor = System.Drawing.Color.DimGray;
            this.tbKey.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbKey.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbKey.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbKey.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbKey.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbKey.HintText = "(Povinné)";
            this.tbKey.Location = new System.Drawing.Point(96, 12);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(172, 22);
            this.tbKey.TabIndex = 3;
            // 
            // rtbText
            // 
            this.rtbText.BorderColor = System.Drawing.Color.DimGray;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.DefaultStyle = false;
            this.rtbText.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.rtbText.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbText.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.rtbText.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rtbText.Location = new System.Drawing.Point(15, 104);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(536, 123);
            this.rtbText.TabIndex = 12;
            this.rtbText.Text = "";
            // 
            // FAddSound
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bStorno;
            this.ClientSize = new System.Drawing.Size(564, 417);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.bStorno);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lboxSounds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRelativePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAddSound";
            this.ShowInTaskbar = false;
            this.Text = "Pridať zvuk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ExControls.ExTextBox tbKey;
        private ExControls.ExTextBox tbName;
        private System.Windows.Forms.Label label4;
        private ExControls.ExTextBox tbRelativePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lboxSounds;
        private ExControls.ExButton bSave;
        private ExControls.ExButton bStorno;
        private ExControls.ExRichTextBox rtbText;
    }
}