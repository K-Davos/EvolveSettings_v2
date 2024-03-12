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
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class UserModuleForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();

        string imgLocation = "";

        PasswordValidator passwordValidator = new PasswordValidator();

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public UserModuleForm()
        {
            InitializeComponent();
            txtDateCreated.Text = DateTime.Now.ToString();

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }

            btnSave.Enabled = false;
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
                pnlHeader.BackColor = SystemColors.Control;
                panel2.BackColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                }
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.Black;
                }
                label1.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblCurrentUser.ForeColor = Color.White;
                pictureBoxClose.ForeColor = Color.Black;
                txtDateCreated.BackColor = SystemColors.Control;
                txtDateCreated.ForeColor = Color.Black;
                lblAddUpdateUser.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                panel2.BackColor = themeColor;
                pnlPwValidation.FillColor = themeColor;
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
                foreach (Label lbl in this.Controls.OfType<Label>())
                {
                    lbl.ForeColor = Color.White;
                }
                label1.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblCurrentUser.ForeColor = Color.White;
                pictureBoxClose.ForeColor = Color.White;
                txtDateCreated.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                txtDateCreated.ForeColor = Color.White;
                lblAddUpdateUser.ForeColor = Color.White;
            }
            chkShowPass.CheckedState.FillColor = themeColor;
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            timer1.Stop();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPass.Text != txtRepass.Text)
                {
                    EvolveMessageBox.Show("Passwords do not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPass.Text.Length < 7)
                {
                    EvolveMessageBox.Show("Password must be at least 8 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtEmail.Text == "" || txtUserName.Text == "" || txtPass.Text == "")
                {
                    EvolveMessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (EvolveMessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime date = DateTime.Today;

                    cmd = new SqlCommand("INSERT INTO admin (image, username, password, email, fullname, date_created, usertype) " + "VALUES(@image, @username, @pass, @email, @fullname, @date, @usertype)", connect);

                    if (!String.IsNullOrEmpty(imgLocation) && System.IO.File.Exists(imgLocation))
                    {
                        byte[] images = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader reader = new BinaryReader(stream);
                        images = reader.ReadBytes((int)stream.Length);

                        cmd.Parameters.AddWithValue("@image", images);
                    }
                    else
                    {
                        Image image = pictureBoxProfile.Image;
                        MemoryStream memoryStream = new MemoryStream();
                        image.Save(memoryStream, ImageFormat.Png);
                        byte[] imageBt = memoryStream.ToArray();

                        cmd.Parameters.AddWithValue("@image", imageBt);
                    }
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@usertype", lblAdminUserType.Text.Trim());

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("User has been successfully saved.");
                    Clear();
                    timer1.Stop();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtRepass.Clear();
            txtPass.Clear();
            txtFullName.Clear();
            lblAdminUserType.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
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
                if (txtPass.Text != txtRepass.Text)
                {
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            else
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void btnPassGen_Click(object sender, EventArgs e)
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

        private void btnViewImage_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select email, image FROM admin WHERE username ='" + txtUserName.Text + "'";
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                    cmd = new SqlCommand(sql, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        txtEmail.Text = reader[0].ToString();
                        byte[] img = (byte[])(reader[1]);
                        if (img == null)
                        {
                            pictureBoxProfile.Image = null;
                        }
                        else
                        {
                            MemoryStream memstream = new MemoryStream(img);
                            pictureBoxProfile.Image = Image.FromStream(memstream);
                            connect.Close();
                        }
                    }
                    else
                    {
                        connect.Close();
                        //EvolveMessageBox.Show("No profile picture set. Image does not excist!");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnUserTypeAdmin_Click(object sender, EventArgs e)
        {
            lblAdminUserType.Text = "admin";
        }

        private void btnUserTypeGuest_Click(object sender, EventArgs e)
        {
            lblAdminUserType.Text = "";
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
    }
}