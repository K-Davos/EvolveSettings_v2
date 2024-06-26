﻿using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EvolveSettings
{
    public partial class Login : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmdR = new SqlCommand();
        SqlDataReader datareader;
        int attempts = 1;

        public Login()
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

            var key = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Evolve\EvolveSettings", "Admin", "1");
            if (key.ToString() == "1")
            {
                lblNoAccount.Visible = true;
                lblRegister.Visible = true;
            }
            else if (key.ToString() == "0")
            {
                lblNoAccount.Visible = false;
                lblRegister.Visible = false;
            }

            if (txtPass.Text.Length < 5)
            {
                btnLogin.Enabled = false;
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
                panel1.BackColor = SystemColors.Control;
                panel2.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.panel1.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                }
                lblWelcomeBack.ForeColor = Color.Black;
                lblForgotPass.ForeColor = ColorTranslator.FromHtml("#212121");
                chkLoginShowPass.ForeColor = ColorTranslator.FromHtml("#212121");
                lblNoAccount.ForeColor = ColorTranslator.FromHtml("#212121");
                lblRegister.ForeColor = ColorTranslator.FromHtml("#212121");
                login_close.ForeColor = Color.Black;
                lblUserName.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;

            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel1.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel2.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.panel1.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblWelcomeBack.ForeColor = Color.White;
                lblForgotPass.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                chkLoginShowPass.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblNoAccount.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblRegister.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                login_close.ForeColor = Color.White;
                lblUserName.ForeColor = Color.White;
                lblPassword.ForeColor = Color.White;
            }
            chkLoginShowPass.CheckedState.FillColor = themeColor;
            foreach (Guna2Button button in this.panel1.Controls.OfType<Guna2Button>())
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
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPass.Text == "")
            {
                EvolveMessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open && attempts < 4)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT password FROM admin WHERE username='" + txtUserName.Text + "'";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                datareader = cmd.ExecuteReader();
                                datareader.Read();
                                bool verify = BCrypt.Net.BCrypt.Verify(txtPass.Text, datareader.GetString(0));
                                if (verify)
                                {
                                    EvolveMessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    datareader.Close();
                                    usrname = txtUserName.Text;
                                    MainForm mForm = new MainForm(usrname);
                                    string sql = "Select username, image FROM admin WHERE username='" + txtUserName.Text + "'";
                                    cmdR = new SqlCommand(sql, connect);

                                    SqlDataReader reader = cmdR.ExecuteReader();
                                    reader.Read();
                                    txtUserName.Text = reader[0].ToString();
                                    byte[] img = (byte[])(reader[1]);
                                    MemoryStream memstream = new MemoryStream(img);
                                    mForm.pictureBoxProfile.Image = Image.FromStream(memstream);
                                    mForm.Show();
                                    connect.Close();
                                    this.Hide();
                                    timer1.Stop();
                                }
                            }
                            else
                            {
                                EvolveMessageBox.Show("The username or password is incorrect. Please try again. Number of login attempts: " + attempts, "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        EvolveMessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else if (attempts == 4)
                {
                    EvolveMessageBox.Show("Maximum login attempts reached, the application will close.", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                attempts++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtPass.Text.Length < 5)
            {
                btnLogin.Enabled = false;
            }
            else if (txtPass.Text.Length > 5)
            {
                btnLogin.Enabled = true;
            }
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            Forms.ForgotPassForm sendcode = new Forms.ForgotPassForm();
            this.Hide();
            sendcode.Show();

        }
    }
}
