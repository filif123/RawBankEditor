
using ExControls;

namespace RawBankEditor.Forms
{
    partial class FEditGroup
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
            this.tbKey = new ExControls.ExTextBox();
            this.tbName = new ExControls.ExTextBox();
            this.tbRelativePath = new ExControls.ExTextBox();
            this.bOK = new ExControls.ExButton();
            this.exTableLayoutPanel1 = new ExControls.ExTableLayoutPanel();
            this.exTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kľúč skupiny:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Názov skupiny:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Relatívna cesta:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbKey
            // 
            this.tbKey.BorderColor = System.Drawing.Color.DimGray;
            this.tbKey.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbKey.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbKey.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKey.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbKey.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbKey.HintText = null;
            this.tbKey.Location = new System.Drawing.Point(117, 8);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(331, 22);
            this.tbKey.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.BorderColor = System.Drawing.Color.DimGray;
            this.tbName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbName.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbName.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbName.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbName.HintText = null;
            this.tbName.Location = new System.Drawing.Point(117, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(331, 22);
            this.tbName.TabIndex = 4;
            // 
            // tbRelativePath
            // 
            this.tbRelativePath.BorderColor = System.Drawing.Color.DimGray;
            this.tbRelativePath.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbRelativePath.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbRelativePath.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbRelativePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRelativePath.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbRelativePath.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbRelativePath.HintText = null;
            this.tbRelativePath.Location = new System.Drawing.Point(117, 64);
            this.tbRelativePath.Name = "tbRelativePath";
            this.tbRelativePath.Size = new System.Drawing.Size(331, 22);
            this.tbRelativePath.TabIndex = 5;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.Location = new System.Drawing.Point(372, 92);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(76, 36);
            this.bOK.TabIndex = 6;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // exTableLayoutPanel1
            // 
            this.exTableLayoutPanel1.BorderColor = System.Drawing.Color.Empty;
            this.exTableLayoutPanel1.ColumnCount = 2;
            this.exTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.exTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.exTableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.exTableLayoutPanel1.Controls.Add(this.bOK, 1, 3);
            this.exTableLayoutPanel1.Controls.Add(this.tbKey, 1, 0);
            this.exTableLayoutPanel1.Controls.Add(this.tbRelativePath, 1, 2);
            this.exTableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.exTableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.exTableLayoutPanel1.Controls.Add(this.tbName, 1, 1);
            this.exTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.exTableLayoutPanel1.Name = "exTableLayoutPanel1";
            this.exTableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.exTableLayoutPanel1.RowCount = 4;
            this.exTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.exTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.exTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.exTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.exTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.exTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.exTableLayoutPanel1.Size = new System.Drawing.Size(456, 134);
            this.exTableLayoutPanel1.TabIndex = 7;
            // 
            // FEditGroup
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 134);
            this.Controls.Add(this.exTableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 181);
            this.Name = "FEditGroup";
            this.ShowInTaskbar = false;
            this.Text = "Úprava skupiny zvukov";
            this.exTableLayoutPanel1.ResumeLayout(false);
            this.exTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ExTextBox tbKey;
        private ExTextBox tbName;
        private ExTextBox tbRelativePath;
        private ExControls.ExButton bOK;
        private ExTableLayoutPanel exTableLayoutPanel1;
    }
}