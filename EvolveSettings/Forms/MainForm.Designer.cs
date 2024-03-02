
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnUserManagement = new Guna.UI2.WinForms.Guna2Button();
            this.btnPassManager = new Guna.UI2.WinForms.Guna2Button();
            this.txtNetFw = new System.Windows.Forms.Label();
            this.txtBitness = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.txtAppVersion = new System.Windows.Forms.Label();
            this.lblUserMode = new System.Windows.Forms.Label();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnMaintenance = new Guna.UI2.WinForms.Guna2Button();
            this.btnNetwork = new Guna.UI2.WinForms.Guna2Button();
            this.btnWin11Tweaks = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlRadius = new System.Windows.Forms.Panel();
            this.panelMain = new EvolveSettings.Controls.EvolvePanel();
            this.pnlHeader.SuspendLayout();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
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
            // pnlHeader
            // 
            this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnCloseApp);
            this.pnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1042, 42);
            this.pnlHeader.TabIndex = 7;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::EvolveSettings.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(949, 0);
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
            this.btnCloseApp.Location = new System.Drawing.Point(993, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(48, 42);
            this.btnCloseApp.TabIndex = 16;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.btnUserManagement);
            this.pnlNav.Controls.Add(this.btnPassManager);
            this.pnlNav.Controls.Add(this.txtNetFw);
            this.pnlNav.Controls.Add(this.txtBitness);
            this.pnlNav.Controls.Add(this.txtOS);
            this.pnlNav.Controls.Add(this.lblversion);
            this.pnlNav.Controls.Add(this.txtAppVersion);
            this.pnlNav.Controls.Add(this.lblUserMode);
            this.pnlNav.Controls.Add(this.btnSettings);
            this.pnlNav.Controls.Add(this.btnMaintenance);
            this.pnlNav.Controls.Add(this.btnNetwork);
            this.pnlNav.Controls.Add(this.btnWin11Tweaks);
            this.pnlNav.Controls.Add(this.btnHome);
            this.pnlNav.Controls.Add(this.pictureBoxProfile);
            this.pnlNav.Controls.Add(this.label1);
            this.pnlNav.Location = new System.Drawing.Point(0, 38);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(187, 559);
            this.pnlNav.TabIndex = 6;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Animated = true;
            this.btnUserManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUserManagement.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnUserManagement.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnUserManagement.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnUserManagement.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManagement.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUserManagement.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUserManagement.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUserManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnUserManagement.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Image = global::EvolveSettings.Properties.Resources.usersm;
            this.btnUserManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 407);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(186, 42);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Text = "  Users Management";
            this.btnUserManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnPassManager
            // 
            this.btnPassManager.Animated = true;
            this.btnPassManager.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPassManager.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnPassManager.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnPassManager.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPassManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPassManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPassManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPassManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPassManager.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPassManager.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPassManager.ForeColor = System.Drawing.Color.White;
            this.btnPassManager.Image = global::EvolveSettings.Properties.Resources.pwmanager;
            this.btnPassManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassManager.Location = new System.Drawing.Point(0, 365);
            this.btnPassManager.Name = "btnPassManager";
            this.btnPassManager.Size = new System.Drawing.Size(186, 42);
            this.btnPassManager.TabIndex = 87;
            this.btnPassManager.Text = "  Password Manager";
            this.btnPassManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassManager.Click += new System.EventHandler(this.btnPassManager_Click);
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
            // btnSettings
            // 
            this.btnSettings.Animated = true;
            this.btnSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSettings.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSettings.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::EvolveSettings.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Location = new System.Drawing.Point(0, 323);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 80;
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Animated = true;
            this.btnMaintenance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMaintenance.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnMaintenance.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnMaintenance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMaintenance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMaintenance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMaintenance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMaintenance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Image = global::EvolveSettings.Properties.Resources.maintenance;
            this.btnMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 281);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(186, 42);
            this.btnMaintenance.TabIndex = 79;
            this.btnMaintenance.Text = "  PC Cleaner";
            this.btnMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Animated = true;
            this.btnNetwork.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNetwork.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnNetwork.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnNetwork.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnNetwork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNetwork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNetwork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNetwork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNetwork.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnNetwork.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetwork.ForeColor = System.Drawing.Color.White;
            this.btnNetwork.Image = global::EvolveSettings.Properties.Resources.network;
            this.btnNetwork.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNetwork.Location = new System.Drawing.Point(0, 239);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(186, 42);
            this.btnNetwork.TabIndex = 78;
            this.btnNetwork.Text = "  Network";
            this.btnNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // btnWin11Tweaks
            // 
            this.btnWin11Tweaks.Animated = true;
            this.btnWin11Tweaks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnWin11Tweaks.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnWin11Tweaks.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnWin11Tweaks.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnWin11Tweaks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWin11Tweaks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWin11Tweaks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWin11Tweaks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWin11Tweaks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnWin11Tweaks.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWin11Tweaks.ForeColor = System.Drawing.Color.White;
            this.btnWin11Tweaks.Image = global::EvolveSettings.Properties.Resources.win11tweaks;
            this.btnWin11Tweaks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWin11Tweaks.Location = new System.Drawing.Point(0, 197);
            this.btnWin11Tweaks.Name = "btnWin11Tweaks";
            this.btnWin11Tweaks.Size = new System.Drawing.Size(186, 42);
            this.btnWin11Tweaks.TabIndex = 77;
            this.btnWin11Tweaks.Text = "  Privacy and Services";
            this.btnWin11Tweaks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWin11Tweaks.Click += new System.EventHandler(this.btnWin11Tweaks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Animated = true;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.CustomBorderColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.CustomBorderThickness = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnHome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::EvolveSettings.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 155);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.Location = new System.Drawing.Point(40, 9);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(103, 89);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 76;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.UseTransparentBackground = true;
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
            this.panelMain.Location = new System.Drawing.Point(187, 41);
            this.panelMain.Name = "panelMain";
            this.panelMain.Radius = 10;
            this.panelMain.Size = new System.Drawing.Size(871, 573);
            this.panelMain.TabIndex = 9;
            this.panelMain.Thickness = 0F;
            this.panelMain.Resize += new System.EventHandler(this.btnMinimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1041, 597);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlRadius);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnUserManagement;
        private Guna.UI2.WinForms.Guna2BorderlessForm frmMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel pnlRadius;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnMaintenance;
        private Guna.UI2.WinForms.Guna2Button btnNetwork;
        private Guna.UI2.WinForms.Guna2Button btnWin11Tweaks;
        private System.Windows.Forms.Label lblUserMode;
        private System.Windows.Forms.Label txtAppVersion;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label txtNetFw;
        private System.Windows.Forms.Label txtBitness;
        private System.Windows.Forms.Label txtOS;
        private Controls.EvolvePanel panelMain;
        private Guna.UI2.WinForms.Guna2Button btnPassManager;
        public Guna.UI2.WinForms.Guna2PictureBox pictureBoxProfile;
    }
}