using EvolveSettings.Helpers;
using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class UserModuleForm : Form
    {

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();

        string imgLocation = "";

        PasswordValidator passwordValidator = new PasswordValidator();

        public UserModuleForm()
        {
            InitializeComponent();
            txtDateCreated.Text = DateTime.Now.ToString();

            if (txtPass.Text.Length < 1)
            {
                lblPassValidationInfo.Visible = false;
                timer1.Start();
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            timer1.Stop();
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
                if (EvolveMessageBox.Show("Are you sure you want to save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime date = DateTime.Today;

                    if (!String.IsNullOrEmpty(imgLocation) && System.IO.File.Exists(imgLocation))
                    {
                        byte[] images = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader reader = new BinaryReader(stream);
                        images = reader.ReadBytes((int)stream.Length);

                        cmd = new SqlCommand("INSERT INTO admin (image, username, password, email, fullname, date_created) " + "VALUES(@image, @username, @pass, @email, @fullname, @date)", connect);
                        cmd.Parameters.AddWithValue("@image", images);
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", date);
                    }
                    else
                    {
                        Image image = pictureBoxProfile.Image;
                        MemoryStream memoryStream = new MemoryStream();
                        image.Save(memoryStream, ImageFormat.Png);

                        byte[] imageBt = memoryStream.ToArray();

                        cmd = new SqlCommand("INSERT INTO admin (image, username, password, email, fullname, date_created) " + "VALUES(@image, @username, @pass, @email, @fullname, @date)", connect);
                        cmd.Parameters.AddWithValue("@image", imageBt);
                        cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", date);
                   }
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("User has been successfully saved.");
                    Clear();
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
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void Clear()
        {
            txtUserName.Clear();
            txtEmail.Clear();
            txtRepass.Clear();
            txtPass.Clear();
            txtFullName.Clear();
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
                    if (!String.IsNullOrEmpty(imgLocation) && System.IO.File.Exists(imgLocation))
                    {
                        byte[] images = null;
                        FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader reader = new BinaryReader(stream);
                        images = reader.ReadBytes((int)stream.Length);

                        cmd = new SqlCommand("UPDATE admin SET image = @image, password=@password, email=@email, fullname=@fullname, date_created=@date, usertype=@usertype WHERE username LIKE '" + txtUserName.Text + "' ", connect);
                        cmd.Parameters.AddWithValue("@image", images);
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@usertype", lblAdminUserType.Text.Trim());
                    }
                    else
                    {
                        Image image = pictureBoxProfile.Image;
                        MemoryStream memoryStream = new MemoryStream();
                        image.Save(memoryStream, ImageFormat.Png);

                        byte[] imageBt = memoryStream.ToArray();

                        cmd = new SqlCommand("UPDATE admin SET image = @image, password=@password, email=@email, fullname=@fullname, date_created=@date, usertype=@usertype WHERE username LIKE '" + txtUserName.Text + "' ", connect);
                        cmd.Parameters.AddWithValue("@image", imageBt);
                        cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@usertype", lblAdminUserType.Text.Trim());
                    }
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("User has been successfully updated!");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                btnSave.Enabled = true;
                btnUpdate.Enabled = true;
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
            dialog.Filter = " png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

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
                        //MessageBox.Show("No profile picture set. Image does not excist!");
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
    }
}