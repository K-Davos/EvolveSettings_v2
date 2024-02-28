
namespace EvolveSettings
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.frmMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNetFw = new System.Windows.Forms.Label();
            this.txtBitness = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.txtAppVersion = new System.Windows.Forms.Label();
            this.lblUserMode = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlRadius = new System.Windows.Forms.Panel();
            this.panelMain = new EvolveSettings.Controls.EvolvePanel();
            this.btnCat4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCat3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCat2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnCat1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnUserManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, Admin!";
            // 
            // frmMain
            // 
            this.frmMain.AnimateWindow = true;
            this.frmMain.AnimationInterval = 400;
            this.frmMain.BorderRadius = 5;
            this.frmMain.ContainerControl = this;
            this.frmMain.DockIndicatorTransparencyValue = 0.6D;
            this.frmMain.DragForm = false;
            this.frmMain.ResizeForm = false;
            this.frmMain.TransparentWhileDrag = true;
            // 
            // panel_header
            // 
            this.panel_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_header.Controls.Add(this.btnMinimize);
            this.panel_header.Controls.Add(this.btnCloseApp);
            this.panel_header.Location = new System.Drawing.Point(-1, -1);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1042, 42);
            this.panel_header.TabIndex = 7;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.txtNetFw);
            this.panel1.Controls.Add(this.txtBitness);
            this.panel1.Controls.Add(this.txtOS);
            this.panel1.Controls.Add(this.lblversion);
            this.panel1.Controls.Add(this.txtAppVersion);
            this.panel1.Controls.Add(this.lblUserMode);
            this.panel1.Controls.Add(this.btnCat4);
            this.panel1.Controls.Add(this.btnCat3);
            this.panel1.Controls.Add(this.btnCat2);
            this.panel1.Controls.Add(this.btnCat1);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.btnUserManagement);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 559);
            this.panel1.TabIndex = 6;
            // 
            // txtNetFw
            // 
            this.txtNetFw.AutoSize = true;
            this.txtNetFw.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetFw.ForeColor = System.Drawing.Color.Gray;
            this.txtNetFw.Location = new System.Drawing.Point(12, 495);
            this.txtNetFw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNetFw.Name = "txtNetFw";
            this.txtNetFw.Size = new System.Drawing.Size(37, 13);
            this.txtNetFw.TabIndex = 86;
            this.txtNetFw.Text = "netfw";
            // 
            // txtBitness
            // 
            this.txtBitness.AutoSize = true;
            this.txtBitness.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitness.ForeColor = System.Drawing.Color.Gray;
            this.txtBitness.Location = new System.Drawing.Point(12, 478);
            this.txtBitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.Size = new System.Drawing.Size(44, 13);
            this.txtBitness.TabIndex = 85;
            this.txtBitness.Text = "bitness";
            // 
            // txtOS
            // 
            this.txtOS.AutoSize = true;
            this.txtOS.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.ForeColor = System.Drawing.Color.Gray;
            this.txtOS.Location = new System.Drawing.Point(12, 461);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(19, 13);
            this.txtOS.TabIndex = 84;
            this.txtOS.Text = "os";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.Color.Gray;
            this.lblversion.Location = new System.Drawing.Point(12, 512);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(45, 13);
            this.lblversion.TabIndex = 83;
            this.lblversion.Text = "Version";
            // 
            // txtAppVersion
            // 
            this.txtAppVersion.AutoSize = true;
            this.txtAppVersion.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppVersion.ForeColor = System.Drawing.Color.Gray;
            this.txtAppVersion.Location = new System.Drawing.Point(55, 512);
            this.txtAppVersion.Name = "txtAppVersion";
            this.txtAppVersion.Size = new System.Drawing.Size(21, 13);
            this.txtAppVersion.TabIndex = 82;
            this.txtAppVersion.Text = "1.x";
            // 
            // lblUserMode
            // 
            this.lblUserMode.AutoSize = true;
            this.lblUserMode.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMode.ForeColor = System.Drawing.Color.Tomato;
            this.lblUserMode.Location = new System.Drawing.Point(12, 534);
            this.lblUserMode.Name = "lblUserMode";
            this.lblUserMode.Size = new System.Drawing.Size(60, 13);
            this.lblUserMode.TabIndex = 81;
            this.lblUserMode.Text = "UserMode";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Evolve Settings";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pnlRadius
            // 
            this.pnlRadius.Location = new System.Drawing.Point(187, 41);
            this.pnlRadius.Name = "pnlRadius";
            this.pnlRadius.Size = new System.Drawing.Size(7, 5);
            this.pnlRadius.TabIndex = 10;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelMain.BorderColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(188, 41);
            this.panelMain.Name = "panelMain";
            this.panelMain.Radius = 10;
            this.panelMain.Size = new System.Drawing.Size(871, 573);
            this.panelMain.TabIndex = 9;
            this.panelMain.Thickness = 0F;
            this.panelMain.Resize += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCat4
            // 
            this.btnCat4.Animated = true;
            this.btnCat4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCat4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCat4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCat4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCat4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCat4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat4.ForeColor = System.Drawing.Color.White;
            this.btnCat4.Image = global::EvolveSettings.Properties.Resources.settings;
            this.btnCat4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat4.Location = new System.Drawing.Point(0, 344);
            this.btnCat4.Name = "btnCat4";
            this.btnCat4.Size = new System.Drawing.Size(186, 42);
            this.btnCat4.TabIndex = 80;
            this.btnCat4.Text = "  Settings";
            this.btnCat4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat4.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnCat3
            // 
            this.btnCat3.Animated = true;
            this.btnCat3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCat3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCat3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCat3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCat3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCat3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat3.ForeColor = System.Drawing.Color.White;
            this.btnCat3.Image = global::EvolveSettings.Properties.Resources.maintenance;
            this.btnCat3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat3.Location = new System.Drawing.Point(0, 302);
            this.btnCat3.Name = "btnCat3";
            this.btnCat3.Size = new System.Drawing.Size(186, 42);
            this.btnCat3.TabIndex = 79;
            this.btnCat3.Text = "  PC Cleaner";
            this.btnCat3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat3.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnCat2
            // 
            this.btnCat2.Animated = true;
            this.btnCat2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCat2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCat2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCat2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCat2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCat2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat2.ForeColor = System.Drawing.Color.White;
            this.btnCat2.Image = global::EvolveSettings.Properties.Resources.network;
            this.btnCat2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat2.Location = new System.Drawing.Point(0, 260);
            this.btnCat2.Name = "btnCat2";
            this.btnCat2.Size = new System.Drawing.Size(186, 42);
            this.btnCat2.TabIndex = 78;
            this.btnCat2.Text = "  Network";
            this.btnCat2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat2.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // btnCat1
            // 
            this.btnCat1.Animated = true;
            this.btnCat1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCat1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCat1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCat1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCat1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCat1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat1.ForeColor = System.Drawing.Color.White;
            this.btnCat1.Image = global::EvolveSettings.Properties.Resources.win11tweaks;
            this.btnCat1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat1.Location = new System.Drawing.Point(0, 218);
            this.btnCat1.Name = "btnCat1";
            this.btnCat1.Size = new System.Drawing.Size(186, 42);
            this.btnCat1.TabIndex = 77;
            this.btnCat1.Text = "  Privacy and Services";
            this.btnCat1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCat1.Click += new System.EventHandler(this.btnWin11Tweaks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::EvolveSettings.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 176);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(40, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(103, 89);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 76;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Animated = true;
            this.btnUserManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUserManagement.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Image = global::EvolveSettings.Properties.Resources.usersm;
            this.btnUserManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 386);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(186, 42);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "  Users Management";
            this.btnUserManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::EvolveSettings.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(948, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 42);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Image = global::EvolveSettings.Properties.Resources.shutdown;
            this.btnCloseApp.Location = new System.Drawing.Point(992, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(48, 42);
            this.btnCloseApp.TabIndex = 16;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1041, 597);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlRadius);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel_header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnUserManagement;
        private Guna.UI2.WinForms.Guna2BorderlessForm frmMain;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseApp;
        private EvolveSettings.Controls.EvolvePanel panelMain;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel pnlRadius;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnCat4;
        private Guna.UI2.WinForms.Guna2Button btnCat3;
        private Guna.UI2.WinForms.Guna2Button btnCat2;
        private Guna.UI2.WinForms.Guna2Button btnCat1;
        private System.Windows.Forms.Label lblUserMode;
        private System.Windows.Forms.Label txtAppVersion;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label txtNetFw;
        private System.Windows.Forms.Label txtBitness;
        private System.Windows.Forms.Label txtOS;
    }
}