namespace EvolveSettings.Forms
{
    partial class EncryptorModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptorModuleForm));
            this.EncryptoModuleForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassValidationInfo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.Label();
            this.lblAddUpdateUser = new System.Windows.Forms.Label();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPwValidation = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pictureBoxRecord = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnPassGen = new Guna.UI2.WinForms.Guna2Button();
            this.txtRepass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFileName = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPwValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // EncryptoModuleForm
            // 
            this.EncryptoModuleForm.AnimateWindow = true;
            this.EncryptoModuleForm.AnimationInterval = 400;
            this.EncryptoModuleForm.BorderRadius = 5;
            this.EncryptoModuleForm.ContainerControl = this;
            this.EncryptoModuleForm.DockIndicatorTransparencyValue = 0.6D;
            this.EncryptoModuleForm.DragForm = false;
            this.EncryptoModuleForm.ResizeForm = false;
            this.EncryptoModuleForm.TransparentWhileDrag = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 6);
            this.label2.TabIndex = 10288;
            this.label2.Text = "ID :  Set Not Visible";
            this.label2.Visible = false;
            // 
            // lblPassValidationInfo
            // 
            this.lblPassValidationInfo.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassValidationInfo.ForeColor = System.Drawing.Color.White;
            this.lblPassValidationInfo.Location = new System.Drawing.Point(25, 39);
            this.lblPassValidationInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassValidationInfo.Name = "lblPassValidationInfo";
            this.lblPassValidationInfo.Size = new System.Drawing.Size(189, 113);
            this.lblPassValidationInfo.TabIndex = 1012;
            this.lblPassValidationInfo.Text = "Password not entered";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.pictureBoxClose);
            this.pnlHeader.Controls.Add(this.lblAddUpdateUser);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(284, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(378, 42);
            this.pnlHeader.TabIndex = 10298;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.AutoSize = true;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBoxClose.Location = new System.Drawing.Point(352, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxClose.TabIndex = 28;
            this.pictureBoxClose.Text = "X";
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblAddUpdateUser
            // 
            this.lblAddUpdateUser.AutoSize = true;
            this.lblAddUpdateUser.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUpdateUser.ForeColor = System.Drawing.Color.White;
            this.lblAddUpdateUser.Location = new System.Drawing.Point(14, 9);
            this.lblAddUpdateUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddUpdateUser.Name = "lblAddUpdateUser";
            this.lblAddUpdateUser.Size = new System.Drawing.Size(129, 21);
            this.lblAddUpdateUser.TabIndex = 1;
            this.lblAddUpdateUser.Text = "Add File Record";
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblCurrentUser.Location = new System.Drawing.Point(41, 188);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(203, 25);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Encryptor File Record";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(624, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(16, 20);
            this.txtID.TabIndex = 10300;
            this.txtID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 1013;
            this.label1.Text = "Password Validation:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pnlPwValidation);
            this.panel2.Controls.Add(this.pictureBoxRecord);
            this.panel2.Controls.Add(this.lblCurrentUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 461);
            this.panel2.TabIndex = 10299;
            // 
            // pnlPwValidation
            // 
            this.pnlPwValidation.BackColor = System.Drawing.Color.Transparent;
            this.pnlPwValidation.Controls.Add(this.label1);
            this.pnlPwValidation.Controls.Add(this.lblPassValidationInfo);
            this.pnlPwValidation.FillColor = System.Drawing.Color.MidnightBlue;
            this.pnlPwValidation.Location = new System.Drawing.Point(24, 274);
            this.pnlPwValidation.Name = "pnlPwValidation";
            this.pnlPwValidation.Radius = 5;
            this.pnlPwValidation.ShadowColor = System.Drawing.Color.Black;
            this.pnlPwValidation.ShadowDepth = 250;
            this.pnlPwValidation.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlPwValidation.Size = new System.Drawing.Size(236, 174);
            this.pnlPwValidation.TabIndex = 1027;
            // 
            // pictureBoxRecord
            // 
            this.pictureBoxRecord.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRecord.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxRecord.Image = global::EvolveSettings.Properties.Resources.encrypted_file;
            this.pictureBoxRecord.ImageRotate = 0F;
            this.pictureBoxRecord.Location = new System.Drawing.Point(94, 94);
            this.pictureBoxRecord.Name = "pictureBoxRecord";
            this.pictureBoxRecord.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxRecord.Size = new System.Drawing.Size(91, 91);
            this.pictureBoxRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRecord.TabIndex = 1023;
            this.pictureBoxRecord.TabStop = false;
            this.pictureBoxRecord.UseTransparentBackground = true;
            // 
            // btnPassGen
            // 
            this.btnPassGen.Animated = true;
            this.btnPassGen.BackColor = System.Drawing.Color.Transparent;
            this.btnPassGen.BorderRadius = 15;
            this.btnPassGen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPassGen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPassGen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPassGen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPassGen.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPassGen.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassGen.ForeColor = System.Drawing.Color.White;
            this.btnPassGen.Location = new System.Drawing.Point(307, 404);
            this.btnPassGen.Name = "btnPassGen";
            this.btnPassGen.Size = new System.Drawing.Size(133, 32);
            this.btnPassGen.TabIndex = 3007;
            this.btnPassGen.Text = "Password Generator";
            this.btnPassGen.Click += new System.EventHandler(this.btnPassGen_Click);
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
            this.txtRepass.Location = new System.Drawing.Point(307, 328);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.PlaceholderText = "";
            this.txtRepass.SelectedText = "";
            this.txtRepass.Size = new System.Drawing.Size(333, 34);
            this.txtRepass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRepass.TabIndex = 3004;
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
            this.txtPass.Location = new System.Drawing.Point(308, 270);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(332, 34);
            this.txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 3003;
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
            this.txtLocation.Location = new System.Drawing.Point(307, 211);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(333, 34);
            this.txtLocation.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtLocation.TabIndex = 3002;
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
            this.txtDescription.Location = new System.Drawing.Point(308, 153);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(332, 34);
            this.txtDescription.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDescription.TabIndex = 3001;
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
            this.txtFileName.Location = new System.Drawing.Point(307, 94);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.PasswordChar = '\0';
            this.txtFileName.PlaceholderText = "";
            this.txtFileName.SelectedText = "";
            this.txtFileName.Size = new System.Drawing.Size(333, 34);
            this.txtFileName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtFileName.TabIndex = 3000;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
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
            this.chkShowPass.Location = new System.Drawing.Point(540, 367);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkShowPass.TabIndex = 3008;
            this.chkShowPass.Text = "Show Password";
            this.chkShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPass.UncheckedState.BorderRadius = 0;
            this.chkShowPass.UncheckedState.BorderThickness = 0;
            this.chkShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 15;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(544, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 3005;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(544, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 10287;
            this.btnUpdate.Text = "Update";
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 15;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(444, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 32);
            this.btnClear.TabIndex = 3006;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 10285;
            this.label7.Text = "File Name :";
            // 
            // txtDateCreated
            // 
            this.txtDateCreated.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateCreated.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateCreated.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateCreated.Location = new System.Drawing.Point(308, 369);
            this.txtDateCreated.Name = "txtDateCreated";
            this.txtDateCreated.ReadOnly = true;
            this.txtDateCreated.Size = new System.Drawing.Size(108, 15);
            this.txtDateCreated.TabIndex = 10297;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 10284;
            this.label6.Text = "Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 10283;
            this.label5.Text = "Confirm Password : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 10282;
            this.label4.Text = "File/Folder Location :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 10281;
            this.label3.Text = "File Description :";
            // 
            // EncryptorModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPassGen);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDateCreated);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EncryptorModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptorModuleForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPwValidation.ResumeLayout(false);
            this.pnlPwValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm EncryptoModuleForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label pictureBoxClose;
        public System.Windows.Forms.Label lblAddUpdateUser;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlPwValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassValidationInfo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxRecord;
        private System.Windows.Forms.Label lblCurrentUser;
        public Guna.UI2.WinForms.Guna2Button btnPassGen;
        public Guna.UI2.WinForms.Guna2TextBox txtRepass;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        public Guna.UI2.WinForms.Guna2TextBox txtLocation;
        public Guna.UI2.WinForms.Guna2TextBox txtDescription;
        public Guna.UI2.WinForms.Guna2TextBox txtFileName;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowPass;
        public Guna.UI2.WinForms.Guna2Button btnSave;
        public Guna.UI2.WinForms.Guna2Button btnUpdate;
        public Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDateCreated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}