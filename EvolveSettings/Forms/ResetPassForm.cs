using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class ResetPassForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        string email = ForgotPassForm.to;

        PasswordValidator passwordValidator = new PasswordValidator();

        public ResetPassForm()
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

            btnReset.Enabled = false;
            btnLogin.Enabled = false;
            if (txtResetPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
                timer1.Start();
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
                panel2.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblResetPassword.ForeColor = Color.Black;
                btnResetPassClose.ForeColor = Color.Black;
                lblNewPassword.ForeColor = Color.Black;
                lblConfirmPassword.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel2.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblResetPassword.ForeColor = Color.White;
                btnResetPassClose.ForeColor = Color.White;
                lblNewPassword.ForeColor = Color.White;
                lblConfirmPassword.ForeColor = Color.White;
            }
            chkResetShowPass.CheckedState.FillColor = themeColor;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetRePass.Text)
            {
                string hash = BCrypt.Net.BCrypt.HashPassword(txtResetPass.Text);
                cmd = new SqlCommand("UPDATE admin SET [password] = '" + hash + "' WHERE email='" + email + "' ", connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                EvolveMessageBox.Show("Password has been reset successfully", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResetPass.Text = String.Empty;
                txtResetPass.Enabled = false;
                txtResetRePass.Text = String.Empty;
                txtResetRePass.Enabled = false;
                btnPassGen.Enabled = false;
                btnReset.Enabled = false;
                btnLogin.Enabled = true;
            }
            else
            {
                EvolveMessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void chkResetShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkResetShowPass.Checked)
            {
                txtResetPass.PasswordChar = '\0';
                txtResetRePass.PasswordChar = '\0';
            }
            else
            {
                txtResetPass.PasswordChar = '*';
                txtResetRePass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login frmlogin = new Login();
            this.Dispose();
            frmlogin.Show();
        }

        private void btnResetPassClose_Click(object sender, EventArgs e)
        {
            Login lgnfrm = new Login();
            this.Dispose();
            lgnfrm.Show();
        }

        private void btnPassGen_Click(object sender, EventArgs e)
        {
            PasswordGenForm passgen = new PasswordGenForm();
            passgen.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtResetPass.Text.Length > 0)
            {
                lblPassValidationInfo.Visible = true;
            }
            else if (txtResetPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
            }
            string message = string.Empty;
            if (passwordValidator.IsStrong(txtResetPass.Text, out message))
            {
                if (string.IsNullOrEmpty(message))
                    lblPassValidationInfo.Text = "Password verification accepted.";
                else
                    lblPassValidationInfo.Text = message;
            }
            else
            {
                lblPassValidationInfo.Text = message;
            }
            if (string.IsNullOrEmpty(message))
            {
                btnReset.Enabled = true;
            }
            else
            {
                btnReset.Enabled = false;
            }
        }
    }
}
