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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lText
            // 
            this.lText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lText.Location = new System.Drawing.Point(2, 15);
            this.lText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lText.Name = "lText";
            this.lText.Padding = new System.Windows.Forms.Padding(5);
            this.lText.Size = new System.Drawing.Size(262, 70);
            this.lText.TabIndex = 0;
            this.lText.Text = "\r\n";
            // 
            // lAppVersion
            // 
            this.lAppVersion.AutoSize = true;
            this.lAppVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lAppVersion.Location = new System.Drawing.Point(169, 39);
            this.lAppVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(40, 13);
            this.lAppVersion.TabIndex = 2;
            this.lAppVersion.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(126, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verzia:";
            // 
            // lAppName
            // 
            this.lAppName.AutoSize = true;
            this.lAppName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lAppName.Location = new System.Drawing.Point(126, 11);
            this.lAppName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAppName.Name = "lAppName";
            this.lAppName.Size = new System.Drawing.Size(54, 13);
            this.lAppName.TabIndex = 0;
            this.lAppName.Text = "AppName";
            // 
            // picIcon
            // 
            this.picIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picIcon.Location = new System.Drawing.Point(11, 11);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(74, 72);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 18;
            this.picIcon.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Web:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(14, 42);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "E-mail:";
            // 
            // linkWeb
            // 
            this.linkWeb.AutoSize = true;
            this.linkWeb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkWeb.Location = new System.Drawing.Point(55, 22);
            this.linkWeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkWeb.Name = "linkWeb";
            this.linkWeb.Size = new System.Drawing.Size(27, 13);
            this.linkWeb.TabIndex = 1;
            this.linkWeb.TabStop = true;
            this.linkWeb.Text = "web";
            this.linkWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnWebLinkClicked);
            // 
            // linkEmail
            // 
            this.linkEmail.AutoSize = true;
            this.linkEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkEmail.Location = new System.Drawing.Point(55, 42);
            this.linkEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(31, 13);
            this.linkEmail.TabIndex = 3;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "email";
            this.linkEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnEmailLinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lText);
            this.groupBox2.Location = new System.Drawing.Point(11, 104);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charakteristika programu";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.linkWeb);
            this.groupBox1.Controls.Add(this.linkEmail);
            this.groupBox1.Location = new System.Drawing.Point(11, 195);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 72);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informácie";
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.AutoSize = true;
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bOK.Location = new System.Drawing.Point(211, 271);
            this.bOK.Margin = new System.Windows.Forms.Padding(2);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(66, 23);
            this.bOK.TabIndex = 5;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Controls.Add(this.lAppVersion);
            this.panel1.Controls.Add(this.bOK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lAppName);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(288, 305);
            this.panel1.TabIndex = 0;
            // 
            // FAboutApp
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(288, 305);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(637, 493);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(304, 344);
            this.Name = "FAboutApp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Informácie o programe";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OnHelpButtonClicked);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private Panel panel1;
    }
}