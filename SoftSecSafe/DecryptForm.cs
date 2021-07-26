using System;
using System.IO;
using System.Collections.Generic;
using SoftSecSafe.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSecSafe
{
    public partial class DecryptForm : Form
    {
        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            openFileDialog1.Filter = "Supported Files (*.sfb;)|*.sfb;";

            // Allow the user to select multiple images.
            openFileDialog1.Multiselect = false;
            openFileDialog1.Title = "Select Files";
            openFileDialog1.FilterIndex = 2;
        }

        private void InitializePasswordBox()
        {
            tbDecPassInput.PasswordChar = '*';
            tbDecPassInput.MaxLength = 14;
        }

        public DecryptForm()
        {
            InitializeComponent();
            InitializeOpenFileDialog();
            InitializePasswordBox();
        }

        private void btnEncSearch_Click(object sender, EventArgs e)
        {
            DialogResult open = openFileDialog1.ShowDialog();
            if(open == DialogResult.OK)
            {
                tbDecFileLoc.Text = openFileDialog1.FileName;
                openFileDialog1.Dispose();
            }
        }

        private void btnDecDestination_Click(object sender, EventArgs e)
        {
            DialogResult dest = folderBrowserDialog1.ShowDialog();

            if(dest == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                tbDestFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DecryptFile(string file, string destination, string password)
        {
            KeyHouse keyh = new KeyHouse();
            string pass = "";
            int seed = 0;
            List<string> nameList = new List<string>();
            List<byte[]> dataList = new List<byte[]>();

            try
            {
                string path = file.ToString();
                byte[] buff = null;
                nameList.Add(Path.GetFileName(path));
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                long numBytes = new FileInfo(path).Length;
                buff = br.ReadBytes((int)numBytes);

                MemoryStream ms = new MemoryStream(buff);
                using (BsonDataReader reader = new BsonDataReader(ms))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    SafeMode e = serializer.Deserialize<SafeMode>(reader);

                    nameList = e.FileList;
                    dataList = e.DataList;
                    pass = e.Main;
                    seed = e.Seed;
                }

                if(pass == keyh.HashGenerator(password))
                {
                    for (int i = 0; i < nameList.Count(); i++)
                    {
                        string dest = destination + nameList[i];
                        byte[] filedata = dataList[i];
                        byte[] plain = filedata;

                        for (int j = 0; j < Buffer.ByteLength(filedata); j++)
                        {
                            byte key = Convert.ToByte(seed);
                            plain[j] = (byte)(plain[j] ^ key);
                            seed = keyh.randomGenerator(seed, 5, 47);
                        }

                        File.WriteAllBytes(dest, filedata);
                    }

                    MessageBox.Show("All files has been decrypted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong password", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbDecPassInput.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Decryption failed with error : " + e.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDecStart_Click(object sender, EventArgs e)
        {
            string chipp = tbDecFileLoc.Text;
            string dest = tbDestFolder.Text;
            string pass = tbDecPassInput.Text;

            if(chipp != "")
            {
                if(dest != "")
                {
                    if(pass != "")
                    {
                        DecryptFile(chipp, dest, pass);
                    }
                    else
                    {
                        MessageBox.Show("Password empty!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbDecPassInput.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Select destination files!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnDecDestination.Focus();
                }
            }
            else
            {
                MessageBox.Show("Select encrypted file first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDecSearch.Focus();
            }
        }

    }
}
