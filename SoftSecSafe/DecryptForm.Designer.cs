namespace SoftSecSafe
{
    partial class DecryptForm
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
            this.tbDecFileLoc = new System.Windows.Forms.TextBox();
            this.btnDecSearch = new System.Windows.Forms.Button();
            this.tbDecPassInput = new System.Windows.Forms.TextBox();
            this.btnDecStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbDecFileLoc = new System.Windows.Forms.GroupBox();
            this.gbDecPassword = new System.Windows.Forms.GroupBox();
            this.btnDecDestination = new System.Windows.Forms.Button();
            this.lbDecFileLoc = new System.Windows.Forms.Label();
            this.tbDestFolder = new System.Windows.Forms.TextBox();
            this.lbDecDestFile = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.gbDecFileLoc.SuspendLayout();
            this.gbDecPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDecStart);
            this.panel1.Controls.Add(this.gbDecPassword);
            this.panel1.Controls.Add(this.gbDecFileLoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 193);
            this.panel1.TabIndex = 0;
            // 
            // tbDecFileLoc
            // 
            this.tbDecFileLoc.Location = new System.Drawing.Point(86, 20);
            this.tbDecFileLoc.Name = "tbDecFileLoc";
            this.tbDecFileLoc.Size = new System.Drawing.Size(239, 20);
            this.tbDecFileLoc.TabIndex = 0;
            // 
            // btnDecSearch
            // 
            this.btnDecSearch.Location = new System.Drawing.Point(331, 18);
            this.btnDecSearch.Name = "btnDecSearch";
            this.btnDecSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDecSearch.TabIndex = 1;
            this.btnDecSearch.Text = "Open File";
            this.btnDecSearch.UseVisualStyleBackColor = true;
            this.btnDecSearch.Click += new System.EventHandler(this.btnEncSearch_Click);
            // 
            // tbDecPassInput
            // 
            this.tbDecPassInput.Location = new System.Drawing.Point(7, 20);
            this.tbDecPassInput.Name = "tbDecPassInput";
            this.tbDecPassInput.Size = new System.Drawing.Size(399, 20);
            this.tbDecPassInput.TabIndex = 0;
            // 
            // btnDecStart
            // 
            this.btnDecStart.Location = new System.Drawing.Point(350, 160);
            this.btnDecStart.Name = "btnDecStart";
            this.btnDecStart.Size = new System.Drawing.Size(75, 23);
            this.btnDecStart.TabIndex = 2;
            this.btnDecStart.Text = "START";
            this.btnDecStart.UseVisualStyleBackColor = true;
            this.btnDecStart.Click += new System.EventHandler(this.btnDecStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbDecFileLoc
            // 
            this.gbDecFileLoc.Controls.Add(this.lbDecDestFile);
            this.gbDecFileLoc.Controls.Add(this.tbDestFolder);
            this.gbDecFileLoc.Controls.Add(this.lbDecFileLoc);
            this.gbDecFileLoc.Controls.Add(this.btnDecDestination);
            this.gbDecFileLoc.Controls.Add(this.btnDecSearch);
            this.gbDecFileLoc.Controls.Add(this.tbDecFileLoc);
            this.gbDecFileLoc.Location = new System.Drawing.Point(13, 13);
            this.gbDecFileLoc.Name = "gbDecFileLoc";
            this.gbDecFileLoc.Size = new System.Drawing.Size(412, 81);
            this.gbDecFileLoc.TabIndex = 0;
            this.gbDecFileLoc.TabStop = false;
            this.gbDecFileLoc.Text = "File Location";
            // 
            // gbDecPassword
            // 
            this.gbDecPassword.Controls.Add(this.tbDecPassInput);
            this.gbDecPassword.Location = new System.Drawing.Point(13, 101);
            this.gbDecPassword.Name = "gbDecPassword";
            this.gbDecPassword.Size = new System.Drawing.Size(412, 53);
            this.gbDecPassword.TabIndex = 1;
            this.gbDecPassword.TabStop = false;
            this.gbDecPassword.Text = "Password";
            // 
            // btnDecDestination
            // 
            this.btnDecDestination.Location = new System.Drawing.Point(331, 47);
            this.btnDecDestination.Name = "btnDecDestination";
            this.btnDecDestination.Size = new System.Drawing.Size(75, 23);
            this.btnDecDestination.TabIndex = 2;
            this.btnDecDestination.Text = "Search";
            this.btnDecDestination.UseVisualStyleBackColor = true;
            this.btnDecDestination.Click += new System.EventHandler(this.btnDecDestination_Click);
            // 
            // lbDecFileLoc
            // 
            this.lbDecFileLoc.AutoSize = true;
            this.lbDecFileLoc.Location = new System.Drawing.Point(6, 23);
            this.lbDecFileLoc.Name = "lbDecFileLoc";
            this.lbDecFileLoc.Size = new System.Drawing.Size(74, 13);
            this.lbDecFileLoc.TabIndex = 3;
            this.lbDecFileLoc.Text = "Encrypted File";
            // 
            // tbDestFolder
            // 
            this.tbDestFolder.Location = new System.Drawing.Point(86, 49);
            this.tbDestFolder.Name = "tbDestFolder";
            this.tbDestFolder.Size = new System.Drawing.Size(239, 20);
            this.tbDestFolder.TabIndex = 4;
            // 
            // lbDecDestFile
            // 
            this.lbDecDestFile.AutoSize = true;
            this.lbDecDestFile.Location = new System.Drawing.Point(6, 52);
            this.lbDecDestFile.Name = "lbDecDestFile";
            this.lbDecDestFile.Size = new System.Drawing.Size(60, 13);
            this.lbDecDestFile.TabIndex = 5;
            this.lbDecDestFile.Text = "Destination";
            // 
            // DecryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 193);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DecryptForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypt File";
            this.panel1.ResumeLayout(false);
            this.gbDecFileLoc.ResumeLayout(false);
            this.gbDecFileLoc.PerformLayout();
            this.gbDecPassword.ResumeLayout(false);
            this.gbDecPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDecSearch;
        private System.Windows.Forms.TextBox tbDecFileLoc;
        private System.Windows.Forms.Button btnDecStart;
        private System.Windows.Forms.TextBox tbDecPassInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbDecPassword;
        private System.Windows.Forms.GroupBox gbDecFileLoc;
        private System.Windows.Forms.Label lbDecDestFile;
        private System.Windows.Forms.TextBox tbDestFolder;
        private System.Windows.Forms.Label lbDecFileLoc;
        private System.Windows.Forms.Button btnDecDestination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}