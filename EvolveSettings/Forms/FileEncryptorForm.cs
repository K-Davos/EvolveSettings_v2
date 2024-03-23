using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class FileEncryptorForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FileEncryptorForm()
        {
            InitializeComponent();

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }

            txtEncryptorPass.Enabled = false;
            txtEncryptorRepass.Enabled = false;
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region wintheme
        public bool IsDarkTheme()
        {
            bool is_light_mode = true;
            try
            {
                var v = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
                if (v != null && v.ToString() == "0")
                    is_light_mode = false;
            }
            catch { }
            return is_light_mode;
        }
        private void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            var isDarkorLight = IsDarkTheme();
            if (isDarkorLight)
            {
                //light
                this.BackColor = SystemColors.Control;
                panel3.BackColor = themeColor;
                pnlFiles.FillColor = Color.White;
                pnlFolders.FillColor = Color.White;
                pnlEncryptDecrypt.FillColor = Color.White;
                listBoxFile.BackColor = Color.White;
                listBoxFile.ForeColor = Color.Black;
                listBoxFolder.BackColor = Color.White;
                listBoxFolder.ForeColor = Color.Black;
                pnlHeader.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.pnlEncryptDecrypt.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                }
                lblFiles.ForeColor = Color.Black;
                lblFilesAndFolders.ForeColor = ColorTranslator.FromHtml("#212121");
                lblEncryptDecrypt.ForeColor = ColorTranslator.FromHtml("#212121");
                btnClose.ForeColor = Color.Black;
                lblAddUpdateUser.ForeColor = Color.Black;
                lblEditPassword.ForeColor = Color.Black;
                lblEditRepass.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel3.BackColor = themeColor;
                pnlFiles.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlFolders.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlEncryptDecrypt.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                listBoxFile.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                listBoxFile.ForeColor = Color.White;
                listBoxFolder.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                listBoxFolder.ForeColor = Color.White;
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                foreach (Guna2TextBox txtbox in this.pnlEncryptDecrypt.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
                lblFiles.ForeColor = Color.White;
                lblFilesAndFolders.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblEncryptDecrypt.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                btnClose.ForeColor = Color.White;
                lblAddUpdateUser.ForeColor = Color.White;
                lblEditPassword.ForeColor = Color.White;
                lblEditRepass.ForeColor = Color.White;
            }
            chkEncryptorShowPass.CheckedState.FillColor = themeColor;
            foreach (Guna2Button button in this.pnlFiles.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlFolders.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlEncryptDecrypt.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }
        #endregion wintheme

        private void chkEncryptorShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEncryptorShowPass.Checked)
            {
                txtEncryptorPass.PasswordChar = '\0';
                txtEncryptorRepass.PasswordChar = '\0';
            }
            else
            {
                txtEncryptorPass.PasswordChar = '*';
                txtEncryptorRepass.PasswordChar = '*';
            }
        }

        private void txtEncryptorPass_TextChanged(object sender, EventArgs e)
        {
            if (txtEncryptorPass.Text.Length > 1)
            {
                txtEncryptorRepass.Enabled = true;
                timer1.Start();
            }
            if (txtEncryptorPass.Text.Length < 1)
            {
                txtEncryptorRepass.Enabled = false;
                timer1.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region encryptor
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //Add files
            OpenFileDialog filepath = new OpenFileDialog();
            filepath.Title = "Select File";
            filepath.InitialDirectory = @"C:\";
            filepath.Filter = "All files (*.*)|*.*";
            filepath.Multiselect = true;
            filepath.FilterIndex = 1;
            filepath.ShowDialog();
            foreach (String file in filepath.FileNames)
            {
                listBoxFile.Items.Add(file); //add file path to the listbox
            }
            txtEncryptorPass.Enabled = true;
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            //Add folders
            FolderBrowserDialog folderpath = new FolderBrowserDialog();
            folderpath.ShowDialog();
            listBoxFolder.Items.Add(folderpath.SelectedPath);
            txtEncryptorPass.Enabled = true;
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            txtEncryptorPass.Enabled = false;
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            listBoxFile.Items.Clear();
        }

        private void btnClearFolder_Click(object sender, EventArgs e)
        {
            listBoxFolder.Items.Clear();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBoxFile.Items.Clear();
            listBoxFolder.Items.Clear();
            txtEncryptorPass.Clear();
            txtEncryptorRepass.Clear();
            txtEncryptorPass.Enabled = false;
            txtEncryptorRepass.Enabled = false;
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //This function will encrypt selected files
            if (txtEncryptorPass.Text != txtEncryptorRepass.Text)
            {
                EvolveMessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEncryptorPass.Text.Length < 8)
            {
                EvolveMessageBox.Show("Password must have 8 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Selected files
            if (listBoxFile.Items.Count > 0)
            {
                for (int num = 0; num < listBoxFile.Items.Count; num++)
                {
                    string e_file = "" + listBoxFile.Items[num];
                    if (!e_file.Trim().EndsWith(".!LOCKED") && File.Exists(e_file))
                    {
                        EncryptFile("" + listBoxFile.Items[num], "" + listBoxFile.Items[num] + ".!LOCKED", txtEncryptorPass.Text);
                        File.Delete("" + listBoxFile.Items[num]);
                    }
                }
                EvolveMessageBox.Show("Your File(s) have been successfully encrypted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxFile.Items.Clear();
                listBoxFolder.Items.Clear();
                txtEncryptorPass.Clear();
                txtEncryptorRepass.Clear();
            }
            //Selected folders
            if (listBoxFolder.Items.Count > 0)
            {
                for (int num = 0; num < listBoxFolder.Items.Count; num++)
                {
                    string d_file = "" + listBoxFolder.Items[num];
                    string[] get_files = Directory.GetFiles(d_file);
                    foreach (string name_file in get_files)
                    {
                        if (!name_file.Trim().EndsWith(".!LOCKED") && File.Exists(name_file))
                        {
                            EncryptFile(name_file, name_file + ".!LOCKED", txtEncryptorPass.Text);
                            File.Delete(name_file);
                        }
                    }
                    EvolveMessageBox.Show("Your File(s) have been successfully encrypted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxFile.Items.Clear();
                    listBoxFolder.Items.Clear();
                    txtEncryptorPass.Clear();
                    txtEncryptorRepass.Clear();
                }
            }
        }

        char[] mychar = { '!', '.', 'L', 'O', 'C', 'K', 'E', 'D' };

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //This function will decrypt selected files
            //Password must have 8 characters!
            //Password must be correct!
            if (txtEncryptorPass.Text != txtEncryptorRepass.Text)
            {
                EvolveMessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEncryptorPass.Text.Length < 8)
            {
                EvolveMessageBox.Show("Password must have 8 characters!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //This is for selected files
            if (listBoxFile.Items.Count > 0)
            {
                for (int num = 0; num < listBoxFile.Items.Count; num++)
                {
                    string e_file = "" + listBoxFile.Items[num];
                    if (e_file.Trim().EndsWith(".!LOCKED") && File.Exists(e_file))
                    {
                        DecryptFile(e_file, e_file.TrimEnd(mychar), txtEncryptorPass.Text);
                        File.Delete(e_file);
                    }
                }
                EvolveMessageBox.Show("Your File(s) have been successfully decrypted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxFile.Items.Clear();
                listBoxFolder.Items.Clear();
                txtEncryptorPass.Clear();
                txtEncryptorRepass.Clear();
            }
            //This is for selected folders
            if (listBoxFolder.Items.Count > 0)
            {
                for (int num = 0; num < listBoxFolder.Items.Count; num++)
                {
                    string d_file = "" + listBoxFolder.Items[num];
                    string[] get_files = Directory.GetFiles(d_file);
                    foreach (string name_file in get_files)
                    {
                        if (name_file.Trim().EndsWith(".!LOCKED") && File.Exists(name_file))
                        {
                            DecryptFile(name_file, name_file.TrimEnd(mychar), txtEncryptorPass.Text);
                            File.Delete(name_file);
                        }
                    }
                    EvolveMessageBox.Show("Your File(s) have been successfully decrypted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listBoxFile.Items.Clear();
                    listBoxFolder.Items.Clear();
                    txtEncryptorPass.Clear();
                    txtEncryptorRepass.Clear();
                }
            }
        }

        private void DecryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch { }
        }

        private void EncryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch { }
        }
        #endregion encryptor

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtEncryptorPass.Text != txtEncryptorRepass.Text)
            {
                btnEncrypt.Enabled = false;
                btnDecrypt.Enabled = false;
            }
            else
            {
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;
            }
        }
    }
}
