namespace SoftSecSafe
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openEncryptedPackageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.encryptFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnMainIcons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMainClearFiles = new System.Windows.Forms.Button();
            this.btnMainAddFiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMainDecText = new System.Windows.Forms.Button();
            this.btnMainEncText = new System.Windows.Forms.Button();
            this.btnMainDecFiles = new System.Windows.Forms.Button();
            this.btnMainEncFiles = new System.Windows.Forms.Button();
            this.lbMainCredit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvFileList = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.pnMainIcons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "msMainWindows";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilesToolStripMenuItem,
            this.openEncryptedPackageToolStripMenuItem,
            this.toolStripSeparator1,
            this.encryptFilesToolStripMenuItem,
            this.decryptFileToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addFilesToolStripMenuItem.Text = "Add Files";
            // 
            // openEncryptedPackageToolStripMenuItem
            // 
            this.openEncryptedPackageToolStripMenuItem.Name = "openEncryptedPackageToolStripMenuItem";
            this.openEncryptedPackageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openEncryptedPackageToolStripMenuItem.Text = "Clear Files";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // encryptFilesToolStripMenuItem
            // 
            this.encryptFilesToolStripMenuItem.Name = "encryptFilesToolStripMenuItem";
            this.encryptFilesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.encryptFilesToolStripMenuItem.Text = "Encrypt Files";
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.decryptFileToolStripMenuItem.Text = "Decrypt File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.logToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // pnMainIcons
            // 
            this.pnMainIcons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMainIcons.AutoSize = true;
            this.pnMainIcons.BackColor = System.Drawing.Color.LightGray;
            this.pnMainIcons.Controls.Add(this.panel3);
            this.pnMainIcons.Controls.Add(this.panel1);
            this.pnMainIcons.Location = new System.Drawing.Point(0, 28);
            this.pnMainIcons.Name = "pnMainIcons";
            this.pnMainIcons.Size = new System.Drawing.Size(810, 90);
            this.pnMainIcons.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMainClearFiles);
            this.panel3.Controls.Add(this.btnMainAddFiles);
            this.panel3.Location = new System.Drawing.Point(12, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 83);
            this.panel3.TabIndex = 5;
            // 
            // btnMainClearFiles
            // 
            this.btnMainClearFiles.Image = global::SoftSecSafe.Properties.Resources.pngfind_com_trash_bin_png_3150102;
            this.btnMainClearFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainClearFiles.Location = new System.Drawing.Point(87, 4);
            this.btnMainClearFiles.Name = "btnMainClearFiles";
            this.btnMainClearFiles.Size = new System.Drawing.Size(76, 76);
            this.btnMainClearFiles.TabIndex = 1;
            this.btnMainClearFiles.Text = "Clear Files";
            this.btnMainClearFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainClearFiles.UseVisualStyleBackColor = true;
            this.btnMainClearFiles.Click += new System.EventHandler(this.btnMainClearFiles_Click);
            // 
            // btnMainAddFiles
            // 
            this.btnMainAddFiles.Image = global::SoftSecSafe.Properties.Resources.pngfind_com_search_icon_png_545811;
            this.btnMainAddFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainAddFiles.Location = new System.Drawing.Point(4, 4);
            this.btnMainAddFiles.Name = "btnMainAddFiles";
            this.btnMainAddFiles.Size = new System.Drawing.Size(76, 76);
            this.btnMainAddFiles.TabIndex = 0;
            this.btnMainAddFiles.Text = "Add Files";
            this.btnMainAddFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainAddFiles.UseVisualStyleBackColor = true;
            this.btnMainAddFiles.Click += new System.EventHandler(this.btnMainAddFiles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMainDecText);
            this.panel1.Controls.Add(this.btnMainEncText);
            this.panel1.Controls.Add(this.btnMainDecFiles);
            this.panel1.Controls.Add(this.btnMainEncFiles);
            this.panel1.Location = new System.Drawing.Point(187, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 83);
            this.panel1.TabIndex = 4;
            // 
            // btnMainDecText
            // 
            this.btnMainDecText.Image = ((System.Drawing.Image)(resources.GetObject("btnMainDecText.Image")));
            this.btnMainDecText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainDecText.Location = new System.Drawing.Point(250, 4);
            this.btnMainDecText.Name = "btnMainDecText";
            this.btnMainDecText.Size = new System.Drawing.Size(76, 76);
            this.btnMainDecText.TabIndex = 3;
            this.btnMainDecText.Text = "Decrypt Text";
            this.btnMainDecText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainDecText.UseVisualStyleBackColor = true;
            // 
            // btnMainEncText
            // 
            this.btnMainEncText.Image = ((System.Drawing.Image)(resources.GetObject("btnMainEncText.Image")));
            this.btnMainEncText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainEncText.Location = new System.Drawing.Point(168, 4);
            this.btnMainEncText.Name = "btnMainEncText";
            this.btnMainEncText.Size = new System.Drawing.Size(76, 76);
            this.btnMainEncText.TabIndex = 2;
            this.btnMainEncText.Text = "Encrypt Text";
            this.btnMainEncText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainEncText.UseVisualStyleBackColor = true;
            // 
            // btnMainDecFiles
            // 
            this.btnMainDecFiles.Image = global::SoftSecSafe.Properties.Resources.File_Unlock_icon;
            this.btnMainDecFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainDecFiles.Location = new System.Drawing.Point(86, 4);
            this.btnMainDecFiles.Name = "btnMainDecFiles";
            this.btnMainDecFiles.Size = new System.Drawing.Size(76, 76);
            this.btnMainDecFiles.TabIndex = 1;
            this.btnMainDecFiles.Text = "Decrypt File";
            this.btnMainDecFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainDecFiles.UseVisualStyleBackColor = true;
            this.btnMainDecFiles.Click += new System.EventHandler(this.btnMainDecFiles_Click);
            // 
            // btnMainEncFiles
            // 
            this.btnMainEncFiles.Image = global::SoftSecSafe.Properties.Resources.File_Lock_icon;
            this.btnMainEncFiles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMainEncFiles.Location = new System.Drawing.Point(4, 4);
            this.btnMainEncFiles.Name = "btnMainEncFiles";
            this.btnMainEncFiles.Size = new System.Drawing.Size(76, 76);
            this.btnMainEncFiles.TabIndex = 0;
            this.btnMainEncFiles.Text = "Encrypt Files";
            this.btnMainEncFiles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMainEncFiles.UseVisualStyleBackColor = true;
            this.btnMainEncFiles.Click += new System.EventHandler(this.btnMainEncFiles_Click);
            // 
            // lbMainCredit
            // 
            this.lbMainCredit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMainCredit.AutoSize = true;
            this.lbMainCredit.Location = new System.Drawing.Point(12, 436);
            this.lbMainCredit.Name = "lbMainCredit";
            this.lbMainCredit.Size = new System.Drawing.Size(101, 13);
            this.lbMainCredit.TabIndex = 2;
            this.lbMainCredit.Text = "© 2020 Join Project";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lvFileList);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 307);
            this.panel2.TabIndex = 3;
            // 
            // lvFileList
            // 
            this.lvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFileList.Location = new System.Drawing.Point(0, 0);
            this.lvFileList.Name = "lvFileList";
            this.lvFileList.Size = new System.Drawing.Size(786, 307);
            this.lvFileList.TabIndex = 0;
            this.lvFileList.UseCompatibleStateImageBehavior = false;
            this.lvFileList.View = System.Windows.Forms.View.List;
            this.lvFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvFileList_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 456);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbMainCredit);
            this.Controls.Add(this.pnMainIcons);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(826, 495);
            this.Name = "MainForm";
            this.Text = "SoftSec Safe Box Encryption";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnMainIcons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnMainIcons;
        private System.Windows.Forms.Label lbMainCredit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMainDecText;
        private System.Windows.Forms.Button btnMainEncText;
        private System.Windows.Forms.Button btnMainDecFiles;
        private System.Windows.Forms.Button btnMainEncFiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvFileList;
        private System.Windows.Forms.ToolStripMenuItem addFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openEncryptedPackageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem encryptFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMainClearFiles;
        private System.Windows.Forms.Button btnMainAddFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}

