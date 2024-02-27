using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class ForgotPassForm : Form
    {
        string randomCode;
        public static string to;

        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public ForgotPassForm()
        {
            InitializeComponent();

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            LoadTheme();

            txtVerifyCode.ReadOnly = true;
            btnVerify.Enabled = false;
            if (txtEmail.Text.Length < 1)
            {
                btnSendCode.Enabled = false;
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
                lblEmail.ForeColor = Color.Black;
                lblVerifyCode.ForeColor = Color.Black;
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
                lblEmail.ForeColor = Color.White;
                lblVerifyCode.ForeColor = Color.White;
            }
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

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "ENTER_EMAIL";
            pass = "ENTER_PASS";
            messageBody = "Your verification code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Evolve Settings password verification";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send successfully. Verification code: " + randomCode, "Requested verification code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVerifyCode.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerifyCode.Text).ToString())
            {
                to = txtEmail.Text;
                ResetPassForm rpass = new ResetPassForm();
                this.Hide();
                rpass.Show();
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("You have entered a wrong code, please try again or request a new code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0)
            {
                btnSendCode.Enabled = true;
            }
            else if (txtEmail.Text.Length < 1)
            {
                btnSendCode.Enabled = false;
            }
            if (txtVerifyCode.Text.Length > 4)
            {
                btnVerify.Enabled = true;
            }
        }

        private void btnResetPassClose_Click(object sender, EventArgs e)
        {
            Login lgnfrm = new Login();
            lgnfrm.Show();
            this.Dispose();
        }
    }
}
