
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
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
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
            this.circleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.circleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pictureBoxProfile = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.circleProgressBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUser.Location = new System.Drawing.Point(25, 137);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(133, 21);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Welcome, Admin!";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1062, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(48, 42);
            this.btnMaximize.TabIndex = 18;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1011, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 42);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.ForeColor = System.Drawing.Color.White;
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.Location = new System.Drawing.Point(1113, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(48, 42);
            this.btnCloseApp.TabIndex = 16;
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlNav.Controls.Add(this.btnMenu);
            this.pnlNav.Controls.Add(this.btnLogout);
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
            this.pnlNav.Controls.Add(this.lblCurrentUser);
            this.pnlNav.Controls.Add(this.circleProgressBar2);
            this.pnlNav.Controls.Add(this.pictureBoxProfile);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(187, 782);
            this.pnlNav.TabIndex = 6;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageRotate = 0F;
            this.btnMenu.Location = new System.Drawing.Point(155, 19);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 90;
            this.btnMenu.TabStop = false;
            this.btnMenu.UseTransparentBackground = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnLogout.Location = new System.Drawing.Point(144, 743);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.TabIndex = 89;
            this.btnLogout.UseTransparentBackground = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnUserManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnUserManagement.Image")));
            this.btnUserManagement.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 521);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(186, 42);
            this.btnUserManagement.TabIndex = 1;
            this.btnUserManagement.Tag = "Users Management";
            this.btnUserManagement.Text = "  Users Management";
            this.btnUserManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnPassManager
            // 
            this.btnPassManager.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnPassManager.Image = ((System.Drawing.Image)(resources.GetObject("btnPassManager.Image")));
            this.btnPassManager.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassManager.Location = new System.Drawing.Point(0, 479);
            this.btnPassManager.Name = "btnPassManager";
            this.btnPassManager.Size = new System.Drawing.Size(186, 42);
            this.btnPassManager.TabIndex = 87;
            this.btnPassManager.Tag = "Password Manager";
            this.btnPassManager.Text = "  Password Manager";
            this.btnPassManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassManager.Click += new System.EventHandler(this.btnPassManager_Click);
            // 
            // txtNetFw
            // 
            this.txtNetFw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNetFw.AutoSize = true;
            this.txtNetFw.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetFw.ForeColor = System.Drawing.Color.Gray;
            this.txtNetFw.Location = new System.Drawing.Point(12, 722);
            this.txtNetFw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtNetFw.Name = "txtNetFw";
            this.txtNetFw.Size = new System.Drawing.Size(37, 13);
            this.txtNetFw.TabIndex = 86;
            this.txtNetFw.Text = "netfw";
            // 
            // txtBitness
            // 
            this.txtBitness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBitness.AutoSize = true;
            this.txtBitness.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBitness.ForeColor = System.Drawing.Color.Gray;
            this.txtBitness.Location = new System.Drawing.Point(12, 705);
            this.txtBitness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.Size = new System.Drawing.Size(44, 13);
            this.txtBitness.TabIndex = 85;
            this.txtBitness.Text = "bitness";
            // 
            // txtOS
            // 
            this.txtOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOS.AutoSize = true;
            this.txtOS.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.ForeColor = System.Drawing.Color.Gray;
            this.txtOS.Location = new System.Drawing.Point(12, 688);
            this.txtOS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(19, 13);
            this.txtOS.TabIndex = 84;
            this.txtOS.Text = "os";
            // 
            // lblversion
            // 
            this.lblversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblversion.AutoSize = true;
            this.lblversion.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblversion.ForeColor = System.Drawing.Color.Gray;
            this.lblversion.Location = new System.Drawing.Point(12, 739);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(45, 13);
            this.lblversion.TabIndex = 83;
            this.lblversion.Text = "Version";
            // 
            // txtAppVersion
            // 
            this.txtAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAppVersion.AutoSize = true;
            this.txtAppVersion.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppVersion.ForeColor = System.Drawing.Color.Gray;
            this.txtAppVersion.Location = new System.Drawing.Point(55, 739);
            this.txtAppVersion.Name = "txtAppVersion";
            this.txtAppVersion.Size = new System.Drawing.Size(21, 13);
            this.txtAppVersion.TabIndex = 82;
            this.txtAppVersion.Text = "1.x";
            // 
            // lblUserMode
            // 
            this.lblUserMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUserMode.AutoSize = true;
            this.lblUserMode.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserMode.ForeColor = System.Drawing.Color.Tomato;
            this.lblUserMode.Location = new System.Drawing.Point(12, 761);
            this.lblUserMode.Name = "lblUserMode";
            this.lblUserMode.Size = new System.Drawing.Size(60, 13);
            this.lblUserMode.TabIndex = 81;
            this.lblUserMode.Text = "UserMode";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Location = new System.Drawing.Point(0, 437);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(186, 42);
            this.btnSettings.TabIndex = 80;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Text = "  Settings";
            this.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintenance.Image")));
            this.btnMaintenance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 395);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(186, 42);
            this.btnMaintenance.TabIndex = 79;
            this.btnMaintenance.Tag = "PC Cleaner";
            this.btnMaintenance.Text = "  PC Cleaner";
            this.btnMaintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnNetwork.Image = ((System.Drawing.Image)(resources.GetObject("btnNetwork.Image")));
            this.btnNetwork.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNetwork.Location = new System.Drawing.Point(0, 353);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(186, 42);
            this.btnNetwork.TabIndex = 78;
            this.btnNetwork.Tag = "Network";
            this.btnNetwork.Text = "  Network";
            this.btnNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // btnWin11Tweaks
            // 
            this.btnWin11Tweaks.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnWin11Tweaks.Image = ((System.Drawing.Image)(resources.GetObject("btnWin11Tweaks.Image")));
            this.btnWin11Tweaks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWin11Tweaks.Location = new System.Drawing.Point(0, 311);
            this.btnWin11Tweaks.Name = "btnWin11Tweaks";
            this.btnWin11Tweaks.Size = new System.Drawing.Size(186, 42);
            this.btnWin11Tweaks.TabIndex = 77;
            this.btnWin11Tweaks.Tag = "Privacy and Services";
            this.btnWin11Tweaks.Text = "  Privacy and Services";
            this.btnWin11Tweaks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWin11Tweaks.Click += new System.EventHandler(this.btnWin11Tweaks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(0, 269);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Tag = "Home";
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // circleProgressBar2
            // 
            this.circleProgressBar2.Animated = true;
            this.circleProgressBar2.AnimationSpeed = 0.3F;
            this.circleProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circleProgressBar2.Controls.Add(this.circleProgressBar1);
            this.circleProgressBar2.FillColor = System.Drawing.Color.Transparent;
            this.circleProgressBar2.FillThickness = 1;
            this.circleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgressBar2.ForeColor = System.Drawing.Color.Transparent;
            this.circleProgressBar2.Location = new System.Drawing.Point(42, 31);
            this.circleProgressBar2.Minimum = 0;
            this.circleProgressBar2.Name = "circleProgressBar2";
            this.circleProgressBar2.ProgressColor = System.Drawing.Color.MidnightBlue;
            this.circleProgressBar2.ProgressColor2 = System.Drawing.Color.Red;
            this.circleProgressBar2.ProgressThickness = 1;
            this.circleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar2.Size = new System.Drawing.Size(104, 104);
            this.circleProgressBar2.TabIndex = 92;
            this.circleProgressBar2.UseTransparentBackground = true;
            this.circleProgressBar2.Value = 33;
            // 
            // circleProgressBar1
            // 
            this.circleProgressBar1.Animated = true;
            this.circleProgressBar1.AnimationSpeed = 0.3F;
            this.circleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circleProgressBar1.FillColor = System.Drawing.Color.Transparent;
            this.circleProgressBar1.FillThickness = 1;
            this.circleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circleProgressBar1.Location = new System.Drawing.Point(8, 7);
            this.circleProgressBar1.Minimum = 0;
            this.circleProgressBar1.Name = "circleProgressBar1";
            this.circleProgressBar1.ProgressColor = System.Drawing.Color.Red;
            this.circleProgressBar1.ProgressColor2 = System.Drawing.Color.MidnightBlue;
            this.circleProgressBar1.ProgressThickness = 1;
            this.circleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgressBar1.Size = new System.Drawing.Size(88, 88);
            this.circleProgressBar1.TabIndex = 91;
            this.circleProgressBar1.UseTransparentBackground = true;
            this.circleProgressBar1.Value = 33;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.ImageRotate = 0F;
            this.pictureBoxProfile.Location = new System.Drawing.Point(49, 37);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxProfile.Size = new System.Drawing.Size(89, 89);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 88;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.UseTransparentBackground = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pnlHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(187, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1162, 782);
            this.panelMain.TabIndex = 8;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Controls.Add(this.btnMaximize);
            this.pnlHeader.Controls.Add(this.btnCloseApp);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1162, 42);
            this.pnlHeader.TabIndex = 20;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            // 
            // ShadowForm
            // 
            this.ShadowForm.BorderRadius = 0;
            this.ShadowForm.TargetForm = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1349, 782);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlNav);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(857, 565);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.pnlNav.ResumeLayout(false);
            this.pnlNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.circleProgressBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnUserManagement;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseApp;
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
        private Guna.UI2.WinForms.Guna2Button btnPassManager;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxProfile;
        public System.Windows.Forms.Label lblCurrentUser;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout;
        private Guna.UI2.WinForms.Guna2PictureBox btnMenu;
        private System.Windows.Forms.Button btnMaximize;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgressBar2;
    }
}