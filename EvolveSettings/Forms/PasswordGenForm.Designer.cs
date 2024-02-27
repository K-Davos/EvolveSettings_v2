namespace EvolveSettings.Forms
{
    partial class PasswordGenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtGenPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.btnPassGenCopy = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.guna2TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.chkSymbols = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkDigits = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkUppercase = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkLowercase = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblPasswordGen = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
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
            // txtGenPassword
            // 
            this.txtGenPassword.Animated = true;
            this.txtGenPassword.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtGenPassword.BorderRadius = 15;
            this.txtGenPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenPassword.DefaultText = "";
            this.txtGenPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenPassword.FocusedState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtGenPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenPassword.ForeColor = System.Drawing.Color.Black;
            this.txtGenPassword.HoverState.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtGenPassword.Location = new System.Drawing.Point(23, 55);
            this.txtGenPassword.Name = "txtGenPassword";
            this.txtGenPassword.PasswordChar = '\0';
            this.txtGenPassword.PlaceholderText = "";
            this.txtGenPassword.SelectedText = "";
            this.txtGenPassword.Size = new System.Drawing.Size(304, 34);
            this.txtGenPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtGenPassword.TabIndex = 1014;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Animated = true;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BorderRadius = 15;
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(343, 57);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 32);
            this.btnGenerate.TabIndex = 1013;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnPassGenCopy
            // 
            this.btnPassGenCopy.Animated = true;
            this.btnPassGenCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnPassGenCopy.BorderRadius = 15;
            this.btnPassGenCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPassGenCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPassGenCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPassGenCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPassGenCopy.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPassGenCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPassGenCopy.ForeColor = System.Drawing.Color.White;
            this.btnPassGenCopy.Location = new System.Drawing.Point(445, 57);
            this.btnPassGenCopy.Name = "btnPassGenCopy";
            this.btnPassGenCopy.Size = new System.Drawing.Size(96, 32);
            this.btnPassGenCopy.TabIndex = 1015;
            this.btnPassGenCopy.Text = "Copy";
            this.btnPassGenCopy.Click += new System.EventHandler(this.btnPassGenCopy_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.lblLength);
            this.guna2GroupBox1.Controls.Add(this.guna2TrackBar1);
            this.guna2GroupBox1.Controls.Add(this.chkSymbols);
            this.guna2GroupBox1.Controls.Add(this.chkDigits);
            this.guna2GroupBox1.Controls.Add(this.chkUppercase);
            this.guna2GroupBox1.Controls.Add(this.chkLowercase);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(23, 113);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(518, 131);
            this.guna2GroupBox1.TabIndex = 1016;
            this.guna2GroupBox1.Text = "Options";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.ForeColor = System.Drawing.Color.Black;
            this.lblLength.Location = new System.Drawing.Point(490, 58);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(16, 18);
            this.lblLength.TabIndex = 1013;
            this.lblLength.Text = "8";
            // 
            // guna2TrackBar1
            // 
            this.guna2TrackBar1.Location = new System.Drawing.Point(32, 58);
            this.guna2TrackBar1.Maximum = 64;
            this.guna2TrackBar1.Name = "guna2TrackBar1";
            this.guna2TrackBar1.Size = new System.Drawing.Size(451, 23);
            this.guna2TrackBar1.TabIndex = 1012;
            this.guna2TrackBar1.ThumbColor = System.Drawing.Color.MidnightBlue;
            this.guna2TrackBar1.Value = 8;
            this.guna2TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar1_Scroll);
            // 
            // chkSymbols
            // 
            this.chkSymbols.Animated = true;
            this.chkSymbols.AutoSize = true;
            this.chkSymbols.Checked = true;
            this.chkSymbols.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSymbols.CheckedState.BorderRadius = 0;
            this.chkSymbols.CheckedState.BorderThickness = 0;
            this.chkSymbols.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSymbols.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSymbols.ForeColor = System.Drawing.Color.Gray;
            this.chkSymbols.Location = new System.Drawing.Point(421, 102);
            this.chkSymbols.Name = "chkSymbols";
            this.chkSymbols.Size = new System.Drawing.Size(68, 17);
            this.chkSymbols.TabIndex = 1011;
            this.chkSymbols.Text = "Symbols";
            this.chkSymbols.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSymbols.UncheckedState.BorderRadius = 0;
            this.chkSymbols.UncheckedState.BorderThickness = 0;
            this.chkSymbols.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkDigits
            // 
            this.chkDigits.Animated = true;
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDigits.CheckedState.BorderRadius = 0;
            this.chkDigits.CheckedState.BorderThickness = 0;
            this.chkDigits.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDigits.ForeColor = System.Drawing.Color.Gray;
            this.chkDigits.Location = new System.Drawing.Point(311, 102);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(56, 17);
            this.chkDigits.TabIndex = 1010;
            this.chkDigits.Text = "Digits";
            this.chkDigits.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDigits.UncheckedState.BorderRadius = 0;
            this.chkDigits.UncheckedState.BorderThickness = 0;
            this.chkDigits.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkUppercase
            // 
            this.chkUppercase.Animated = true;
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkUppercase.CheckedState.BorderRadius = 0;
            this.chkUppercase.CheckedState.BorderThickness = 0;
            this.chkUppercase.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUppercase.ForeColor = System.Drawing.Color.Gray;
            this.chkUppercase.Location = new System.Drawing.Point(170, 102);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(80, 17);
            this.chkUppercase.TabIndex = 1009;
            this.chkUppercase.Text = "Uppercase";
            this.chkUppercase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUppercase.UncheckedState.BorderRadius = 0;
            this.chkUppercase.UncheckedState.BorderThickness = 0;
            this.chkUppercase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // chkLowercase
            // 
            this.chkLowercase.Animated = true;
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Checked = true;
            this.chkLowercase.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkLowercase.CheckedState.BorderRadius = 0;
            this.chkLowercase.CheckedState.BorderThickness = 0;
            this.chkLowercase.CheckedState.FillColor = System.Drawing.Color.MidnightBlue;
            this.chkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercase.Enabled = false;
            this.chkLowercase.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLowercase.ForeColor = System.Drawing.Color.Gray;
            this.chkLowercase.Location = new System.Drawing.Point(32, 102);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(79, 17);
            this.chkLowercase.TabIndex = 1008;
            this.chkLowercase.Text = "Lowercase";
            this.chkLowercase.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkLowercase.UncheckedState.BorderRadius = 0;
            this.chkLowercase.UncheckedState.BorderThickness = 0;
            this.chkLowercase.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // lblPasswordGen
            // 
            this.lblPasswordGen.AutoSize = true;
            this.lblPasswordGen.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordGen.ForeColor = System.Drawing.Color.Black;
            this.lblPasswordGen.Location = new System.Drawing.Point(19, 9);
            this.lblPasswordGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordGen.Name = "lblPasswordGen";
            this.lblPasswordGen.Size = new System.Drawing.Size(161, 21);
            this.lblPasswordGen.TabIndex = 1;
            this.lblPasswordGen.Text = "Password Generator";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(537, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 1017;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PasswordGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPasswordGen);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnPassGenCopy);
            this.Controls.Add(this.txtGenPassword);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGeneratorForm";
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Guna.UI2.WinForms.Guna2Button btnPassGenCopy;
        public Guna.UI2.WinForms.Guna2TextBox txtGenPassword;
        public Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        public System.Windows.Forms.Label lblPasswordGen;
        private Guna.UI2.WinForms.Guna2CheckBox chkSymbols;
        private Guna.UI2.WinForms.Guna2CheckBox chkDigits;
        private Guna.UI2.WinForms.Guna2CheckBox chkUppercase;
        private Guna.UI2.WinForms.Guna2CheckBox chkLowercase;
        private Guna.UI2.WinForms.Guna2TrackBar guna2TrackBar1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label btnClose;
    }
}