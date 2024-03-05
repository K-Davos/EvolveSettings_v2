using EvolveSettings.Forms;
using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EvolveSettings
{
    public partial class Signup : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());

        string imgLocation = "";

        PasswordValidator passwordValidator = new PasswordValidator();

        public Signup()
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

            btnSignup.Enabled = false;
            if (signup_password.Text.Length < 1)
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
                panel3.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblGetStarted.ForeColor = Color.Black;
                lblAlreadyAccount.ForeColor = ColorTranslator.FromHtml("#212121");
                txtLoginHere.ForeColor = ColorTranslator.FromHtml("#212121");
                signup_close.ForeColor = Color.Black;
                lblEmail.ForeColor = Color.Black;
                lblUserName.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                lblConfirmPassword.ForeColor = Color.Black;

            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel3.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblGetStarted.ForeColor = Color.White;
                lblAlreadyAccount.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                txtLoginHere.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                signup_close.ForeColor = Color.White;
                lblEmail.ForeColor = Color.White;
                lblUserName.ForeColor = Color.White;
                lblPassword.ForeColor = Color.White;
                lblConfirmPassword.ForeColor = Color.White;
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

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }
        #endregion wintheme

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
                EvolveMessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (signup_email.Text == "" || signup_username.Text == ""
                || signup_password.Text == "")
            {
                EvolveMessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                EvolveMessageBox.Show(signup_username.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, password, date_created, image) " +
                                    "VALUES(@email, @username, @pass, @date, @image)";

                                DateTime date = DateTime.Today;

                                Image image = pictureBoxProfile.Image;
                                MemoryStream memoryStream = new MemoryStream();
                                image.Save(memoryStream, ImageFormat.Png);

                                byte[] imageBt = memoryStream.ToArray();

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", signup_email.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);
                                    cmd.Parameters.AddWithValue("@image", imageBt);

                                    cmd.ExecuteNonQuery();

                                    EvolveMessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        EvolveMessageBox.Show("Error connecting to Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxProfile.ImageLocation = imgLocation;
            }
        }
    }
}
