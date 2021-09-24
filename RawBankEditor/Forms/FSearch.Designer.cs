
namespace RawBankEditor.Forms
{
    partial class FSearch
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
            this.tbText = new ExControls.ExTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.exGroupBox1 = new ExControls.ExGroupBox();
            this.rbText = new ExControls.ExRadioButton();
            this.rbName = new ExControls.ExRadioButton();
            this.rbKey = new ExControls.ExRadioButton();
            this.rbFileName = new ExControls.ExRadioButton();
            this.exGroupBox2 = new ExControls.ExGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bStorno = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.lStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.exGroupBox1.SuspendLayout();
            this.exGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hľadaný text:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbText
            // 
            this.tbText.BorderColor = System.Drawing.Color.DimGray;
            this.tbText.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.tbText.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbText.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.tbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbText.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.tbText.HintForeColor = System.Drawing.SystemColors.GrayText;
            this.tbText.HintText = null;
            this.tbText.Location = new System.Drawing.Point(206, 3);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(457, 22);
            this.tbText.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.exGroupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.exGroupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lStatus, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 216);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // exGroupBox1
            // 
            this.exGroupBox1.AutoSize = true;
            this.exGroupBox1.Controls.Add(this.rbText);
            this.exGroupBox1.Controls.Add(this.rbName);
            this.exGroupBox1.Controls.Add(this.rbKey);
            this.exGroupBox1.Controls.Add(this.rbFileName);
            this.exGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exGroupBox1.Location = new System.Drawing.Point(3, 31);
            this.exGroupBox1.Name = "exGroupBox1";
            this.exGroupBox1.Size = new System.Drawing.Size(197, 144);
            this.exGroupBox1.TabIndex = 2;
            this.exGroupBox1.TabStop = false;
            this.exGroupBox1.Text = "Parameter hľadania";
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbText.Location = new System.Drawing.Point(6, 102);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(108, 20);
            this.rbText.TabIndex = 3;
            this.rbText.TabStop = true;
            this.rbText.Text = "Text hlásenia";
            this.rbText.UseVisualStyleBackColor = true;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbName.Location = new System.Drawing.Point(6, 48);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(104, 20);
            this.rbName.TabIndex = 2;
            this.rbName.TabStop = true;
            this.rbName.Text = "Názov zvuku";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbKey
            // 
            this.rbKey.AutoSize = true;
            this.rbKey.Checked = true;
            this.rbKey.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbKey.Location = new System.Drawing.Point(6, 21);
            this.rbKey.Name = "rbKey";
            this.rbKey.Size = new System.Drawing.Size(91, 20);
            this.rbKey.TabIndex = 1;
            this.rbKey.TabStop = true;
            this.rbKey.Text = "Kľúč zvuku";
            this.rbKey.UseVisualStyleBackColor = true;
            // 
            // rbFileName
            // 
            this.rbFileName.AutoSize = true;
            this.rbFileName.HighlightColor = System.Drawing.SystemColors.Highlight;
            this.rbFileName.Location = new System.Drawing.Point(6, 75);
            this.rbFileName.Name = "rbFileName";
            this.rbFileName.Size = new System.Drawing.Size(185, 20);
            this.rbFileName.TabIndex = 0;
            this.rbFileName.TabStop = true;
            this.rbFileName.Text = "Názov súboru (s príponou)";
            this.rbFileName.UseVisualStyleBackColor = true;
            // 
            // exGroupBox2
            // 
            this.exGroupBox2.Controls.Add(this.label3);
            this.exGroupBox2.Controls.Add(this.label2);
            this.exGroupBox2.Controls.Add(this.trackBarOpacity);
            this.exGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exGroupBox2.Location = new System.Drawing.Point(206, 31);
            this.exGroupBox2.Name = "exGroupBox2";
            this.exGroupBox2.Size = new System.Drawing.Size(457, 144);
            this.exGroupBox2.TabIndex = 3;
            this.exGroupBox2.TabStop = false;
            this.exGroupBox2.Text = "Nepriehľadnosť okna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "50%";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "100%";
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarOpacity.LargeChange = 10;
            this.trackBarOpacity.Location = new System.Drawing.Point(3, 18);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 50;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(451, 123);
            this.trackBarOpacity.SmallChange = 5;
            this.trackBarOpacity.TabIndex = 0;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarOpacity.Value = 100;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.bStorno);
            this.flowLayoutPanel1.Controls.Add(this.bSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(206, 181);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(457, 33);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // bStorno
            // 
            this.bStorno.AutoSize = true;
            this.bStorno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bStorno.Location = new System.Drawing.Point(379, 3);
            this.bStorno.Name = "bStorno";
            this.bStorno.Size = new System.Drawing.Size(75, 27);
            this.bStorno.TabIndex = 5;
            this.bStorno.Text = "Zrušiť";
            this.bStorno.UseVisualStyleBackColor = true;
            this.bStorno.Click += new System.EventHandler(this.bStorno_Click);
            // 
            // bSearch
            // 
            this.bSearch.AutoSize = true;
            this.bSearch.Location = new System.Drawing.Point(278, 3);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(95, 27);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Hľadať ďalší";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lStatus.ForeColor = System.Drawing.Color.Red;
            this.lStatus.Location = new System.Drawing.Point(3, 178);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(197, 39);
            this.lStatus.TabIndex = 6;
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FSearch
            // 
            this.AcceptButton = this.bSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bStorno;
            this.ClientSize = new System.Drawing.Size(686, 236);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(704, 283);
            this.Name = "FSearch";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Hľadať";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.exGroupBox1.ResumeLayout(false);
            this.exGroupBox1.PerformLayout();
            this.exGroupBox2.ResumeLayout(false);
            this.exGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ExControls.ExTextBox tbText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ExControls.ExGroupBox exGroupBox1;
        private ExControls.ExRadioButton rbText;
        private ExControls.ExRadioButton rbName;
        private ExControls.ExRadioButton rbKey;
        private ExControls.ExRadioButton rbFileName;
        private ExControls.ExGroupBox exGroupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bStorno;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label lStatus;
    }
}