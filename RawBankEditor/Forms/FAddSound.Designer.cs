
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kľúč zvuku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Názov zvuku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text hlásenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prídavná relatívna cesta:";
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bSave.AutoSize = true;
            this.bSave.Location = new System.Drawing.Point(193, 221);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 27);
            this.bSave.TabIndex = 10;
            this.bSave.Text = "Uložiť";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // bStorno
            // 
            this.bStorno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bStorno.AutoSize = true;
            this.bStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bStorno.Location = new System.Drawing.Point(291, 221);
            this.bStorno.Name = "bStorno";
            this.bStorno.Size = new System.Drawing.Size(75, 27);
            this.bStorno.TabIndex = 11;
            this.bStorno.Text = "Zrušiť";
            this.bStorno.UseVisualStyleBackColor = true;
            this.bStorno.Click += new System.EventHandler(this.BStorno_Click);
            // 
            // tbRelativePath
            // 
            this.tbRelativePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.BorderColor = System.Drawing.Color.DimGray;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.DefaultStyle = false;
            this.rtbText.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.rtbText.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbText.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.rtbText.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rtbText.Location = new System.Drawing.Point(15, 104);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(536, 111);
            this.rtbText.TabIndex = 12;
            this.rtbText.Text = "";
            // 
            // FAddSound
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bStorno;
            this.ClientSize = new System.Drawing.Size(564, 260);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.bStorno);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbRelativePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAddSound";
            this.ShowIcon = false;
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
        private ExControls.ExButton bSave;
        private ExControls.ExButton bStorno;
        private ExControls.ExRichTextBox rtbText;
    }
}