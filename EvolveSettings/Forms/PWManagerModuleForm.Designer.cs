namespace EvolveSettings.Forms
{
    partial class PWManagerModuleForm
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnPassGen = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRepass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRecordName = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDateCreated = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.Label();
            this.lblAddUpdateUser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlPwValidation = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassValidationInfo = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBoxRecord = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPwValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 400;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btnPassGen.TabIndex = 1035;
            this.btnPassGen.Text = "Password Generator";
            this.btnPassGen.Click += new System.EventHandler(this.btnPassGen_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEmail.Location = new System.Drawing.Point(307, 328);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(333, 34);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 1032;
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
            this.txtRepass.Location = new System.Drawing.Point(308, 270);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.PlaceholderText = "";
            this.txtRepass.SelectedText = "";
            this.txtRepass.Size = new System.Drawing.Size(332, 34);
            this.txtRepass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRepass.TabIndex = 1031;
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
            this.txtPass.Location = new System.Drawing.Point(307, 211);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(333, 34);
            this.txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 1030;
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtUserName.BorderRadius = 15;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtUserName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtUserName.Location = new System.Drawing.Point(308, 153);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(332, 34);
            this.txtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUserName.TabIndex = 1029;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtRecordName
            // 
            this.txtRecordName.Animated = true;
            this.txtRecordName.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtRecordName.BorderRadius = 15;
            this.txtRecordName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecordName.DefaultText = "";
            this.txtRecordName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRecordName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRecordName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecordName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRecordName.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtRecordName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecordName.ForeColor = System.Drawing.Color.Black;
            this.txtRecordName.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtRecordName.Location = new System.Drawing.Point(307, 94);
            this.txtRecordName.Name = "txtRecordName";
            this.txtRecordName.PasswordChar = '\0';
            this.txtRecordName.PlaceholderText = "";
            this.txtRecordName.SelectedText = "";
            this.txtRecordName.Size = new System.Drawing.Size(333, 34);
            this.txtRecordName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRecordName.TabIndex = 1028;
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
            this.chkShowPass.Location = new System.Drawing.Point(540, 308);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkShowPass.TabIndex = 1036;
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
            this.btnSave.TabIndex = 1033;
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
            this.btnUpdate.TabIndex = 1029;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClear.TabIndex = 1034;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 1025;
            this.label7.Text = "Record Name :";
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
            this.txtDateCreated.TabIndex = 1038;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 1023;
            this.label6.Text = "Confirm Password : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1021;
            this.label4.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1020;
            this.label3.Text = "Username : ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.pnlHeader.TabIndex = 1039;
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
            this.lblAddUpdateUser.Size = new System.Drawing.Size(142, 21);
            this.lblAddUpdateUser.TabIndex = 1;
            this.lblAddUpdateUser.Text = "Add/Update User";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pnlPwValidation);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.pictureBoxRecord);
            this.panel2.Controls.Add(this.lblCurrentUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 461);
            this.panel2.TabIndex = 1040;
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
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.FillColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Image = global::EvolveSettings.Properties.Resources.add;
            this.btnBrowse.ImageRotate = 0F;
            this.btnBrowse.Location = new System.Drawing.Point(155, 98);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBrowse.Size = new System.Drawing.Size(26, 26);
            this.btnBrowse.TabIndex = 1024;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.UseTransparentBackground = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxRecord
            // 
            this.pictureBoxRecord.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRecord.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxRecord.Image = global::EvolveSettings.Properties.Resources.evolve_settings;
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
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblCurrentUser.Location = new System.Drawing.Point(50, 188);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(181, 25);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Password Manager";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(624, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(16, 20);
            this.txtID.TabIndex = 10280;
            this.txtID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 6);
            this.label2.TabIndex = 1029;
            this.label2.Text = "ID :  Set Not Visible";
            this.label2.Visible = false;
            // 
            // PWManagerModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPassGen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtRecordName);
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
            this.Name = "PWManagerModuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PWManagerModuleForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPwValidation.ResumeLayout(false);
            this.pnlPwValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2Button btnPassGen;
        public Guna.UI2.WinForms.Guna2TextBox txtEmail;
        public Guna.UI2.WinForms.Guna2TextBox txtRepass;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        public Guna.UI2.WinForms.Guna2TextBox txtUserName;
        public Guna.UI2.WinForms.Guna2TextBox txtRecordName;
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
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label pictureBoxClose;
        public System.Windows.Forms.Label lblAddUpdateUser;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlPwValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassValidationInfo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnBrowse;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxRecord;
        private System.Windows.Forms.Label lblCurrentUser;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
    }
}