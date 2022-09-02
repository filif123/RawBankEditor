namespace RawBankEditor.Forms
{
    partial class FSoundsMove
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGroups = new ExControls.ExComboBox();
            this.exLabel1 = new ExControls.ExLabel();
            this.bStorno = new ExControls.ExButton();
            this.bOK = new ExControls.ExButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbGroups);
            this.panel1.Controls.Add(this.exLabel1);
            this.panel1.Controls.Add(this.bStorno);
            this.panel1.Controls.Add(this.bOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(328, 93);
            this.panel1.TabIndex = 0;
            // 
            // cbGroups
            // 
            this.cbGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroups.DropDownSelectedRowBackColor = System.Drawing.SystemColors.Highlight;
            this.cbGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(13, 26);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(303, 21);
            this.cbGroups.StyleDisabled.ArrowColor = null;
            this.cbGroups.StyleDisabled.BackColor = null;
            this.cbGroups.StyleDisabled.BorderColor = null;
            this.cbGroups.StyleDisabled.ButtonBackColor = null;
            this.cbGroups.StyleDisabled.ButtonBorderColor = null;
            this.cbGroups.StyleDisabled.ButtonRenderFirst = null;
            this.cbGroups.StyleDisabled.ForeColor = null;
            this.cbGroups.StyleHighlight.ArrowColor = null;
            this.cbGroups.StyleHighlight.BackColor = null;
            this.cbGroups.StyleHighlight.BorderColor = null;
            this.cbGroups.StyleHighlight.ButtonBackColor = null;
            this.cbGroups.StyleHighlight.ButtonBorderColor = null;
            this.cbGroups.StyleHighlight.ButtonRenderFirst = null;
            this.cbGroups.StyleHighlight.ForeColor = null;
            this.cbGroups.StyleNormal.ArrowColor = null;
            this.cbGroups.StyleNormal.BackColor = null;
            this.cbGroups.StyleNormal.BorderColor = null;
            this.cbGroups.StyleNormal.ButtonBackColor = null;
            this.cbGroups.StyleNormal.ButtonBorderColor = null;
            this.cbGroups.StyleNormal.ButtonRenderFirst = null;
            this.cbGroups.StyleNormal.ForeColor = null;
            this.cbGroups.StyleSelected.ArrowColor = null;
            this.cbGroups.StyleSelected.BackColor = null;
            this.cbGroups.StyleSelected.BorderColor = null;
            this.cbGroups.StyleSelected.ButtonBackColor = null;
            this.cbGroups.StyleSelected.ButtonBorderColor = null;
            this.cbGroups.StyleSelected.ButtonRenderFirst = null;
            this.cbGroups.StyleSelected.ForeColor = null;
            this.cbGroups.TabIndex = 1;
            this.cbGroups.UseDarkScrollBar = false;
            // 
            // exLabel1
            // 
            this.exLabel1.AutoSize = true;
            this.exLabel1.Location = new System.Drawing.Point(9, 9);
            this.exLabel1.Name = "exLabel1";
            this.exLabel1.Size = new System.Drawing.Size(76, 13);
            this.exLabel1.TabIndex = 0;
            this.exLabel1.Text = "Nová skupina:";
            // 
            // bStorno
            // 
            this.bStorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bStorno.Location = new System.Drawing.Point(245, 62);
            this.bStorno.Name = "bStorno";
            this.bStorno.Size = new System.Drawing.Size(75, 23);
            this.bStorno.TabIndex = 3;
            this.bStorno.Text = "Zrušiť";
            this.bStorno.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.Location = new System.Drawing.Point(164, 62);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "Vybrať";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // FSoundsMove
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bStorno;
            this.ClientSize = new System.Drawing.Size(328, 93);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSoundsMove";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Vybrať novú skupinu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ExControls.ExButton bOK;
        private ExControls.ExButton bStorno;
        private ExControls.ExComboBox cbGroups;
        private ExControls.ExLabel exLabel1;
    }
}