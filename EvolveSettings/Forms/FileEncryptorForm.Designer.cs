namespace EvolveSettings.Forms
{
    partial class FileEncryptorForm
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
            this.pnlFiles = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnAddFile = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearFile = new Guna.UI2.WinForms.Guna2Button();
            this.listBoxFile = new System.Windows.Forms.ListBox();
            this.pnlFolders = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblFilesAndFolders = new System.Windows.Forms.Label();
            this.listBoxFolder = new System.Windows.Forms.ListBox();
            this.btnAddFolder = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearFolder = new Guna.UI2.WinForms.Guna2Button();
            this.RadiusListBox1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RadiusListBox2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlEncryptDecrypt = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.txtEncryptorPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEditRepass = new System.Windows.Forms.Label();
            this.txtEncryptorRepass = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkEncryptorShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblEncryptDecrypt = new System.Windows.Forms.Label();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblAddUpdateUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlFiles.SuspendLayout();
            this.pnlFolders.SuspendLayout();
            this.pnlEncryptDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFiles
            // 
            this.pnlFiles.BackColor = System.Drawing.Color.Transparent;
            this.pnlFiles.Controls.Add(this.lblFiles);
            this.pnlFiles.Controls.Add(this.btnAddFile);
            this.pnlFiles.Controls.Add(this.btnClearFile);
            this.pnlFiles.Controls.Add(this.listBoxFile);
            this.pnlFiles.FillColor = System.Drawing.Color.White;
            this.pnlFiles.Location = new System.Drawing.Point(20, 20);
            this.pnlFiles.Margin = new System.Windows.Forms.Padding(28, 3, 5, 10);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Radius = 5;
            this.pnlFiles.ShadowColor = System.Drawing.Color.Black;
            this.pnlFiles.ShadowDepth = 250;
            this.pnlFiles.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlFiles.Size = new System.Drawing.Size(321, 206);
            this.pnlFiles.TabIndex = 1;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(12, 10);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(50, 25);
            this.lblFiles.TabIndex = 1058;
            this.lblFiles.Text = "Files";
            // 
            // btnAddFile
            // 
            this.btnAddFile.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFile.BorderRadius = 15;
            this.btnAddFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFile.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAddFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFile.ForeColor = System.Drawing.Color.White;
            this.btnAddFile.Location = new System.Drawing.Point(22, 154);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(96, 32);
            this.btnAddFile.TabIndex = 1052;
            this.btnAddFile.Text = "Add";
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnClearFile
            // 
            this.btnClearFile.BackColor = System.Drawing.Color.Transparent;
            this.btnClearFile.BorderRadius = 15;
            this.btnClearFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearFile.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnClearFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearFile.ForeColor = System.Drawing.Color.White;
            this.btnClearFile.Location = new System.Drawing.Point(124, 154);
            this.btnClearFile.Name = "btnClearFile";
            this.btnClearFile.Size = new System.Drawing.Size(96, 32);
            this.btnClearFile.TabIndex = 1053;
            this.btnClearFile.Text = "Clear";
            this.btnClearFile.Click += new System.EventHandler(this.btnClearFile_Click);
            // 
            // listBoxFile
            // 
            this.listBoxFile.BackColor = System.Drawing.Color.White;
            this.listBoxFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFile.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFile.FormattingEnabled = true;
            this.listBoxFile.Location = new System.Drawing.Point(22, 51);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(278, 91);
            this.listBoxFile.TabIndex = 1056;
            // 
            // pnlFolders
            // 
            this.pnlFolders.BackColor = System.Drawing.Color.Transparent;
            this.pnlFolders.Controls.Add(this.lblFilesAndFolders);
            this.pnlFolders.Controls.Add(this.listBoxFolder);
            this.pnlFolders.Controls.Add(this.btnAddFolder);
            this.pnlFolders.Controls.Add(this.btnClearFolder);
            this.pnlFolders.FillColor = System.Drawing.Color.White;
            this.pnlFolders.Location = new System.Drawing.Point(358, 20);
            this.pnlFolders.Margin = new System.Windows.Forms.Padding(10, 3, 5, 10);
            this.pnlFolders.Name = "pnlFolders";
            this.pnlFolders.Radius = 5;
            this.pnlFolders.ShadowColor = System.Drawing.Color.Black;
            this.pnlFolders.ShadowDepth = 250;
            this.pnlFolders.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlFolders.Size = new System.Drawing.Size(321, 206);
            this.pnlFolders.TabIndex = 2;
            // 
            // lblFilesAndFolders
            // 
            this.lblFilesAndFolders.AutoSize = true;
            this.lblFilesAndFolders.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilesAndFolders.Location = new System.Drawing.Point(12, 10);
            this.lblFilesAndFolders.Name = "lblFilesAndFolders";
            this.lblFilesAndFolders.Size = new System.Drawing.Size(142, 25);
            this.lblFilesAndFolders.TabIndex = 1059;
            this.lblFilesAndFolders.Text = "Files in Folders";
            // 
            // listBoxFolder
            // 
            this.listBoxFolder.BackColor = System.Drawing.Color.White;
            this.listBoxFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFolder.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFolder.FormattingEnabled = true;
            this.listBoxFolder.Location = new System.Drawing.Point(22, 52);
            this.listBoxFolder.Name = "listBoxFolder";
            this.listBoxFolder.Size = new System.Drawing.Size(278, 91);
            this.listBoxFolder.TabIndex = 1057;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFolder.BorderRadius = 15;
            this.btnAddFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddFolder.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnAddFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddFolder.ForeColor = System.Drawing.Color.White;
            this.btnAddFolder.Location = new System.Drawing.Point(22, 154);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(96, 32);
            this.btnAddFolder.TabIndex = 1055;
            this.btnAddFolder.Text = "Add";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnClearFolder
            // 
            this.btnClearFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnClearFolder.BorderRadius = 15;
            this.btnClearFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearFolder.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnClearFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearFolder.ForeColor = System.Drawing.Color.White;
            this.btnClearFolder.Location = new System.Drawing.Point(124, 154);
            this.btnClearFolder.Name = "btnClearFolder";
            this.btnClearFolder.Size = new System.Drawing.Size(96, 32);
            this.btnClearFolder.TabIndex = 1054;
            this.btnClearFolder.Text = "Clear";
            this.btnClearFolder.Click += new System.EventHandler(this.btnClearFolder_Click);
            // 
            // RadiusListBox1
            // 
            this.RadiusListBox1.BorderRadius = 5;
            this.RadiusListBox1.TargetControl = this.listBoxFile;
            // 
            // RadiusListBox2
            // 
            this.RadiusListBox2.BorderRadius = 5;
            this.RadiusListBox2.TargetControl = this.listBoxFolder;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::EvolveSettings.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::EvolveSettings.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // pnlEncryptDecrypt
            // 
            this.pnlEncryptDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.pnlEncryptDecrypt.Controls.Add(this.lblEditPassword);
            this.pnlEncryptDecrypt.Controls.Add(this.txtEncryptorPass);
            this.pnlEncryptDecrypt.Controls.Add(this.lblEditRepass);
            this.pnlEncryptDecrypt.Controls.Add(this.pnlFiles);
            this.pnlEncryptDecrypt.Controls.Add(this.txtEncryptorRepass);
            this.pnlEncryptDecrypt.Controls.Add(this.chkEncryptorShowPass);
            this.pnlEncryptDecrypt.Controls.Add(this.pnlFolders);
            this.pnlEncryptDecrypt.Controls.Add(this.lblEncryptDecrypt);
            this.pnlEncryptDecrypt.Controls.Add(this.btnEncrypt);
            this.pnlEncryptDecrypt.Controls.Add(this.btnDecrypt);
            this.pnlEncryptDecrypt.Controls.Add(this.btnClearAll);
            this.pnlEncryptDecrypt.FillColor = System.Drawing.Color.White;
            this.pnlEncryptDecrypt.Location = new System.Drawing.Point(303, 59);
            this.pnlEncryptDecrypt.Margin = new System.Windows.Forms.Padding(28, 3, 5, 25);
            this.pnlEncryptDecrypt.Name = "pnlEncryptDecrypt";
            this.pnlEncryptDecrypt.Radius = 5;
            this.pnlEncryptDecrypt.ShadowColor = System.Drawing.Color.Black;
            this.pnlEncryptDecrypt.ShadowDepth = 250;
            this.pnlEncryptDecrypt.ShadowShift = 0;
            this.pnlEncryptDecrypt.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlEncryptDecrypt.Size = new System.Drawing.Size(700, 435);
            this.pnlEncryptDecrypt.TabIndex = 3;
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPassword.Location = new System.Drawing.Point(17, 277);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(75, 17);
            this.lblEditPassword.TabIndex = 1036;
            this.lblEditPassword.Text = "Password : ";
            // 
            // txtEncryptorPass
            // 
            this.txtEncryptorPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptorPass.Animated = true;
            this.txtEncryptorPass.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncryptorPass.BorderRadius = 15;
            this.txtEncryptorPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncryptorPass.DefaultText = "";
            this.txtEncryptorPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEncryptorPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEncryptorPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncryptorPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncryptorPass.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncryptorPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptorPass.ForeColor = System.Drawing.Color.Black;
            this.txtEncryptorPass.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncryptorPass.Location = new System.Drawing.Point(20, 296);
            this.txtEncryptorPass.MaxLength = 8;
            this.txtEncryptorPass.Name = "txtEncryptorPass";
            this.txtEncryptorPass.PasswordChar = '*';
            this.txtEncryptorPass.PlaceholderText = "";
            this.txtEncryptorPass.SelectedText = "";
            this.txtEncryptorPass.Size = new System.Drawing.Size(321, 34);
            this.txtEncryptorPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEncryptorPass.TabIndex = 1065;
            this.txtEncryptorPass.TextChanged += new System.EventHandler(this.txtEncryptorPass_TextChanged);
            // 
            // lblEditRepass
            // 
            this.lblEditRepass.AutoSize = true;
            this.lblEditRepass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRepass.Location = new System.Drawing.Point(355, 277);
            this.lblEditRepass.Name = "lblEditRepass";
            this.lblEditRepass.Size = new System.Drawing.Size(114, 17);
            this.lblEditRepass.TabIndex = 1064;
            this.lblEditRepass.Text = "Confirm Password";
            // 
            // txtEncryptorRepass
            // 
            this.txtEncryptorRepass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptorRepass.Animated = true;
            this.txtEncryptorRepass.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncryptorRepass.BorderRadius = 15;
            this.txtEncryptorRepass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncryptorRepass.DefaultText = "";
            this.txtEncryptorRepass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEncryptorRepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEncryptorRepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncryptorRepass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncryptorRepass.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncryptorRepass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptorRepass.ForeColor = System.Drawing.Color.Black;
            this.txtEncryptorRepass.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncryptorRepass.Location = new System.Drawing.Point(360, 296);
            this.txtEncryptorRepass.MaxLength = 8;
            this.txtEncryptorRepass.Name = "txtEncryptorRepass";
            this.txtEncryptorRepass.PasswordChar = '*';
            this.txtEncryptorRepass.PlaceholderText = "";
            this.txtEncryptorRepass.SelectedText = "";
            this.txtEncryptorRepass.Size = new System.Drawing.Size(319, 34);
            this.txtEncryptorRepass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEncryptorRepass.TabIndex = 1061;
            // 
            // chkEncryptorShowPass
            // 
            this.chkEncryptorShowPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEncryptorShowPass.Animated = true;
            this.chkEncryptorShowPass.AutoSize = true;
            this.chkEncryptorShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkEncryptorShowPass.CheckedState.BorderRadius = 0;
            this.chkEncryptorShowPass.CheckedState.BorderThickness = 0;
            this.chkEncryptorShowPass.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkEncryptorShowPass.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEncryptorShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkEncryptorShowPass.Location = new System.Drawing.Point(240, 336);
            this.chkEncryptorShowPass.Name = "chkEncryptorShowPass";
            this.chkEncryptorShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkEncryptorShowPass.TabIndex = 1060;
            this.chkEncryptorShowPass.Text = "Show Password";
            this.chkEncryptorShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkEncryptorShowPass.UncheckedState.BorderRadius = 0;
            this.chkEncryptorShowPass.UncheckedState.BorderThickness = 0;
            this.chkEncryptorShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkEncryptorShowPass.CheckedChanged += new System.EventHandler(this.chkEncryptorShowPass_CheckedChanged);
            // 
            // lblEncryptDecrypt
            // 
            this.lblEncryptDecrypt.AutoSize = true;
            this.lblEncryptDecrypt.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptDecrypt.Location = new System.Drawing.Point(15, 242);
            this.lblEncryptDecrypt.Name = "lblEncryptDecrypt";
            this.lblEncryptDecrypt.Size = new System.Drawing.Size(160, 25);
            this.lblEncryptDecrypt.TabIndex = 1063;
            this.lblEncryptDecrypt.Text = "Encrypt/Decrypt";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BorderRadius = 15;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(20, 390);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(96, 32);
            this.btnEncrypt.TabIndex = 1061;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BorderRadius = 15;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(122, 390);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(96, 32);
            this.btnDecrypt.TabIndex = 1062;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.BackColor = System.Drawing.Color.Transparent;
            this.btnClearAll.BorderRadius = 15;
            this.btnClearAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearAll.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(583, 390);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(96, 32);
            this.btnClearAll.TabIndex = 1060;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 400;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::EvolveSettings.Properties.Resources.encrypted_file;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(92, 134);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(91, 91);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1028;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(712, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblAddUpdateUser);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(284, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(739, 42);
            this.pnlHeader.TabIndex = 10300;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblAddUpdateUser
            // 
            this.lblAddUpdateUser.AutoSize = true;
            this.lblAddUpdateUser.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdateUser.ForeColor = System.Drawing.Color.White;
            this.lblAddUpdateUser.Location = new System.Drawing.Point(14, 9);
            this.lblAddUpdateUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddUpdateUser.Name = "lblAddUpdateUser";
            this.lblAddUpdateUser.Size = new System.Drawing.Size(116, 21);
            this.lblAddUpdateUser.TabIndex = 1;
            this.lblAddUpdateUser.Text = "File Encryptor";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.guna2PictureBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 512);
            this.panel3.TabIndex = 10301;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(63, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "File Encryption";
            // 
            // FileEncryptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 512);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlEncryptDecrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileEncryptorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileEncryptorForm";
            this.pnlFiles.ResumeLayout(false);
            this.pnlFiles.PerformLayout();
            this.pnlFolders.ResumeLayout(false);
            this.pnlFolders.PerformLayout();
            this.pnlEncryptDecrypt.ResumeLayout(false);
            this.pnlEncryptDecrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFiles;
        private Guna.UI2.WinForms.Guna2Elipse RadiusListBox1;
        private Guna.UI2.WinForms.Guna2Elipse RadiusListBox2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFolders;
        private System.Windows.Forms.Label lblFilesAndFolders;
        private System.Windows.Forms.ListBox listBoxFolder;
        public Guna.UI2.WinForms.Guna2Button btnAddFolder;
        public Guna.UI2.WinForms.Guna2Button btnClearFolder;
        private System.Windows.Forms.Label lblFiles;
        public Guna.UI2.WinForms.Guna2Button btnAddFile;
        public Guna.UI2.WinForms.Guna2Button btnClearFile;
        private System.Windows.Forms.ListBox listBoxFile;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlEncryptDecrypt;
        private System.Windows.Forms.Label lblEditPassword;
        public Guna.UI2.WinForms.Guna2TextBox txtEncryptorPass;
        private System.Windows.Forms.Label lblEditRepass;
        public Guna.UI2.WinForms.Guna2TextBox txtEncryptorRepass;
        private Guna.UI2.WinForms.Guna2CheckBox chkEncryptorShowPass;
        private System.Windows.Forms.Label lblEncryptDecrypt;
        public Guna.UI2.WinForms.Guna2Button btnEncrypt;
        public Guna.UI2.WinForms.Guna2Button btnDecrypt;
        public Guna.UI2.WinForms.Guna2Button btnClearAll;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label btnClose;
        public System.Windows.Forms.Label lblAddUpdateUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
    }
}