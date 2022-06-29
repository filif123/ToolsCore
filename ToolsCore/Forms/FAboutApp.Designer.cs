using ExControls;

namespace ToolsCore.Forms
{
    partial class FAboutApp
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
            this.lText = new System.Windows.Forms.Label();
            this.lAppVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lAppName = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkWeb = new System.Windows.Forms.LinkLabel();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new ExControls.ExGroupBox();
            this.groupBox1 = new ExControls.ExGroupBox();
            this.bOK = new ExControls.ExButton();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lText
            // 
            this.lText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lText.Location = new System.Drawing.Point(5, 18);
            this.lText.Name = "lText";
            this.lText.Size = new System.Drawing.Size(347, 102);
            this.lText.TabIndex = 6;
            this.lText.Text = "\r\n";
            // 
            // lAppVersion
            // 
            this.lAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lAppVersion.AutoSize = true;
            this.lAppVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lAppVersion.Location = new System.Drawing.Point(204, 57);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(44, 16);
            this.lAppVersion.TabIndex = 21;
            this.lAppVersion.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(147, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Verzia:";
            // 
            // lAppName
            // 
            this.lAppName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lAppName.AutoSize = true;
            this.lAppName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lAppName.Location = new System.Drawing.Point(147, 23);
            this.lAppName.Name = "lAppName";
            this.lAppName.Size = new System.Drawing.Size(69, 16);
            this.lAppName.TabIndex = 19;
            this.lAppName.Text = "AppName";
            // 
            // picIcon
            // 
            this.picIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picIcon.Location = new System.Drawing.Point(15, 14);
            this.picIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(99, 89);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 18;
            this.picIcon.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(19, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Web:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(19, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "E-mail:";
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkWeb.Location = new System.Drawing.Point(73, 27);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(89, 16);
            this.linkWeb.TabIndex = 12;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "gvdeditorweb";
            this.linkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnWebLinkClicked);
            // 
            // linkEmail
            // 
            this.linkEmail.AutoSize = true;
            this.linkEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkEmail.Location = new System.Drawing.Point(73, 52);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(40, 16);
            this.linkEmail.TabIndex = 14;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "email";
            this.linkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnEmailLinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lText);
            this.groupBox2.Location = new System.Drawing.Point(13, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(357, 123);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charakteristika programu";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.linkWeb);
            this.groupBox1.Controls.Add(this.linkEmail);
            this.groupBox1.Location = new System.Drawing.Point(13, 236);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(357, 81);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informácie";
            // 
            // bOK
            // 
            this.bOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOK.AutoSize = true;
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bOK.Location = new System.Drawing.Point(151, 329);
            this.bOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 33);
            this.bOK.TabIndex = 22;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // FAboutApp
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 375);
            this.Controls.Add(this.lAppVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lAppName);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bOK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 414);
            this.Name = "FAboutApp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FAboutApp";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OnHelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lText;
        private Label lAppVersion;
        private Label label2;
        private Label lAppName;
        private PictureBox picIcon;
        private Label label7;
        private Label label8;
        private LinkLabel linkWeb;
        private LinkLabel linkEmail;
        private ExGroupBox groupBox2;
        private ExGroupBox groupBox1;
        private ExButton bOK;
    }
}