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

namespace EvolveSettings.Forms
{
    public partial class PasswordManagerForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        PasswordValidator passwordValidator = new PasswordValidator();
        string imgLocation = "";


        public PasswordManagerForm()
        {
            InitializeComponent();

            btnUpdate.Enabled = false;
            txtPass.Enabled = false;
            txtRepass.Enabled = false;

            //WinTheme
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            LoadRecordDb();
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
                pnlRecordInfo.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPasswordValidation.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlEditUser.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                txtDateCreated.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                lblDoubleDot1.ForeColor = Color.White;
                lblDoubleDot2.ForeColor = Color.White;
                lblDoubleDot3.ForeColor = Color.White;
                lblDoubleDot4.ForeColor = Color.White;
                lblEditFullName.ForeColor = Color.White;
                lblRecordName.ForeColor = Color.White;
                txtDateCreated.ForeColor = Color.White;
                lblRecordNameDb.ForeColor = Color.White;
                lblUserNameDb.ForeColor = Color.White;
                lblPasswordDb.ForeColor = Color.White;
                lblEmailDb.ForeColor = Color.White;
                lblDateCreateDb.ForeColor = Color.White;
                lblUserName.ForeColor = Color.White;
                lblPassword.ForeColor = Color.White;
                lblEditUserName.ForeColor = Color.White;
                lblEditPassword.ForeColor = Color.White;
                lblEditRePass.ForeColor = Color.White;
                lblEditEmail.ForeColor = Color.White;
                lblUserInfo.ForeColor = Color.White;
                lblPasswordValidation.ForeColor = Color.White;
                lblPassValidationInfo.ForeColor = Color.White;
                lblEditUser.ForeColor = Color.White;
                lblEmail.ForeColor = Color.White;
                lblDateCreate.ForeColor = Color.White;
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
                    txtbox.DisabledState.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
            }
            foreach (Guna2Button button in this.pnlRecordInfo.Controls.OfType<Guna2Button>())
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

        public void LoadRecordDb()
        {
            int i = 0;
            dgvPwManager.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM pwmanager", connect); //pwmanager is the database table name
            connect.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvPwManager.Rows.Add(i, dr[0].ToString(), dr[1], dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            connect.Close();
        }


        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            PWManagerModuleForm recordModule = new PWManagerModuleForm();
            recordModule.lblAddUpdateUser.Text = "Add Record";
            recordModule.btnSave.Enabled = true;
            recordModule.txtID.Enabled = false;
            recordModule.btnUpdate.Visible = false;
            recordModule.ShowDialog();
            LoadRecordDb();
        }

        private void dgvPwManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvPwManager.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                PWManagerModuleForm recordModule = new PWManagerModuleForm();
                recordModule.txtID.Text = dgvPwManager.Rows[e.RowIndex].Cells[1].Value.ToString();
                recordModule.txtRecordName.Text = dgvPwManager.Rows[e.RowIndex].Cells[3].Value.ToString();
                recordModule.txtEmail.Text = dgvPwManager.Rows[e.RowIndex].Cells[4].Value.ToString();
                recordModule.txtUserName.Text = dgvPwManager.Rows[e.RowIndex].Cells[5].Value.ToString();
                recordModule.txtPass.Text = dgvPwManager.Rows[e.RowIndex].Cells[6].Value.ToString();
                recordModule.txtDateCreated.Text = dgvPwManager.Rows[e.RowIndex].Cells[7].Value.ToString();

                recordModule.lblAddUpdateUser.Text = "Update Record";
                recordModule.btnSave.Visible = false;
                recordModule.btnSave.Enabled = false;
                recordModule.btnUpdate.Enabled = true;
                recordModule.txtID.Enabled = false;
                recordModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (EvolveMessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connect.Open();
                    cmd = new SqlCommand("DELETE FROM pwmanager WHERE id LIKE '" + dgvPwManager.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connect);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("Record has been successfully deleted!");
                }
            }
            LoadRecordDb();
        }

        private void dgvPwManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            //User information
            lblRecordNameDb.Text = dgvPwManager.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblEmailDb.Text = dgvPwManager.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblUserNameDb.Text = dgvPwManager.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblPasswordDb.Text = dgvPwManager.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblDateCreateDb.Text = dgvPwManager.Rows[e.RowIndex].Cells[7].Value.ToString();

            // Edit User
            txtRecordName.Text = dgvPwManager.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvPwManager.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtUserName.Text = dgvPwManager.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPass.Text = dgvPwManager.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtDateCreated.Text = dgvPwManager.Rows[e.RowIndex].Cells[7].Value.ToString();
            try
            {
                string sql = "Select recordname, image FROM pwmanager WHERE recordname ='" + txtRecordName.Text + "'";
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                    cmd = new SqlCommand(sql, connect);

                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();

                    if (reader.HasRows)
                    {
                        txtRecordName.Text = reader[0].ToString();
                        byte[] img = (byte[])(reader[1]);
                        if (img == null)
                        {
                            pictureBoxRecord.Image = null;
                        }
                        else
                        {
                            MemoryStream memstream = new MemoryStream(img);
                            pictureBoxRecord.Image = Image.FromStream(memstream);
                            connect.Close();
                        }
                    }
                    else
                    {
                        connect.Close();
                        //EvolveMessageBox.Show("No record picture set. Image does not excist!");
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
                if (EvolveMessageBox.Show("Are you sure you want to update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DateTime date = DateTime.Today;


                    cmd = new SqlCommand("UPDATE pwmanager SET image = @image, email=@email, username=@username, password=@password, date_created=@date WHERE recordname LIKE '" + txtRecordName.Text + "' ", connect);

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
                        Image image = pictureBoxRecord.Image;
                        MemoryStream memoryStream = new MemoryStream();
                        image.Save(memoryStream, ImageFormat.Png);
                        byte[] imageBt = memoryStream.ToArray();

                        cmd.Parameters.AddWithValue("@image", imageBt);
                    }
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", txtPass.Text.Trim());
                    cmd.Parameters.AddWithValue("@date", date);

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    EvolveMessageBox.Show("User has been successfully updated!");
                    foreach (Guna2TextBox txtbox in this.pnlEditUser.Controls.OfType<Guna2TextBox>())
                    {
                        txtbox.Clear();
                    }
                    lblPassValidationInfo.Visible = false;
                    btnUpdate.Enabled = false;
                    timer1.Stop();
                    LoadRecordDb();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
            if (txtPass.Text != txtRepass.Text)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files (*.png)|*.png| jpg files (*.jpg)|*.jpg| bmp files (*.bmp)|*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxRecord.ImageLocation = imgLocation;
            }
        }
    }
}
