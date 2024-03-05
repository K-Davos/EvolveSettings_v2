using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class UserForm : Form
    {
        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public UserForm()
        {
            InitializeComponent();
            LoadUser();
        }

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
                dgvUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
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
                userModule.txtEmail.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();
                userModule.txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells[3].Value.ToString();
                userModule.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells[4].Value.ToString();
                userModule.txtDateCreated.Text = dgvUser.Rows[e.RowIndex].Cells[5].Value.ToString();
                userModule.txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells[6].Value.ToString();

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
    }
}
