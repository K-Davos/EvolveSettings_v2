
namespace EvolveSettings
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.frmSignUp = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSignupPassGen = new Guna.UI2.WinForms.Guna2Button();
            this.txtRepass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkSignupShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.signup_close = new System.Windows.Forms.Label();
            this.txtLoginHere = new System.Windows.Forms.Label();
            this.lblAlreadyAccount = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblGetStarted = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlPwValidation = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassValidationInfo = new System.Windows.Forms.Label();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.pnlPwValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // frmSignUp
            // 
            this.frmSignUp.AnimateWindow = true;
            this.frmSignUp.AnimationInterval = 400;
            this.frmSignUp.BorderRadius = 5;
            this.frmSignUp.ContainerControl = this;
            this.frmSignUp.DockIndicatorTransparencyValue = 0.6D;
            this.frmSignUp.DragForm = false;
            this.frmSignUp.ResizeForm = false;
            this.frmSignUp.TransparentWhileDrag = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSignupPassGen
            // 
            this.btnSignupPassGen.Animated = true;
            this.btnSignupPassGen.BackColor = System.Drawing.Color.Transparent;
            this.btnSignupPassGen.BorderRadius = 15;
            this.btnSignupPassGen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignupPassGen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignupPassGen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignupPassGen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignupPassGen.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSignupPassGen.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignupPassGen.ForeColor = System.Drawing.Color.White;
            this.btnSignupPassGen.Location = new System.Drawing.Point(468, 338);
            this.btnSignupPassGen.Name = "btnSignupPassGen";
            this.btnSignupPassGen.Size = new System.Drawing.Size(142, 32);
            this.btnSignupPassGen.TabIndex = 26;
            this.btnSignupPassGen.Text = "Password Generator";
            this.btnSignupPassGen.Click += new System.EventHandler(this.btnSignupPassGen_Click);
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
            this.txtRepass.Location = new System.Drawing.Point(306, 274);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.PlaceholderText = "";
            this.txtRepass.SelectedText = "";
            this.txtRepass.Size = new System.Drawing.Size(304, 34);
            this.txtRepass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRepass.TabIndex = 23;
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
            this.txtPass.Location = new System.Drawing.Point(306, 209);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(304, 34);
            this.txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 22;
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
            this.txtUserName.Location = new System.Drawing.Point(306, 143);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(304, 34);
            this.txtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUserName.TabIndex = 21;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
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
            this.txtEmail.Location = new System.Drawing.Point(306, 81);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(304, 34);
            this.txtEmail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEmail.TabIndex = 20;
            // 
            // chkSignupShowPass
            // 
            this.chkSignupShowPass.Animated = true;
            this.chkSignupShowPass.AutoSize = true;
            this.chkSignupShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSignupShowPass.CheckedState.BorderRadius = 0;
            this.chkSignupShowPass.CheckedState.BorderThickness = 0;
            this.chkSignupShowPass.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkSignupShowPass.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSignupShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkSignupShowPass.Location = new System.Drawing.Point(510, 314);
            this.chkSignupShowPass.Name = "chkSignupShowPass";
            this.chkSignupShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkSignupShowPass.TabIndex = 29;
            this.chkSignupShowPass.Text = "Show Password";
            this.chkSignupShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSignupShowPass.UncheckedState.BorderRadius = 0;
            this.chkSignupShowPass.UncheckedState.BorderThickness = 0;
            this.chkSignupShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSignupShowPass.CheckedChanged += new System.EventHandler(this.chkSignupShowPass_CheckedChanged);
            // 
            // btnSignup
            // 
            this.btnSignup.Animated = true;
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BorderRadius = 15;
            this.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignup.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(306, 338);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(96, 32);
            this.btnSignup.TabIndex = 24;
            this.btnSignup.Text = "Sign Up";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(304, 254);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(117, 17);
            this.lblConfirmPassword.TabIndex = 31;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(304, 189);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 17);
            this.lblPassword.TabIndex = 30;
            this.lblPassword.Text = "Password:";
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(608, 8);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(18, 18);
            this.signup_close.TabIndex = 27;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // txtLoginHere
            // 
            this.txtLoginHere.AutoSize = true;
            this.txtLoginHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLoginHere.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginHere.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoginHere.Location = new System.Drawing.Point(484, 382);
            this.txtLoginHere.Name = "txtLoginHere";
            this.txtLoginHere.Size = new System.Drawing.Size(66, 15);
            this.txtLoginHere.TabIndex = 25;
            this.txtLoginHere.Text = "Login here";
            this.txtLoginHere.Click += new System.EventHandler(this.txtLoginHere_Click);
            // 
            // lblAlreadyAccount
            // 
            this.lblAlreadyAccount.AutoSize = true;
            this.lblAlreadyAccount.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyAccount.ForeColor = System.Drawing.Color.DimGray;
            this.lblAlreadyAccount.Location = new System.Drawing.Point(339, 382);
            this.lblAlreadyAccount.Name = "lblAlreadyAccount";
            this.lblAlreadyAccount.Size = new System.Drawing.Size(142, 15);
            this.lblAlreadyAccount.TabIndex = 28;
            this.lblAlreadyAccount.Text = "Already have an account?";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(303, 123);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 17);
            this.lblUserName.TabIndex = 19;
            this.lblUserName.Text = "Username:";
            // 
            // lblGetStarted
            // 
            this.lblGetStarted.AutoSize = true;
            this.lblGetStarted.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetStarted.Location = new System.Drawing.Point(302, 16);
            this.lblGetStarted.Name = "lblGetStarted";
            this.lblGetStarted.Size = new System.Drawing.Size(113, 25);
            this.lblGetStarted.TabIndex = 17;
            this.lblGetStarted.Text = "Get Started";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.pnlPwValidation);
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBoxProfile);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 412);
            this.panel3.TabIndex = 16;
            // 
            // pnlPwValidation
            // 
            this.pnlPwValidation.BackColor = System.Drawing.Color.Transparent;
            this.pnlPwValidation.Controls.Add(this.label2);
            this.pnlPwValidation.Controls.Add(this.lblPassValidationInfo);
            this.pnlPwValidation.FillColor = System.Drawing.Color.MidnightBlue;
            this.pnlPwValidation.Location = new System.Drawing.Point(24, 226);
            this.pnlPwValidation.Name = "pnlPwValidation";
            this.pnlPwValidation.Radius = 5;
            this.pnlPwValidation.ShadowColor = System.Drawing.Color.Black;
            this.pnlPwValidation.ShadowDepth = 250;
            this.pnlPwValidation.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlPwValidation.Size = new System.Drawing.Size(236, 174);
            this.pnlPwValidation.TabIndex = 1026;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1013;
            this.label2.Text = "Password Validation:";
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
            this.btnBrowse.Location = new System.Drawing.Point(155, 86);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBrowse.Size = new System.Drawing.Size(26, 26);
            this.btnBrowse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBrowse.TabIndex = 1025;
            this.btnBrowse.TabStop = false;
            this.btnBrowse.UseTransparentBackground = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(71, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "EvolveSettings";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Image = global::EvolveSettings.Properties.Resources.user;
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.Location = new System.Drawing.Point(94, 82);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfile.Size = new System.Drawing.Size(91, 91);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.UseTransparentBackground = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(303, 61);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 17);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email Address:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnSignupPassGen);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkSignupShowPass);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.signup_close);
            this.Controls.Add(this.txtLoginHere);
            this.Controls.Add(this.lblAlreadyAccount);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblGetStarted);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlPwValidation.ResumeLayout(false);
            this.pnlPwValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrowse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm frmSignUp;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2Button btnSignupPassGen;
        private Guna.UI2.WinForms.Guna2TextBox txtRepass;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2CheckBox chkSignupShowPass;
        public Guna.UI2.WinForms.Guna2Button btnSignup;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label txtLoginHere;
        private System.Windows.Forms.Label lblAlreadyAccount;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblGetStarted;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassValidationInfo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlPwValidation;
    }
}