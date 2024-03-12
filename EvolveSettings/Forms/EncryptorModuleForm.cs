using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class EncryptorModuleForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();

        PasswordValidator passwordValidator = new PasswordValidator();

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public EncryptorModuleForm()
        {
            InitializeComponent();
            txtDateCreated.Text = DateTime.Now.ToString();

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }

            txtPass.Enabled = false;
            txtRepass.Enabled = false;
            btnSave.Enabled = false;
            if (txtPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
            }
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
                pnlHeader.BackColor = SystemColors.Control;
                panel2.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                }
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.Black;
                }
                label1.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblCurrentUser.ForeColor = Color.White;
                pictureBoxClose.ForeColor = Color.Black;
                txtDateCreated.BackColor = SystemColors.Control;
                txtDateCreated.ForeColor = Color.Black;
                lblAddUpdateUser.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel2.BackColor = themeColor;
                pnlPwValidation.FillColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.White;
                }
                label1.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblCurrentUser.ForeColor = Color.White;
                pictureBoxClose.ForeColor = Color.White;
                txtDateCreated.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                txtDateCreated.ForeColor = Color.White;
            }
            chkShowPass.CheckedState.FillColor = themeColor;
            foreach (Guna2Button button in this.Controls.OfType<Guna2Button>())
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            timer1.Stop();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    EvolveMessageBox.Show("Passwords do not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (EvolveMessageBox.Show("Are you sure you want to save this record?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cmd = new SqlCommand("INSERT INTO encryptor (filename, password, description, location, date_created) " +
                                    "VALUES(@filename, @password, @description, @location, @date)", connect);

                    DateTime date = DateTime.Today;

                    cmd.Parameters.AddWithValue("@filename", txtFileName.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("File record has been successfully saved.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtFileName.Clear();
            txtDescription.Clear();
            txtRepass.Clear();
            txtPass.Clear();
            txtLocation.Clear();
            btnSave.Enabled = false;
        }

        private void btnPassGen_Click(object sender, EventArgs e)
        {
            PasswordGenForm passgen = new PasswordGenForm();
            passgen.ShowDialog();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
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
            if (string.IsNullOrEmpty(message))
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
            }
            else
            {
                btnSave.Enabled = false;
            }
        }
    }
}
