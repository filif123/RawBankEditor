
using ExControls;

namespace RawBankEditor.Forms
{
    partial class FInfoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInfoApp));
            this.label4 = new System.Windows.Forms.Label();
            this.lAppVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lAppName = new System.Windows.Forms.Label();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.linkWeb = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bOK = new ExControls.ExButton();
            this.groupBox1 = new ExControls.ExGroupBox();
            this.groupBox2 = new ExControls.ExGroupBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(2, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 70);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tento program slúži na úpravu binárnych súborov zvukovej banky, ktoré používa pro" +
    "gram INISS. \r\nProgram RawBankEditor nie je oficiálna aplikácia spoločnosti CHAPS" +
    " ani spoločnosti INPROP.";
            // 
            // lAppVersion
            // 
            this.lAppVersion.AutoSize = true;
            this.lAppVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lAppVersion.Location = new System.Drawing.Point(164, 37);
            this.lAppVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(40, 13);
            this.lAppVersion.TabIndex = 13;
            this.lAppVersion.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(121, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Verzia:";
            // 
            // lAppName
            // 
            this.lAppName.AutoSize = true;
            this.lAppName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lAppName.Location = new System.Drawing.Point(121, 10);
            this.lAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAppName.Name = "lAppName";
            this.lAppName.Size = new System.Drawing.Size(54, 13);
            this.lAppName.TabIndex = 9;
            this.lAppName.Text = "AppName";
            // 
            // linkEmail
            // 
            this.linkEmail.AutoSize = true;
            this.linkEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkEmail.Location = new System.Drawing.Point(82, 52);
            this.linkEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(31, 13);
            this.linkEmail.TabIndex = 14;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "email";
            this.linkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmail_LinkClicked);
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkWeb.Location = new System.Drawing.Point(82, 26);
            this.linkWeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(71, 13);
            this.linkWeb.TabIndex = 12;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "gvdeditorweb";
            this.linkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkWeb_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(13, 52);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Web:";
            // 
            // bOK
            // 
            this.bOK.AutoSize = true;
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bOK.Location = new System.Drawing.Point(117, 273);
            this.bOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(56, 27);
            this.bOK.TabIndex = 15;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(9, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(260, 87);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charakteristika programu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.linkWeb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.linkEmail);
            this.groupBox2.Location = new System.Drawing.Point(9, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(260, 81);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informácie";
            // 
            // picIcon
            // 
            this.picIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picIcon.ErrorImage")));
            this.picIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picIcon.Location = new System.Drawing.Point(11, 9);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(74, 72);
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            // 
            // FInfoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lAppVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lAppName);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.bOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FInfoApp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Informácie o programe";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FInfoApp_HelpButtonClicked);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lAppVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lAppName;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.LinkLabel linkEmail;
        private System.Windows.Forms.LinkLabel linkWeb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private ExControls.ExButton bOK;
        private ExGroupBox groupBox1;
        private ExGroupBox groupBox2;
    }
}