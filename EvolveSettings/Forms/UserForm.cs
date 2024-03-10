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
//using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class UserForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        PasswordValidator passwordValidator = new PasswordValidator();
        string imgLocation = "";

        public UserForm()
        {
            InitializeComponent();

            lblUserMode.Visible = false;
            lblAdminUserType.Visible = false;
            if (txtPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
            }

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            LoadUser();
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
                pnlGridView.FillColor = SystemColors.Control;


            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlGridView.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlUserInfo.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlUserPerms.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPasswordValidation.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlEditUser.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                txtDateCreated.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                lblUserMode.ForeColor = Color.White;
                lblAdminUserType.ForeColor = Color.Red;
                txtDateCreated.ForeColor = Color.White;
                lblHeaderSelectUserType.ForeColor = Color.White;
                lblEditFullName.ForeColor = Color.White;
                lblEditUserName.ForeColor = Color.White;
                lblEditPassword.ForeColor = Color.White;
                lblEditRePass.ForeColor = Color.White;
                lblEditEmail.ForeColor = Color.White;
                lblUserInfo.ForeColor = Color.White;
                lblFullName.ForeColor = Color.White;
                lblUserPerms.ForeColor = Color.White;
                lblPasswordValidation.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblEditUser.ForeColor = Color.White;
                lblUser.ForeColor = Color.White;
                lblEmail.ForeColor = Color.White;
                lblDateCreate.ForeColor = Color.White;
                lblUserType.ForeColor = Color.Red;
                lblTitle.ForeColor = Color.White;
                foreach (Guna2DataGridView gridview in this.pnlGridView.Controls.OfType<Guna2DataGridView>())
                {
                    gridview.BackgroundColor = ColorTranslator.FromHtml("#FF2D2D30");
                    gridview.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                    gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gridview.DefaultCellStyle.ForeColor = Color.White;
                    gridview.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                    gridview.DefaultCellStyle.SelectionBackColor = themeColor;
                    gridview.GridColor = themeColor;
                    gridview.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                }
                foreach (Guna2TextBox txtbox in this.pnlEditUser.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
            }
            foreach (Guna2Button button in this.pnlUserInfo.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlUserPerms.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlEditUser.Controls.OfType<Guna2Button>())
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

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM admin", connect); //admin is the database table name
            connect.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1], dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
            }
            dr.Close();
            connect.Close();
        }


        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.lblAddUpdateUser.Text = "Add User";
            userModule.btnSave.Enabled = true;
            userModule.txtID.Enabled = false;
            userModule.btnUpdate.Visible = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUser.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtID.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
                userModule.txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txtEmail.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
                userModule.txtDateCreated.Text = dgvUser.Rows[e.RowIndex].Cells[7].Value.ToString();
                userModule.lblAdminUserType.Text = dgvUser.Rows[e.RowIndex].Cells[8].Value.ToString();

                userModule.lblAddUpdateUser.Text = "Update User";
                userModule.btnSave.Visible = false;
                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.txtID.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (EvolveMessageBox.Show("Are you sure you want to delete this user?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    cmd = new SqlCommand("DELETE FROM admin WHERE id LIKE '" + dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connect);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadUser();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            //User information
            lblFullName.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblUser.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblEmail.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblUserType.Text = dgvUser.Rows[e.RowIndex].Cells[8].Value.ToString();

            // Edit User
            txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDateCreated.Text = dgvUser.Rows[e.RowIndex].Cells[7].Value.ToString();
            lblAdminUserType.Text = dgvUser.Rows[e.RowIndex].Cells[8].Value.ToString();
            try
            {
                string sql = "Select username, image FROM admin WHERE username ='" + txtUserName.Text + "'";
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                    cmd = new SqlCommand(sql, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        txtUserName.Text = reader[0].ToString();
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
                        //MessageBox.Show("No profile picture set. Image does not excist!");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                if (EvolveMessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;


                        cmd = new SqlCommand("UPDATE admin SET image = @image, password=@password, email=@email, fullname=@fullname, date_created=@date, usertype=@usertype WHERE username LIKE '" + txtUserName.Text + "' ", connect);

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
                    cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@usertype", lblAdminUserType.Text.Trim());

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("User has been successfully updated!");
                    foreach (Guna2TextBox txtbox in this.pnlEditUser.Controls.OfType<Guna2TextBox>())
                    {
                        txtbox.Clear();
                    }
                    lblPassValidationInfo.Visible = false;
                    timer1.Stop();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditShowPass.Checked)
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

        private void btnUserTypeAdmin_Click(object sender, EventArgs e)
        {
            lblAdminUserType.Text = "admin";
            lblAdminUserType.Visible = true;
            lblUserMode.Visible = true;
        }

        private void btnUserTypeGuest_Click(object sender, EventArgs e)
        {
            lblAdminUserType.Text = "";
            lblUserMode.Visible = false;
            lblAdminUserType.Visible = false;
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

        private void btnPassGen_Click(object sender, EventArgs e)
        {
            PasswordGenForm passgen = new PasswordGenForm();
            passgen.ShowDialog();
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
                btnUpdate.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
    }
}
