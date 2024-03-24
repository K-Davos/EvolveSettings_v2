using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class PrivacyAndSecurityForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        //Sql Database
        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        //Password Validator
        PasswordValidator passwordValidator = new PasswordValidator();

        public PrivacyAndSecurityForm()
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
            btnUpdate.Enabled = false;

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
                lblEncrypting.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Black;
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
                pnlEncryptor.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlDbFileInfo.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                txtDateCreated.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                lblFileName.ForeColor = Color.White;
                lblFileDescription.ForeColor = Color.White;
                lblFileFolderLocation.ForeColor = Color.White;
                lblEncrypting.ForeColor = Color.White;
                txtDateCreated.ForeColor = Color.White;
                lblPass.ForeColor = Color.White;
                lblRePass.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                lblTitle.ForeColor = Color.White;
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
                foreach (Guna2TextBox txtbox in this.pnlDbFileInfo.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
            }
            foreach (Guna2Button button in this.pnlDbFileInfo.Controls.OfType<Guna2Button>())
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

        private void btnAddFileRecord_Click(object sender, EventArgs e)
        {
            EncryptorModuleForm encryptorModule = new EncryptorModuleForm();
            encryptorModule.ShowDialog();
            LoadEncryptorDB();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (txtPass.Text != txtRepass.Text)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnFileEncryptor_Click(object sender, EventArgs e)
        {
            FileEncryptorForm frmFileEncryptor = new FileEncryptorForm();
            frmFileEncryptor.ShowDialog();
        }

        private void btnPwEncryption_Click(object sender, EventArgs e)
        {
            PasswordEncryptionForm pwEncryption = new PasswordEncryptionForm();
            pwEncryption.txtRecordName.Visible = false;
            pwEncryption.lblRecordName.Visible = false;
            pwEncryption.btnSave2.Visible = false;
            pwEncryption.txtFileName.Visible = true;
            pwEncryption.lblFileName.Visible = true;
            pwEncryption.btnSave.Visible = true;
            pwEncryption.ShowDialog();
        }
    }
}
