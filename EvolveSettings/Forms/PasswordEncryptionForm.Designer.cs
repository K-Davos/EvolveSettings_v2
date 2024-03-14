namespace EvolveSettings.Forms
{
    partial class PasswordEncryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordEncryptionForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2Button();
            this.txtDecrypted = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRecordName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEncrypted = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkSignupShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2Button();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRecordName = new System.Windows.Forms.Label();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.Label();
            this.lblPassEncryptor = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.pnlHeader.SuspendLayout();
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
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBoxProfile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 411);
            this.panel3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(41, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password Encryption";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Image = global::EvolveSettings.Properties.Resources.encrypted_file;
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
            // btnDecrypt
            // 
            this.btnDecrypt.Animated = true;
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BorderRadius = 15;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnDecrypt.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(405, 355);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(96, 34);
            this.btnDecrypt.TabIndex = 41;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Animated = true;
            this.txtDecrypted.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDecrypted.BorderRadius = 15;
            this.txtDecrypted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDecrypted.DefaultText = "";
            this.txtDecrypted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDecrypted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDecrypted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDecrypted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDecrypted.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDecrypted.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecrypted.ForeColor = System.Drawing.Color.Black;
            this.txtDecrypted.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDecrypted.Location = new System.Drawing.Point(306, 285);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.PasswordChar = '\0';
            this.txtDecrypted.PlaceholderText = "";
            this.txtDecrypted.SelectedText = "";
            this.txtDecrypted.Size = new System.Drawing.Size(304, 34);
            this.txtDecrypted.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDecrypted.TabIndex = 39;
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
            this.txtPass.Location = new System.Drawing.Point(307, 153);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(304, 34);
            this.txtPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPass.TabIndex = 38;
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
            this.txtRecordName.Location = new System.Drawing.Point(307, 87);
            this.txtRecordName.Name = "txtRecordName";
            this.txtRecordName.PasswordChar = '\0';
            this.txtRecordName.PlaceholderText = "";
            this.txtRecordName.SelectedText = "";
            this.txtRecordName.Size = new System.Drawing.Size(304, 34);
            this.txtRecordName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRecordName.TabIndex = 37;
            this.txtRecordName.TextChanged += new System.EventHandler(this.txtRecordName_TextChanged);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Animated = true;
            this.txtEncrypted.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncrypted.BorderRadius = 15;
            this.txtEncrypted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEncrypted.DefaultText = "";
            this.txtEncrypted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEncrypted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEncrypted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncrypted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEncrypted.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncrypted.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncrypted.ForeColor = System.Drawing.Color.Black;
            this.txtEncrypted.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtEncrypted.Location = new System.Drawing.Point(307, 221);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.PasswordChar = '\0';
            this.txtEncrypted.PlaceholderText = "";
            this.txtEncrypted.SelectedText = "";
            this.txtEncrypted.Size = new System.Drawing.Size(304, 34);
            this.txtEncrypted.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEncrypted.TabIndex = 36;
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
            this.chkSignupShowPass.Location = new System.Drawing.Point(510, 325);
            this.chkSignupShowPass.Name = "chkSignupShowPass";
            this.chkSignupShowPass.Size = new System.Drawing.Size(107, 17);
            this.chkSignupShowPass.TabIndex = 43;
            this.chkSignupShowPass.Text = "Show Password";
            this.chkSignupShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSignupShowPass.UncheckedState.BorderRadius = 0;
            this.chkSignupShowPass.UncheckedState.BorderThickness = 0;
            this.chkSignupShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSignupShowPass.CheckedChanged += new System.EventHandler(this.chkSignupShowPass_CheckedChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Animated = true;
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BorderRadius = 15;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(515, 355);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(96, 34);
            this.btnEncrypt.TabIndex = 40;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypted.Location = new System.Drawing.Point(304, 265);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(72, 17);
            this.lblDecrypted.TabIndex = 45;
            this.lblDecrypted.Text = "Decrypted:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(305, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 17);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "Password:";
            // 
            // lblRecordName
            // 
            this.lblRecordName.AutoSize = true;
            this.lblRecordName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordName.Location = new System.Drawing.Point(304, 67);
            this.lblRecordName.Name = "lblRecordName";
            this.lblRecordName.Size = new System.Drawing.Size(92, 17);
            this.lblRecordName.TabIndex = 35;
            this.lblRecordName.Text = "Record Name:";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncrypted.Location = new System.Drawing.Point(304, 201);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(70, 17);
            this.lblEncrypted.TabIndex = 34;
            this.lblEncrypted.Text = "Encrypted:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.pictureBoxClose);
            this.pnlHeader.Controls.Add(this.lblPassEncryptor);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(284, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(350, 42);
            this.pnlHeader.TabIndex = 1040;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.AutoSize = true;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBoxClose.Location = new System.Drawing.Point(323, 9);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(18, 18);
            this.pictureBoxClose.TabIndex = 28;
            this.pictureBoxClose.Text = "X";
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // lblPassEncryptor
            // 
            this.lblPassEncryptor.AutoSize = true;
            this.lblPassEncryptor.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassEncryptor.ForeColor = System.Drawing.Color.White;
            this.lblPassEncryptor.Location = new System.Drawing.Point(14, 9);
            this.lblPassEncryptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassEncryptor.Name = "lblPassEncryptor";
            this.lblPassEncryptor.Size = new System.Drawing.Size(160, 21);
            this.lblPassEncryptor.TabIndex = 1;
            this.lblPassEncryptor.Text = "Password Encryptor";
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
            this.btnSave.Location = new System.Drawing.Point(300, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 34);
            this.btnSave.TabIndex = 1041;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PasswordEncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtRecordName);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.chkSignupShowPass);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblRecordName);
            this.Controls.Add(this.lblEncrypted);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordEncryptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordEncryptionForm";
            this.Load += new System.EventHandler(this.PasswordEncryptionForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        public Guna.UI2.WinForms.Guna2Button btnDecrypt;
        private Guna.UI2.WinForms.Guna2TextBox txtDecrypted;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtRecordName;
        private Guna.UI2.WinForms.Guna2TextBox txtEncrypted;
        private Guna.UI2.WinForms.Guna2CheckBox chkSignupShowPass;
        public Guna.UI2.WinForms.Guna2Button btnEncrypt;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRecordName;
        private System.Windows.Forms.Label lblEncrypted;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label pictureBoxClose;
        public System.Windows.Forms.Label lblPassEncryptor;
        public Guna.UI2.WinForms.Guna2Button btnSave;
    }
}