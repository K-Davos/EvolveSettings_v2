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
    public partial class PasswordEncryptionForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();

        string encryptionKey;

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public PasswordEncryptionForm()
        {
            InitializeComponent();

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(PasswordEncryptionForm_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
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
                panel3.BackColor = themeColor;
                pictureBoxClose.ForeColor = Color.Black;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                }
                label6.ForeColor = Color.White;
                lblRecordName.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                lblEncrypted.ForeColor = Color.Black;
                lblDecrypted.ForeColor = Color.Black;

            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel3.BackColor = themeColor;
                pictureBoxClose.ForeColor = Color.White;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
                label6.ForeColor = Color.White;
                lblRecordName.ForeColor = Color.White;
                lblPassword.ForeColor = Color.White;
                lblEncrypted.ForeColor = Color.White;
                lblDecrypted.ForeColor = Color.White;
            }
            chkSignupShowPass.CheckedState.FillColor = themeColor;
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

        private void PasswordEncryptionForm_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }
        #endregion wintheme

        private void PasswordEncryptionForm_Load(object sender, EventArgs e)
        {
            encryptionKey = "0123456789123456";
            btnSave.Enabled = false;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = EvolveUtilities.Encrypt(txtPass.Text, encryptionKey);
            {
                txtEncrypted.Text = encryptedText;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string decryptedText = EvolveUtilities.Decrypt(txtEncrypted.Text, encryptionKey);
            txtDecrypted.Text = decryptedText;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length < 1)
            {
                EvolveMessageBox.Show("No password entered! Please enter your (Decrypted) password", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtPass.Text.Length > 1)
            {
                string encryptedText = EvolveUtilities.Encrypt(txtPass.Text, encryptionKey);
                {
                    txtEncrypted.Text = encryptedText;
                }
                //Add to database
                cmd = new SqlCommand("UPDATE pwmanager SET password = @EncryptedPassword WHERE recordname LIKE '" + txtRecordName.Text + "' ", connect);

                cmd.Parameters.AddWithValue("@EncryptedPassword", encryptedText);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                EvolveMessageBox.Show("Encrypted password successfully saved to database", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void chkSignupShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSignupShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void txtRecordName_TextChanged(object sender, EventArgs e)
        {
            if (txtRecordName.Text.Length > 1)
            {
                btnSave.Enabled = true;
            }
            if (txtRecordName.Text.Length < 1)
            {
                btnSave.Enabled = false;
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
