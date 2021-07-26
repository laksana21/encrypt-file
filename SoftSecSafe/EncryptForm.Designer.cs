namespace SoftSecSafe
{
    partial class EncryptForm
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
            this.lbProgress = new System.Windows.Forms.Label();
            this.pbEncryptFile = new System.Windows.Forms.ProgressBar();
            this.btnEncStartEnc = new System.Windows.Forms.Button();
            this.gbEncPassword = new System.Windows.Forms.GroupBox();
            this.lbRepPassword = new System.Windows.Forms.Label();
            this.txtEncRepPassword = new System.Windows.Forms.TextBox();
            this.txtEncMainPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.gbEncFileDest = new System.Windows.Forms.GroupBox();
            this.btnEncBrowse = new System.Windows.Forms.Button();
            this.txtEncDestination = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.gbEncPassword.SuspendLayout();
            this.gbEncFileDest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbProgress);
            this.panel1.Controls.Add(this.pbEncryptFile);
            this.panel1.Controls.Add(this.btnEncStartEnc);
            this.panel1.Controls.Add(this.gbEncPassword);
            this.panel1.Controls.Add(this.gbEncFileDest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 244);
            this.panel1.TabIndex = 0;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Location = new System.Drawing.Point(12, 217);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(38, 13);
            this.lbProgress.TabIndex = 4;
            this.lbProgress.Text = "Ready";
            // 
            // pbEncryptFile
            // 
            this.pbEncryptFile.Location = new System.Drawing.Point(13, 183);
            this.pbEncryptFile.Name = "pbEncryptFile";
            this.pbEncryptFile.Size = new System.Drawing.Size(359, 23);
            this.pbEncryptFile.TabIndex = 3;
            // 
            // btnEncStartEnc
            // 
            this.btnEncStartEnc.Location = new System.Drawing.Point(284, 212);
            this.btnEncStartEnc.Name = "btnEncStartEnc";
            this.btnEncStartEnc.Size = new System.Drawing.Size(88, 23);
            this.btnEncStartEnc.TabIndex = 2;
            this.btnEncStartEnc.Text = "START";
            this.btnEncStartEnc.UseVisualStyleBackColor = true;
            this.btnEncStartEnc.Click += new System.EventHandler(this.btnEncStartEnc_Click);
            // 
            // gbEncPassword
            // 
            this.gbEncPassword.Controls.Add(this.lbRepPassword);
            this.gbEncPassword.Controls.Add(this.txtEncRepPassword);
            this.gbEncPassword.Controls.Add(this.txtEncMainPassword);
            this.gbEncPassword.Controls.Add(this.lbPassword);
            this.gbEncPassword.Location = new System.Drawing.Point(13, 98);
            this.gbEncPassword.Name = "gbEncPassword";
            this.gbEncPassword.Size = new System.Drawing.Size(359, 78);
            this.gbEncPassword.TabIndex = 1;
            this.gbEncPassword.TabStop = false;
            this.gbEncPassword.Text = "Password Information";
            // 
            // lbRepPassword
            // 
            this.lbRepPassword.AutoSize = true;
            this.lbRepPassword.Location = new System.Drawing.Point(6, 50);
            this.lbRepPassword.Name = "lbRepPassword";
            this.lbRepPassword.Size = new System.Drawing.Size(91, 13);
            this.lbRepPassword.TabIndex = 3;
            this.lbRepPassword.Text = "Repeat Password";
            // 
            // txtEncRepPassword
            // 
            this.txtEncRepPassword.Location = new System.Drawing.Point(97, 47);
            this.txtEncRepPassword.Name = "txtEncRepPassword";
            this.txtEncRepPassword.Size = new System.Drawing.Size(256, 20);
            this.txtEncRepPassword.TabIndex = 2;
            // 
            // txtEncMainPassword
            // 
            this.txtEncMainPassword.Location = new System.Drawing.Point(97, 20);
            this.txtEncMainPassword.Name = "txtEncMainPassword";
            this.txtEncMainPassword.Size = new System.Drawing.Size(256, 20);
            this.txtEncMainPassword.TabIndex = 1;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(6, 23);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // gbEncFileDest
            // 
            this.gbEncFileDest.Controls.Add(this.btnEncBrowse);
            this.gbEncFileDest.Controls.Add(this.txtEncDestination);
            this.gbEncFileDest.Location = new System.Drawing.Point(13, 12);
            this.gbEncFileDest.Name = "gbEncFileDest";
            this.gbEncFileDest.Size = new System.Drawing.Size(359, 79);
            this.gbEncFileDest.TabIndex = 0;
            this.gbEncFileDest.TabStop = false;
            this.gbEncFileDest.Text = "Destination";
            // 
            // btnEncBrowse
            // 
            this.btnEncBrowse.Location = new System.Drawing.Point(278, 46);
            this.btnEncBrowse.Name = "btnEncBrowse";
            this.btnEncBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnEncBrowse.TabIndex = 1;
            this.btnEncBrowse.Text = "Browse";
            this.btnEncBrowse.UseVisualStyleBackColor = true;
            this.btnEncBrowse.Click += new System.EventHandler(this.btnEncBrowse_Click);
            // 
            // txtEncDestination
            // 
            this.txtEncDestination.Location = new System.Drawing.Point(7, 20);
            this.txtEncDestination.Name = "txtEncDestination";
            this.txtEncDestination.Size = new System.Drawing.Size(346, 20);
            this.txtEncDestination.TabIndex = 0;
            // 
            // EncryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 244);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt Files";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEncPassword.ResumeLayout(false);
            this.gbEncPassword.PerformLayout();
            this.gbEncFileDest.ResumeLayout(false);
            this.gbEncFileDest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEncStartEnc;
        private System.Windows.Forms.GroupBox gbEncPassword;
        private System.Windows.Forms.Label lbRepPassword;
        private System.Windows.Forms.TextBox txtEncRepPassword;
        private System.Windows.Forms.TextBox txtEncMainPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.GroupBox gbEncFileDest;
        private System.Windows.Forms.Button btnEncBrowse;
        private System.Windows.Forms.TextBox txtEncDestination;
        private System.Windows.Forms.ProgressBar pbEncryptFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbProgress;
    }
}