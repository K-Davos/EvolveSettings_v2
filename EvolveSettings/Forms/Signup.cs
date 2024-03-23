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
using System.Text.RegularExpressions;
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

            picBoxValidation.Image = Properties.Resources.checkmark_invalid;
            picBoxPassValidation.Image = Properties.Resources.checkmark_invalid;
            picBoxRepassValidation.Image = Properties.Resources.checkmark_invalid;
            btnSignup.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;
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
                panel3.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
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
                pnlPwValidation.FillColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
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
            if (txtPass.Text != txtRepass.Text)
            {
                EvolveMessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmail.Text == "" || txtUserName.Text == ""
                || txtPass.Text == "")
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
                            + txtUserName.Text.Trim() + "'"; // admin is the database table name

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                EvolveMessageBox.Show(txtUserName.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (image, username, password, email, date_created) " +
                                    "VALUES(@image, @username, @pass, @email, @date)";

                                DateTime date = DateTime.Today;

                                Image image = pictureBoxProfile.Image;
                                MemoryStream memoryStream = new MemoryStream();
                                image.Save(memoryStream, ImageFormat.Png);

                                string hash = BCrypt.Net.BCrypt.HashPassword(txtPass.Text);
                                byte[] imageBt = memoryStream.ToArray();
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@image", imageBt);
                                    cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", hash);
                                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

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
                {
                    lblPassValidationInfo.Text = "Password validation accepted.";
                    picBoxPassValidation.Image = Properties.Resources.checkmark_valid;
                }
                else
                {
                    lblPassValidationInfo.Text = message;
                    picBoxPassValidation.Image = Properties.Resources.checkmark_invalid;
                }
            }
            else
            {
                lblPassValidationInfo.Text = message;
            }
            if (string.IsNullOrEmpty(message))
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    btnSignup.Enabled = false;
                    picBoxRepassValidation.Image = Properties.Resources.checkmark_invalid;
                }
                else
                {
                    btnSignup.Enabled = true;
                    picBoxRepassValidation.Image = Properties.Resources.checkmark_valid;
                }
            }
            else
            {
                btnSignup.Enabled = false;
                picBoxRepassValidation.Image = Properties.Resources.checkmark_invalid;
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
            dialog.Filter = " png files (*.png)|*.png| jpg files (*.jpg)|*.jpg| bmp files (*.bmp)|*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxProfile.ImageLocation = imgLocation;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 1)
            {
                txtPass.Enabled = true;
                txtRepass.Enabled = true;
                timer1.Start();
            }
            if (txtUserName.Text.Length < 1)
            {
                txtPass.Enabled = false;
                txtRepass.Enabled = false;
                timer1.Stop();
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //  mail@mail.com                        => ^([\w]+)@([\w]+)\.([\w]+)$
            //  http://www.google.com                => ^(http://www\.)([\w]+)\.([\w]+)$
            //  Phone Number like : 0011 XXX XXX XXX => ^(0011)(([ ][0-9]{3}){3})$
            //  Date XX/XX/XXXX                      => ^([0-9]{2})\/([0-9]{2})\/([0-9]{4})$

            Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", txtEmail, picBoxValidation/*, lblEmailVal, "Mail"*/);
        }

        public void Regexp(string re, Guna2TextBox tb, PictureBox pc/*, Label lbl, string s*/)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.checkmark_valid;
                //lbl.ForeColor = Color.Green;
                //lbl.Text = s + " Valid";
            }
            else
            {
                pc.Image = Properties.Resources.checkmark_invalid;
                //lbl.ForeColor = Color.Red;
                //lbl.Text = s + " InValid";
            }
        }
    }
}
