namespace EvolveSettings.Forms
{
    partial class ResetPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtResetRePass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtResetPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnResetPassClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPassValidationInfo = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPassGen = new Guna.UI2.WinForms.Guna2Button();
            this.lblResetPassword = new System.Windows.Forms.Label();
            this.chkResetShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 400;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(302, 120);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(97, 17);
            this.lblNewPassword.TabIndex = 1018;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtResetRePass
            // 
            this.txtResetRePass.Animated = true;
            this.txtResetRePass.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtResetRePass.BorderRadius = 15;
            this.txtResetRePass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResetRePass.DefaultText = "";
            this.txtResetRePass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResetRePass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResetRePass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResetRePass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResetRePass.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtResetRePass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetRePass.ForeColor = System.Drawing.Color.Black;
            this.txtResetRePass.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtResetRePass.Location = new System.Drawing.Point(305, 202);
            this.txtResetRePass.Name = "txtResetRePass";
            this.txtResetRePass.PasswordChar = '*';
            this.txtResetRePass.PlaceholderText = "";
            this.txtResetRePass.SelectedText = "";
            this.txtResetRePass.Size = new System.Drawing.Size(304, 34);
            this.txtResetRePass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtResetRePass.TabIndex = 1017;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 15;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(305, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 32);
            this.btnLogin.TabIndex = 1016;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtResetPass
            // 
            this.txtResetPass.Animated = true;
            this.txtResetPass.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtResetPass.BorderRadius = 15;
            this.txtResetPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResetPass.DefaultText = "";
            this.txtResetPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResetPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResetPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResetPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResetPass.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtResetPass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResetPass.ForeColor = System.Drawing.Color.Black;
            this.txtResetPass.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtResetPass.Location = new System.Drawing.Point(305, 140);
            this.txtResetPass.Name = "txtResetPass";
            this.txtResetPass.PasswordChar = '*';
            this.txtResetPass.PlaceholderText = "";
            this.txtResetPass.SelectedText = "";
            this.txtResetPass.Size = new System.Drawing.Size(304, 34);
            this.txtResetPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtResetPass.TabIndex = 1015;
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 15;
            this.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReset.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(407, 269);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 32);
            this.btnReset.TabIndex = 1014;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(302, 182);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(117, 17);
            this.lblConfirmPassword.TabIndex = 1020;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // btnResetPassClose
            // 
            this.btnResetPassClose.AutoSize = true;
            this.btnResetPassClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassClose.Location = new System.Drawing.Point(608, 8);
            this.btnResetPassClose.Name = "btnResetPassClose";
            this.btnResetPassClose.Size = new System.Drawing.Size(18, 18);
            this.btnResetPassClose.TabIndex = 1022;
            this.btnResetPassClose.Text = "X";
            this.btnResetPassClose.Click += new System.EventHandler(this.btnResetPassClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblPassValidationInfo);
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 411);
            this.panel2.TabIndex = 1021;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 1025;
            this.label7.Text = "Password Validation:";
            // 
            // lblPassValidationInfo
            // 
            this.lblPassValidationInfo.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassValidationInfo.ForeColor = System.Drawing.Color.White;
            this.lblPassValidationInfo.Location = new System.Drawing.Point(22, 291);
            this.lblPassValidationInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassValidationInfo.Name = "lblPassValidationInfo";
            this.lblPassValidationInfo.Size = new System.Drawing.Size(189, 113);
            this.lblPassValidationInfo.TabIndex = 1024;
            this.lblPassValidationInfo.Text = "Password not entered";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::EvolveSettings.Properties.Resources.evolve_settings;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(91, 81);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(99, 91);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(70, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "EvolveSettings";
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
            this.btnPassGen.Location = new System.Drawing.Point(511, 269);
            this.btnPassGen.Name = "btnPassGen";
            this.btnPassGen.Size = new System.Drawing.Size(96, 32);
            this.btnPassGen.TabIndex = 1023;
            this.btnPassGen.Text = "Password Generator";
            this.btnPassGen.Click += new System.EventHandler(this.btnPassGen_Click);
            // 
            // lblResetPassword
            // 
            this.lblResetPassword.AutoSize = true;
            this.lblResetPassword.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetPassword.Location = new System.Drawing.Point(302, 16);
            this.lblResetPassword.Name = "lblResetPassword";
            this.lblResetPassword.Size = new System.Drawing.Size(147, 25);
            this.lblResetPassword.TabIndex = 1024;
            this.lblResetPassword.Text = "Reset Password";
            // 
            // chkResetShowPass
            // 
            this.chkResetShowPass.Animated = true;
            this.chkResetShowPass.AutoSize = true;
            this.chkResetShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkResetShowPass.CheckedState.BorderRadius = 0;
            this.chkResetShowPass.CheckedState.BorderThickness = 0;
            this.chkResetShowPass.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkResetShowPass.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResetShowPass.ForeColor = System.Drawing.Color.Gray;
            this.chkResetShowPass.Location = new System.Drawing.Point(509, 242);
            this.chkResetShowPass.Name = "chkResetShowPass";
            this.chkResetShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkResetShowPass.TabIndex = 1025;
            this.chkResetShowPass.Text = "Show Password";
            this.chkResetShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkResetShowPass.UncheckedState.BorderRadius = 0;
            this.chkResetShowPass.UncheckedState.BorderThickness = 0;
            this.chkResetShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkResetShowPass.CheckedChanged += new System.EventHandler(this.chkResetShowPass_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.chkResetShowPass);
            this.Controls.Add(this.lblResetPassword);
            this.Controls.Add(this.btnPassGen);
            this.Controls.Add(this.btnResetPassClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtResetRePass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtResetPass);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPassForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtResetRePass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtResetPass;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label btnResetPassClose;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2Button btnPassGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPassValidationInfo;
        private System.Windows.Forms.Label lblResetPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkResetShowPass;
        private System.Windows.Forms.Timer timer1;
    }
}