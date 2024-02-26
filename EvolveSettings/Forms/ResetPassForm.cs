using EvolveSettings.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvolveSettings.Forms
{
    public partial class ResetPassForm : Form
    {
        PasswordValidator passwordValidator = new PasswordValidator();

        public ResetPassForm()
        {
            InitializeComponent();
            btnReset.Enabled = false;
            btnLogin.Enabled = false;
            if (txtResetPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
                timer1.Start();
            }
        }

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        string email = ForgotPassForm.to;

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetRePass.Text)
            {
                cmd = new SqlCommand("UPDATE admin SET [password] = '" + txtResetPass.Text + "' WHERE email='" + email + "' ", connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("Password has been reset successfully", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Password & Confirm Password do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
