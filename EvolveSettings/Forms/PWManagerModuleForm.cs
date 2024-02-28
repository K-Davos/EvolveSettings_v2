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
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class PWManagerModuleForm : Form
    {
        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();

        PasswordValidator passwordValidator = new PasswordValidator();

        public PWManagerModuleForm()
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
                    MessageBox.Show("Passwords do not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to save this record?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cmd = new SqlCommand("INSERT INTO pwmanager (fullname, email, username, password, date_created) " +
                                    "VALUES(@fullname, @email, @username, @pass, @date)", connect);

                    DateTime date = DateTime.Today;

                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Record has been successfully saved.");
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
                    MessageBox.Show("Passwords do not Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Are you sure you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;

                    cmd = new SqlCommand("UPDATE pwmanager SET fullname = @fullname, password=@password, email=@email, date_created=@date WHERE username LIKE '" + txtUserName.Text + "' ", connect);
                    cmd.Parameters.AddWithValue("@fullname", txtFullName.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Record has been successfully updated!");
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
                    lblPassValidationInfo.Text = "Password validation successful.";
                else
                    lblPassValidationInfo.Text = message;
            }
            else
            {
                lblPassValidationInfo.Text = message;
            }
            /*if (string.IsNullOrEmpty(message))
            {
                btnSave.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
            }*/
        }

        private void btnPassGen_Click(object sender, EventArgs e)
        {
            PasswordGenForm passgen = new PasswordGenForm();
            passgen.ShowDialog();
        }
    }
}