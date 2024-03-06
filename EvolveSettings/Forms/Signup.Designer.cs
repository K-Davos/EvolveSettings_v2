
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
            this.signup_repassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.signup_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.signup_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.signup_email = new Guna.UI2.WinForms.Guna2TextBox();
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
            // signup_repassword
            // 
            this.signup_repassword.Animated = true;
            this.signup_repassword.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_repassword.BorderRadius = 15;
            this.signup_repassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_repassword.DefaultText = "";
            this.signup_repassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_repassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_repassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_repassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_repassword.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_repassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_repassword.ForeColor = System.Drawing.Color.Black;
            this.signup_repassword.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_repassword.Location = new System.Drawing.Point(306, 274);
            this.signup_repassword.Name = "signup_repassword";
            this.signup_repassword.PasswordChar = '*';
            this.signup_repassword.PlaceholderText = "";
            this.signup_repassword.SelectedText = "";
            this.signup_repassword.Size = new System.Drawing.Size(304, 34);
            this.signup_repassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.signup_repassword.TabIndex = 23;
            // 
            // signup_password
            // 
            this.signup_password.Animated = true;
            this.signup_password.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_password.BorderRadius = 15;
            this.signup_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_password.DefaultText = "";
            this.signup_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_password.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_password.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.ForeColor = System.Drawing.Color.Black;
            this.signup_password.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_password.Location = new System.Drawing.Point(306, 209);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.PlaceholderText = "";
            this.signup_password.SelectedText = "";
            this.signup_password.Size = new System.Drawing.Size(304, 34);
            this.signup_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.signup_password.TabIndex = 22;
            // 
            // signup_username
            // 
            this.signup_username.Animated = true;
            this.signup_username.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_username.BorderRadius = 15;
            this.signup_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_username.DefaultText = "";
            this.signup_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_username.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_username.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.ForeColor = System.Drawing.Color.Black;
            this.signup_username.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_username.Location = new System.Drawing.Point(306, 143);
            this.signup_username.Name = "signup_username";
            this.signup_username.PasswordChar = '\0';
            this.signup_username.PlaceholderText = "";
            this.signup_username.SelectedText = "";
            this.signup_username.Size = new System.Drawing.Size(304, 34);
            this.signup_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.signup_username.TabIndex = 21;
            // 
            // signup_email
            // 
            this.signup_email.Animated = true;
            this.signup_email.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_email.BorderRadius = 15;
            this.signup_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signup_email.DefaultText = "";
            this.signup_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signup_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signup_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signup_email.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_email.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.ForeColor = System.Drawing.Color.Black;
            this.signup_email.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.signup_email.Location = new System.Drawing.Point(306, 81);
            this.signup_email.Name = "signup_email";
            this.signup_email.PasswordChar = '\0';
            this.signup_email.PlaceholderText = "";
            this.signup_email.SelectedText = "";
            this.signup_email.Size = new System.Drawing.Size(304, 34);
            this.signup_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.signup_email.TabIndex = 20;
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
            this.Controls.Add(this.signup_repassword);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.signup_email);
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
        private Guna.UI2.WinForms.Guna2TextBox signup_repassword;
        private Guna.UI2.WinForms.Guna2TextBox signup_password;
        private Guna.UI2.WinForms.Guna2TextBox signup_username;
        private Guna.UI2.WinForms.Guna2TextBox signup_email;
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