using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class FileEncryptorForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        //Sql Database
        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        //Password Validator
        PasswordValidator passwordValidator = new PasswordValidator();

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

            txtFileName.ReadOnly = true;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            txtEncryptorPass.Enabled = false;
            txtEncryptorRepass.Enabled = false;
            btnEncrypt.Enabled = false;
            btnDecrypt.Enabled = false;
            btnUpdate.Enabled = false;
            if (txtPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
            }
            if (txtEncryptorPass.Text.Length < 1)
            {
                lblEncryptPassValidationInfo.Visible = false;
            }
            LoadEncryptorDB();
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
                pnlGridView.FillColor = Color.White;
                txtDateCreated.ForeColor = Color.Black;
                txtDateCreated.BackColor = Color.White;
                pnlHeader.BackColor = SystemColors.Control;
                lblTitle.ForeColor = Color.Black;
                lblPassValidationInfo.ForeColor = Color.Black;
                foreach (Guna2DataGridView gridview in this.pnlGridView.Controls.OfType<Guna2DataGridView>())
                {
                    gridview.BackgroundColor = Color.White;
                    gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                    gridview.DefaultCellStyle.ForeColor = Color.Black;
                    gridview.DefaultCellStyle.BackColor = SystemColors.Control;
                    gridview.DefaultCellStyle.SelectionBackColor = themeColor;
                    gridview.GridColor = themeColor;
                    gridview.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Control;
                }
                foreach (Guna2TextBox txtbox in this.pnlEncryptDecrypt.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = Color.White;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                    txtbox.DisabledState.FillColor = SystemColors.Control;
                }
                foreach (Guna2TextBox txtbox in this.pnlDbFileInfo.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = Color.White;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                    txtbox.DisabledState.FillColor = SystemColors.Control;
                }
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlGridView.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlFiles.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlFolders.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlEncryptDecrypt.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPwValidation.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlDbFileInfo.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                txtDateCreated.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                listBoxFile.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                listBoxFolder.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                lblFileName.ForeColor = Color.White;
                lblFileDescription.ForeColor = Color.White;
                lblFileFolderLocation.ForeColor = Color.White;
                txtDateCreated.ForeColor = Color.White;
                lblPass.ForeColor = Color.White;
                lblRePass.ForeColor = Color.White;
                lblEditPassword.ForeColor = Color.White;
                lblEditPassword.ForeColor = Color.White;
                lblEditRepass.ForeColor = Color.White;
                lblLength.ForeColor = Color.White;
                lblPasswordValidation.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblEncryptPassValidationInfo.ForeColor = Color.White;
                listBoxFile.ForeColor = Color.White;
                listBoxFolder.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                foreach (Guna2DataGridView gridview in this.pnlGridView.Controls.OfType<Guna2DataGridView>())
                {
                    gridview.BackgroundColor = ColorTranslator.FromHtml("#FF2D2D30");
                    gridview.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                    gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gridview.DefaultCellStyle.ForeColor = Color.White;
                    gridview.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                    gridview.DefaultCellStyle.SelectionBackColor = themeColor;
                    gridview.GridColor = themeColor;
                    gridview.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                }
                foreach (Guna2TextBox txtbox in this.pnlEncryptDecrypt.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
                foreach (Guna2TextBox txtbox in this.pnlDbFileInfo.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
            }
            foreach (Guna2Button button in this.pnlEncryptDecrypt.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlDbFileInfo.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlFolders.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlFiles.Controls.OfType<Guna2Button>())
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

        #region encryptor database
        public void LoadEncryptorDB()
        {
            int i = 0;
            dgvEncryptor.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM encryptor", connect); //encryptor is the database table name
            connect.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvEncryptor.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            connect.Close();
        }

        private void dgvPwManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEncryptor.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (EvolveMessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    cmd = new SqlCommand("DELETE FROM encryptor WHERE id LIKE '" + dgvEncryptor.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connect);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadEncryptorDB();
        }

        private void dgvEncryptor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            timer1.Start();

            // Edit User
            txtFileName.Text = dgvEncryptor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPass.Text = dgvEncryptor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescription.Text = dgvEncryptor.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtLocation.Text = dgvEncryptor.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDateCreated.Text = dgvEncryptor.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    EvolveMessageBox.Show("Passwords do not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPass.Text.Length < 7)
                {
                    EvolveMessageBox.Show("Password must be at least 8 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (EvolveMessageBox.Show("Are you sure you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;

                    cmd = new SqlCommand("UPDATE encryptor SET password = @password, description=@description, location=@location, date_created=@date WHERE filename LIKE '" + txtFileName.Text + "' ", connect);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("File record has been successfully updated!");
                    foreach (Guna2TextBox txtbox in this.pnlDbFileInfo.Controls.OfType<Guna2TextBox>())
                    {
                        txtbox.Clear();
                    }
                    txtDateCreated.Clear();
                    lblPassValidationInfo.Visible = false;
                    btnUpdate.Enabled = false;
                    timer1.Stop();
                    LoadEncryptorDB();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion Encryptor database

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtRepass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtRepass.PasswordChar = '*';
            }
        }

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
                timer2.Start();
            }
            if (txtEncryptorPass.Text.Length < 1)
            {
                txtEncryptorRepass.Enabled = false;
                timer2.Stop();
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            if (txtFileName.Text.Length > 1)
            {
                txtPass.Enabled = true;
                txtRepass.Enabled = true;
                timer1.Start();
            }
            if (txtFileName.Text.Length < 1)
            {
                txtPass.Enabled = false;
                txtRepass.Enabled = false;
                timer1.Stop();
            }
        }
        #region timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Encryption password check DbRecord
            if (txtPass.Text.Length > 0)
            {
                lblPassValidationInfo.Visible = true;
            }
            else if (txtPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
            }
            string message = string.Empty;
            if (passwordValidator.IsStrong(txtPass.Text, out message))
            {
                if (string.IsNullOrEmpty(message))
                    lblPassValidationInfo.Text = "Password validation accepted.";
                else
                    lblPassValidationInfo.Text = message;
            }
            else
            {
                lblPassValidationInfo.Text = message;
            }
            if (txtPass.Text != txtRepass.Text)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Encryption password check
            if (txtEncryptorPass.Text.Length > 0)
            {
                lblEncryptPassValidationInfo.Visible = true;
            }
            else if (txtEncryptorPass.Text.Length < 1)
            {
                lblEncryptPassValidationInfo.Visible = false;
            }
            string message = string.Empty;
            if (passwordValidator.IsStrong(txtEncryptorPass.Text, out message))
            {
                if (string.IsNullOrEmpty(message))
                    lblEncryptPassValidationInfo.Text = "Password validation accepted.";
                else
                    lblEncryptPassValidationInfo.Text = message;
            }
            else
            {
                lblEncryptPassValidationInfo.Text = message;
            }
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
        #endregion timers

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblLength.Text = guna2TrackBar1.Value.ToString();
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

        private void btnAddFileRecord_Click(object sender, EventArgs e)
        {
            EncryptorModuleForm encryptorModule = new EncryptorModuleForm();
            encryptorModule.ShowDialog();
            LoadEncryptorDB();
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

        #region passgenerator
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtGenPassword.Text = Helpers.PasswordGenerator.GeneratePassword(GetGenerateConfig());
        }

        private Models.GenerateConfig GetGenerateConfig()
        {
            Models.GenerateConfig config = new Models.GenerateConfig();
            config.IsLowerCase = chkLowercase.Checked;
            config.IsUpperCase = chkUppercase.Checked;
            config.IsDigits = chkDigits.Checked;
            config.IsSymbols = chkSymbols.Checked;
            config.Length = guna2TrackBar1.Value;
            return config;
        }

        private void btnPassGenCopy_Click(object sender, EventArgs e)
        {
            if (txtGenPassword.Text.Trim().Length > 0)
            {
                Clipboard.SetText(txtGenPassword.Text);
            }
        }
        #endregion passgenerator
    }
}
