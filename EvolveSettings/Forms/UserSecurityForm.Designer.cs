namespace EvolveSettings.Forms
{
    partial class UserSecurityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFileEncryptor = new Guna.UI2.WinForms.Guna2Button();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFileDescription = new System.Windows.Forms.Label();
            this.chkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnAddFileRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.txtRepass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRePass = new System.Windows.Forms.Label();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFileFolderLocation = new System.Windows.Forms.Label();
            this.txtFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pnlGridView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDbFileInfo = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlEncryptor = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnPwEncryption = new Guna.UI2.WinForms.Guna2Button();
            this.lblEncrypting = new System.Windows.Forms.Label();
            this.dgvEncryptor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlGridView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlDbFileInfo.SuspendLayout();
            this.pnlEncryptor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncryptor)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFileEncryptor
            // 
            this.btnFileEncryptor.Animated = true;
            this.btnFileEncryptor.BorderRadius = 15;
            this.btnFileEncryptor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFileEncryptor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFileEncryptor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFileEncryptor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFileEncryptor.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnFileEncryptor.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileEncryptor.ForeColor = System.Drawing.Color.White;
            this.btnFileEncryptor.Location = new System.Drawing.Point(17, 61);
            this.btnFileEncryptor.Name = "btnFileEncryptor";
            this.btnFileEncryptor.Size = new System.Drawing.Size(139, 32);
            this.btnFileEncryptor.TabIndex = 1065;
            this.btnFileEncryptor.Text = "File Encryptor";
            this.btnFileEncryptor.Click += new System.EventHandler(this.btnFileEncryptor_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Animated = true;
            this.txtDescription.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDescription.BorderRadius = 15;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDescription.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDescription.Location = new System.Drawing.Point(30, 133);
            this.txtDescription.MaximumSize = new System.Drawing.Size(375, 34);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(285, 34);
            this.txtDescription.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDescription.TabIndex = 1064;
            // 
            // lblFileDescription
            // 
            this.lblFileDescription.AutoSize = true;
            this.lblFileDescription.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDescription.Location = new System.Drawing.Point(27, 117);
            this.lblFileDescription.Name = "lblFileDescription";
            this.lblFileDescription.Size = new System.Drawing.Size(104, 17);
            this.lblFileDescription.TabIndex = 1063;
            this.lblFileDescription.Text = "File Description :";
            // 
            // chkShowPass
            // 
            this.chkShowPass.Animated = true;
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkShowPass.CheckedState.BorderRadius = 0;
            this.chkShowPass.CheckedState.BorderThickness = 0;
            this.chkShowPass.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkShowPass.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkShowPass.Location = new System.Drawing.Point(549, 171);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkShowPass.TabIndex = 1062;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPass.UncheckedState.BorderRadius = 0;
            this.chkShowPass.UncheckedState.BorderThickness = 0;
            this.chkShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnAddFileRecord
            // 
            this.btnAddFileRecord.Animated = true;
            this.btnAddFileRecord.BorderRadius = 15;
            this.btnAddFileRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFileRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFileRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFileRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFileRecord.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAddFileRecord.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFileRecord.ForeColor = System.Drawing.Color.White;
            this.btnAddFileRecord.Location = new System.Drawing.Point(451, 212);
            this.btnAddFileRecord.Name = "btnAddFileRecord";
            this.btnAddFileRecord.Size = new System.Drawing.Size(96, 32);
            this.btnAddFileRecord.TabIndex = 1061;
            this.btnAddFileRecord.Text = "Add New";
            this.btnAddFileRecord.Click += new System.EventHandler(this.btnAddFileRecord_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(553, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 1060;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 21);
            this.label6.TabIndex = 1059;
            this.label6.Text = "Update Record Information";
            // 
            // txtPass
            // 
            this.txtPass.Animated = true;
            this.txtPass.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPass.BorderRadius = 15;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPass.Location = new System.Drawing.Point(364, 79);
            this.txtPass.MaximumSize = new System.Drawing.Size(375, 34);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(285, 34);
            this.txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 1051;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(361, 63);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(71, 17);
            this.lblPass.TabIndex = 1050;
            this.lblPass.Text = "Password :";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.Color.White;
            this.txtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateCreated.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCreated.Location = new System.Drawing.Point(364, 173);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(126, 15);
            this.txtDateCreated.TabIndex = 1049;
            this.txtDateCreated.Text = "Date";
            // 
            // txtRepass
            // 
            this.txtRepass.Animated = true;
            this.txtRepass.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtRepass.BorderRadius = 15;
            this.txtRepass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepass.DefaultText = "";
            this.txtRepass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRepass.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtRepass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepass.ForeColor = System.Drawing.Color.Black;
            this.txtRepass.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtRepass.Location = new System.Drawing.Point(364, 133);
            this.txtRepass.MaximumSize = new System.Drawing.Size(375, 34);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.PlaceholderText = "";
            this.txtRepass.SelectedText = "";
            this.txtRepass.Size = new System.Drawing.Size(285, 34);
            this.txtRepass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRepass.TabIndex = 1048;
            // 
            // lblRePass
            // 
            this.lblRePass.AutoSize = true;
            this.lblRePass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRePass.Location = new System.Drawing.Point(361, 118);
            this.lblRePass.Name = "lblRePass";
            this.lblRePass.Size = new System.Drawing.Size(121, 17);
            this.lblRePass.TabIndex = 1047;
            this.lblRePass.Text = "Confirm Password :";
            // 
            // txtLocation
            // 
            this.txtLocation.Animated = true;
            this.txtLocation.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtLocation.BorderRadius = 15;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtLocation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.Color.Black;
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtLocation.Location = new System.Drawing.Point(30, 188);
            this.txtLocation.MaximumSize = new System.Drawing.Size(375, 34);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(285, 34);
            this.txtLocation.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtLocation.TabIndex = 1046;
            // 
            // lblFileFolderLocation
            // 
            this.lblFileFolderLocation.AutoSize = true;
            this.lblFileFolderLocation.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileFolderLocation.Location = new System.Drawing.Point(27, 172);
            this.lblFileFolderLocation.Name = "lblFileFolderLocation";
            this.lblFileFolderLocation.Size = new System.Drawing.Size(129, 17);
            this.lblFileFolderLocation.TabIndex = 1045;
            this.lblFileFolderLocation.Text = "File/Folder Location :";
            // 
            // txtFileName
            // 
            this.txtFileName.Animated = true;
            this.txtFileName.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtFileName.BorderRadius = 15;
            this.txtFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileName.DefaultText = "";
            this.txtFileName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFileName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFileName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFileName.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtFileName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.ForeColor = System.Drawing.Color.Black;
            this.txtFileName.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtFileName.Location = new System.Drawing.Point(30, 79);
            this.txtFileName.MaximumSize = new System.Drawing.Size(375, 34);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.PlaceholderText = "";
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(285, 34);
            this.txtFileName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtFileName.TabIndex = 1044;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(27, 63);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(73, 17);
            this.lblFileName.TabIndex = 1043;
            this.lblFileName.Text = "File Name :";
            // 
            // pnlGridView
            // 
            this.pnlGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridView.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridView.Controls.Add(this.tableLayoutPanel1);
            this.pnlGridView.Controls.Add(this.dgvEncryptor);
            this.pnlGridView.FillColor = System.Drawing.Color.White;
            this.pnlGridView.Location = new System.Drawing.Point(20, 64);
            this.pnlGridView.Margin = new System.Windows.Forms.Padding(10, 3, 5, 25);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Radius = 5;
            this.pnlGridView.ShadowColor = System.Drawing.Color.Black;
            this.pnlGridView.ShadowDepth = 250;
            this.pnlGridView.ShadowShift = 0;
            this.pnlGridView.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlGridView.Size = new System.Drawing.Size(1281, 679);
            this.pnlGridView.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pnlDbFileInfo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlEncryptor, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 290);
            this.tableLayoutPanel1.TabIndex = 1070;
            // 
            // pnlDbFileInfo
            // 
            this.pnlDbFileInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlDbFileInfo.Controls.Add(this.label6);
            this.pnlDbFileInfo.Controls.Add(this.btnUpdate);
            this.pnlDbFileInfo.Controls.Add(this.btnAddFileRecord);
            this.pnlDbFileInfo.Controls.Add(this.chkShowPass);
            this.pnlDbFileInfo.Controls.Add(this.txtDescription);
            this.pnlDbFileInfo.Controls.Add(this.lblFileName);
            this.pnlDbFileInfo.Controls.Add(this.lblFileDescription);
            this.pnlDbFileInfo.Controls.Add(this.txtPass);
            this.pnlDbFileInfo.Controls.Add(this.txtFileName);
            this.pnlDbFileInfo.Controls.Add(this.lblPass);
            this.pnlDbFileInfo.Controls.Add(this.txtDateCreated);
            this.pnlDbFileInfo.Controls.Add(this.lblFileFolderLocation);
            this.pnlDbFileInfo.Controls.Add(this.txtRepass);
            this.pnlDbFileInfo.Controls.Add(this.txtLocation);
            this.pnlDbFileInfo.Controls.Add(this.lblRePass);
            this.pnlDbFileInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDbFileInfo.FillColor = System.Drawing.Color.White;
            this.pnlDbFileInfo.Location = new System.Drawing.Point(560, 20);
            this.pnlDbFileInfo.Margin = new System.Windows.Forms.Padding(10, 20, 20, 3);
            this.pnlDbFileInfo.Name = "pnlDbFileInfo";
            this.pnlDbFileInfo.Radius = 5;
            this.pnlDbFileInfo.ShadowColor = System.Drawing.Color.Black;
            this.pnlDbFileInfo.ShadowDepth = 250;
            this.pnlDbFileInfo.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlDbFileInfo.Size = new System.Drawing.Size(701, 267);
            this.pnlDbFileInfo.TabIndex = 1070;
            // 
            // pnlEncryptor
            // 
            this.pnlEncryptor.BackColor = System.Drawing.Color.Transparent;
            this.pnlEncryptor.Controls.Add(this.btnPwEncryption);
            this.pnlEncryptor.Controls.Add(this.lblEncrypting);
            this.pnlEncryptor.Controls.Add(this.btnFileEncryptor);
            this.pnlEncryptor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncryptor.FillColor = System.Drawing.Color.White;
            this.pnlEncryptor.Location = new System.Drawing.Point(20, 20);
            this.pnlEncryptor.Margin = new System.Windows.Forms.Padding(20, 20, 10, 3);
            this.pnlEncryptor.Name = "pnlEncryptor";
            this.pnlEncryptor.Radius = 5;
            this.pnlEncryptor.ShadowColor = System.Drawing.Color.Black;
            this.pnlEncryptor.ShadowDepth = 250;
            this.pnlEncryptor.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlEncryptor.Size = new System.Drawing.Size(520, 267);
            this.pnlEncryptor.TabIndex = 1069;
            // 
            // btnPwEncryption
            // 
            this.btnPwEncryption.BackColor = System.Drawing.Color.Transparent;
            this.btnPwEncryption.BorderRadius = 15;
            this.btnPwEncryption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPwEncryption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPwEncryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPwEncryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPwEncryption.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPwEncryption.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPwEncryption.ForeColor = System.Drawing.Color.White;
            this.btnPwEncryption.Location = new System.Drawing.Point(17, 99);
            this.btnPwEncryption.Name = "btnPwEncryption";
            this.btnPwEncryption.Size = new System.Drawing.Size(139, 32);
            this.btnPwEncryption.TabIndex = 1067;
            this.btnPwEncryption.Text = "Password Encryptor";
            this.btnPwEncryption.Click += new System.EventHandler(this.btnPwEncryption_Click);
            // 
            // lblEncrypting
            // 
            this.lblEncrypting.AutoSize = true;
            this.lblEncrypting.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypting.Location = new System.Drawing.Point(12, 13);
            this.lblEncrypting.Name = "lblEncrypting";
            this.lblEncrypting.Size = new System.Drawing.Size(94, 21);
            this.lblEncrypting.TabIndex = 1066;
            this.lblEncrypting.Text = "Encryption";
            // 
            // dgvEncryptor
            // 
            this.dgvEncryptor.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvEncryptor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEncryptor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEncryptor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvEncryptor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEncryptor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEncryptor.ColumnHeadersHeight = 50;
            this.dgvEncryptor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column0,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEncryptor.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEncryptor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.dgvEncryptor.Location = new System.Drawing.Point(20, 299);
            this.dgvEncryptor.Name = "dgvEncryptor";
            this.dgvEncryptor.ReadOnly = true;
            this.dgvEncryptor.RowHeadersVisible = false;
            this.dgvEncryptor.RowTemplate.DividerHeight = 2;
            this.dgvEncryptor.RowTemplate.Height = 50;
            this.dgvEncryptor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEncryptor.Size = new System.Drawing.Size(1241, 359);
            this.dgvEncryptor.TabIndex = 5;
            this.dgvEncryptor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEncryptor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvEncryptor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvEncryptor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvEncryptor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvEncryptor.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.dgvEncryptor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.dgvEncryptor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(246)))));
            this.dgvEncryptor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEncryptor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEncryptor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvEncryptor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEncryptor.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvEncryptor.ThemeStyle.ReadOnly = true;
            this.dgvEncryptor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvEncryptor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEncryptor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEncryptor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEncryptor.ThemeStyle.RowsStyle.Height = 50;
            this.dgvEncryptor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvEncryptor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvEncryptor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncryptor_CellClick);
            this.dgvEncryptor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPwManager_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "NO";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column0
            // 
            this.Column0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column0.HeaderText = "ID";
            this.Column0.Name = "Column0";
            this.Column0.ReadOnly = true;
            this.Column0.Visible = false;
            this.Column0.Width = 41;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "File Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 76;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Password";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Location";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Date Created";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 89;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::EvolveSettings.Properties.Resources.edit;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Visible = false;
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::EvolveSettings.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 5;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1322, 49);
            this.pnlHeader.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 38);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "User(s) Security";
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::EvolveSettings.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::EvolveSettings.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // UserSecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 762);
            this.Controls.Add(this.pnlGridView);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSecurityForm";
            this.Text = "FileEnctyptorDbForm";
            this.pnlGridView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlDbFileInfo.ResumeLayout(false);
            this.pnlDbFileInfo.PerformLayout();
            this.pnlEncryptor.ResumeLayout(false);
            this.pnlEncryptor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncryptor)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label lblFileDescription;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowPass;
        private Guna.UI2.WinForms.Guna2Button btnAddFileRecord;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        public System.Windows.Forms.TextBox txtDateCreated;
        public Guna.UI2.WinForms.Guna2TextBox txtRepass;
        private System.Windows.Forms.Label lblRePass;
        public Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private System.Windows.Forms.Label lblFileFolderLocation;
        public Guna.UI2.WinForms.Guna2TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlGridView;
        private Guna.UI2.WinForms.Guna2DataGridView dgvEncryptor;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnFileEncryptor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDbFileInfo;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlEncryptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label lblEncrypting;
        public Guna.UI2.WinForms.Guna2Button btnPwEncryption;
    }
}