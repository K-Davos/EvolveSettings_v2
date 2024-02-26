using EvolveSettings.Forms;
using EvolveSettings.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace EvolveSettings
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        PasswordValidator passwordValidator = new PasswordValidator();

        public Signup()
        {
            InitializeComponent();
            btnSignup.Enabled = false;
            if (signup_password.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
                timer1.Start();
            }
        }

        private void txtLoginHere_Click(object sender, EventArgs e)
        {
            Login lForm = new Login();
            lForm.Show();
            this.Hide();
            timer1.Stop();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (signup_password.Text != signup_repassword.Text)
            {
                MessageBox.Show("Password & Confirm Password do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (signup_email.Text == "" || signup_username.Text == ""
                || signup_password.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '"
                            + signup_username.Text.Trim() + "'"; // admin is the database table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, password, date_created) " +
                                    "VALUES(@email, @username, @pass, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // TO SWITCH THE FORM 
                                    Login lForm = new Login();
                                    lForm.Show();
                                    this.Hide();
                                    timer1.Stop();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void chkSignupShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSignupShowPass.Checked)
            {
                signup_password.PasswordChar = '\0';
                signup_repassword.PasswordChar = '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
                signup_repassword.PasswordChar = '*';
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (signup_password.Text.Length > 0)
            {
                lblPassValidationInfo.Visible = true;
            }
            else if (signup_password.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
            }
            string message = string.Empty;
            if (passwordValidator.IsStrong(signup_password.Text, out message))
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
                btnSignup.Enabled = true;
            }
            else
            {
                btnSignup.Enabled = false;
            }
        }

        private void btnSignupPassGen_Click(object sender, EventArgs e)
        {
            PasswordGenForm passgen = new PasswordGenForm();
            passgen.ShowDialog();
        }
    }
}
