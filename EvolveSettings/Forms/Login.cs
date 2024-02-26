using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EvolveSettings
{
    public partial class Login : Form
    {
        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());

        public Login()
        {
            InitializeComponent();
            if (login_password.Text.Length < 5)
            {
                btnLogin.Enabled = false;
                timer1.Start();
            }
        }

        String usrname;

        private void txtRegister_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
            timer1.Stop();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkLoginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoginShowPass.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM admin WHERE username = @username AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                usrname = "Welcome: " + login_username.Text;
                                MainForm mForm = new MainForm(usrname);
                                mForm.Show();
                                connect.Close();
                                this.Hide();
                                timer1.Stop();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (login_password.Text.Length < 5)
            {
                btnLogin.Enabled = false;
            }
            else if (login_password.Text.Length > 5)
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
