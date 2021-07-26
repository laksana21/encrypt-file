using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSecSafe
{
    public partial class MainForm : Form
    {
        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter = "All files (*.*)|*.*";

            // Allow the user to select multiple images.
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select Files";
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Models.AboutData about = new Models.AboutData();
            string ab = about.getAboutData();
            MessageBox.Show(ab.ToString(), "About" , MessageBoxButtons.OK);
        }

        private void btnMainAddFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();
            Stream myStream;

            if (dr == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {
                    try
                    {
                        if ((myStream = openFileDialog1.OpenFile()) != null)
                        {
                            using (myStream)
                            {lvFileList.Items.Add(file);}
                        }
                    }

                    catch (Exception ex)
                    {MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);}
                }
            }
        }

        private void lvFileList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (lvFileList.SelectedItems.Count > 0)
                {
                    var confirmation = MessageBox.Show("Are you sure want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmation == DialogResult.Yes)
                    {
                        for (int i = lvFileList.SelectedItems.Count - 1; i >= 0; i--)
                        {
                            ListViewItem itm = lvFileList.SelectedItems[i];
                            lvFileList.Items[itm.Index].Remove();
                        }
                    }
                }
            }
        }

        private void btnMainClearFiles_Click(object sender, EventArgs e)
        {
            if (lvFileList.Items.Count > 0)
            {
                var confirmation = MessageBox.Show("Are you sure want to clear this list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    lvFileList.Items.Clear();
                    btnMainAddFiles.Focus();
                }
            }
        }

        private void btnMainEncFiles_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "EncryptForm")
                {
                    bFormNameOpen = true;
                }
            }

            List<string> fileList = new List<string>();
            int chkList = lvFileList.Items.Count;

            if (chkList > 0)
            {
                for (int i = 0; i < chkList; i++)
                {
                    fileList.Add(lvFileList.Items[i].Text);
                }

                EncryptForm encrypt = new EncryptForm(fileList, chkList);
                if(bFormNameOpen == false)
                {
                    encrypt.Show();
                }
            }
            else
            {
                MessageBox.Show("Please add your file at least one!", "File empty", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnMainAddFiles.Focus();
            }
        }

        private void btnMainDecFiles_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool bFormNameOpen = false;

            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "DecryptForm")
                {
                    bFormNameOpen = true;
                }
            }

            if(bFormNameOpen == false)
            {
                DecryptForm decrypt = new DecryptForm();
                decrypt.Show();
            }
        }
    }
}
