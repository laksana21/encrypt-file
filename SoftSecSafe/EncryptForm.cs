using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using SoftSecSafe.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftSecSafe
{
    public partial class EncryptForm : Form
    {
        private List<string> filelist = new List<string>();
        private int fileTotal;

        private void InitializeSaveFileDialog()
        {
            saveFileDialog1.Filter = "Safe File|*.sfb";
            saveFileDialog1.Title = "Save an Encrypted File";
            saveFileDialog1.RestoreDirectory = true;
        }

        private void InitializePasswordBox()
        {
            txtEncMainPassword.PasswordChar = '*';
            txtEncRepPassword.PasswordChar = '*';

            txtEncMainPassword.MaxLength = 14;
            txtEncRepPassword.MaxLength = 14;
        }

        public EncryptForm(List<string> list, int count)
        {
            InitializeComponent();
            InitializeSaveFileDialog();
            InitializePasswordBox();

            filelist = list;
            fileTotal = count;
        }

        private void btnEncBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                txtEncDestination.Text = saveFileDialog1.FileName;
            }
        }

        private void EncryptFile(List<string> list, string destination, string meta, string mainpass)
        {
            KeyHouse keyh = new KeyHouse();
            string pass = keyh.HashGenerator(mainpass);
            
            MemoryStream ms = new MemoryStream();
            List<string> nameList = new List<string>();
            List<byte[]> fileList = new List<byte[]>();
            string path = "";

            int seed = keyh.GetSecretKey();

            try
            {
                foreach (var lst in list)
                {
                    path = lst.ToString();
                    byte[] buff = null;
                    nameList.Add(Path.GetFileName(path));
                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                    BinaryReader br = new BinaryReader(fs);
                    long numBytes = new FileInfo(path).Length;
                    buff = br.ReadBytes((int)numBytes);
                    byte[] chpp = buff;

                    for (int i = 0; i < Buffer.ByteLength(buff); i++)
                    {
                        byte key = Convert.ToByte(seed);
                        chpp[i] = (byte)(chpp[i] ^ key);
                        seed = keyh.randomGenerator(seed, 5, 47);
                    }

                    fileList.Add(chpp);
                    fs.Close();
                }

                SafeMode safe = new SafeMode
                {
                    MetaKey = meta,
                    Main = pass,
                    FileList = nameList,
                    DataList = fileList,
                    Seed = keyh.GetSecretKey()
                };

                using (BsonDataWriter writer = new BsonDataWriter(ms))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(writer, safe);
                }

                byte[] otp = ms.ToArray();
                File.WriteAllBytes(destination, otp);

                lbProgress.Text = "Done!";
                MessageBox.Show("All files has been encrypted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                lbProgress.Text = "Error!";
                MessageBox.Show("Encryption failed with error : " + e.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEncStartEnc_Click(object sender, EventArgs e)
        {
            string dest = txtEncDestination.Text;
            string pass1 = txtEncMainPassword.Text;
            string pass2 = txtEncRepPassword.Text;
            string meta = Convert.ToString((int)DateTime.Now.Ticks);

            if (dest != "")
            {
                if(pass1 != "" && pass1.Length >= 6)
                {
                    if(pass1 == pass2)
                    {
                        EncryptFile(filelist, dest, meta, pass1);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Re-type password doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Type password at least 6 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Choose the destination first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
