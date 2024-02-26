using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class ForgotPassForm : Form
    {
        string randomCode;
        public static string to;

        public ForgotPassForm()
        {
            InitializeComponent();
            txtVerifyCode.Enabled = false;
            btnVerify.Enabled = false;
            if (txtEmail.Text.Length < 1)
            {
                btnSendCode.Enabled = false;
                timer1.Start();
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            string from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "ENTER_EMAIL";
            pass = "ENTER_CODE";
            messageBody = "Your verification code is " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Evolve Settings password verification code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Code send successfully. Verification code: " + randomCode, "Requested verification code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVerifyCode.Enabled = true;
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
