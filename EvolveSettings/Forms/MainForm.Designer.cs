
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.frmMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnCat3 = new System.Windows.Forms.Button();
            this.btnCat1 = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnCat4 = new System.Windows.Forms.Button();
            this.btnCat2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelMain = new EvolveSettings.Controls.EvolvePanel();
            this.pnlRadius1 = new EvolveSettings.Controls.EvolvePanel();
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
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(46, 517);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(89, 30);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Users";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnCat1);
            this.panel1.Controls.Add(this.btnCat2);
            this.panel1.Controls.Add(this.btnCat3);
            this.panel1.Controls.Add(this.btnCat4);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 559);
            this.panel1.TabIndex = 6;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 182);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 140);
            this.pnlNav.TabIndex = 3;
            // 
            // btnCat3
            // 
            this.btnCat3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCat3.FlatAppearance.BorderSize = 0;
            this.btnCat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat3.ForeColor = System.Drawing.Color.White;
            this.btnCat3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat3.Location = new System.Drawing.Point(0, 270);
            this.btnCat3.Name = "btnCat3";
            this.btnCat3.Size = new System.Drawing.Size(186, 42);
            this.btnCat3.TabIndex = 1;
            this.btnCat3.Text = "Category 3";
            this.btnCat3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCat3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat3.UseVisualStyleBackColor = true;
            this.btnCat3.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnCat1
            // 
            this.btnCat1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCat1.FlatAppearance.BorderSize = 0;
            this.btnCat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat1.ForeColor = System.Drawing.Color.White;
            this.btnCat1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat1.Location = new System.Drawing.Point(0, 186);
            this.btnCat1.Name = "btnCat1";
            this.btnCat1.Size = new System.Drawing.Size(186, 42);
            this.btnCat1.TabIndex = 1;
            this.btnCat1.Text = "Category 1";
            this.btnCat1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCat1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat1.UseVisualStyleBackColor = true;
            this.btnCat1.Click += new System.EventHandler(this.btnWin11Tweaks_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::EvolveSettings.Properties.Resources.home;
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(186, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Evolve Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // btnCat4
            // 
            this.btnCat4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCat4.FlatAppearance.BorderSize = 0;
            this.btnCat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat4.ForeColor = System.Drawing.Color.White;
            this.btnCat4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat4.Location = new System.Drawing.Point(0, 312);
            this.btnCat4.Name = "btnCat4";
            this.btnCat4.Size = new System.Drawing.Size(186, 42);
            this.btnCat4.TabIndex = 1;
            this.btnCat4.Text = "Category 4";
            this.btnCat4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCat4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat4.UseVisualStyleBackColor = true;
            this.btnCat4.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnCat2
            // 
            this.btnCat2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCat2.FlatAppearance.BorderSize = 0;
            this.btnCat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCat2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCat2.ForeColor = System.Drawing.Color.White;
            this.btnCat2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCat2.Location = new System.Drawing.Point(-1, 228);
            this.btnCat2.Name = "btnCat2";
            this.btnCat2.Size = new System.Drawing.Size(187, 42);
            this.btnCat2.TabIndex = 3;
            this.btnCat2.Text = "Category 2";
            this.btnCat2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCat2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCat2.UseVisualStyleBackColor = true;
            this.btnCat2.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Evolve Settings";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BorderColor = System.Drawing.Color.Transparent;
            this.panelMain.Location = new System.Drawing.Point(187, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Radius = 10;
            this.panelMain.Size = new System.Drawing.Size(871, 573);
            this.panelMain.TabIndex = 9;
            this.panelMain.Thickness = 0F;
            // 
            // pnlRadius1
            // 
            this.pnlRadius1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlRadius1.BorderColor = System.Drawing.Color.Transparent;
            this.pnlRadius1.Location = new System.Drawing.Point(186, 40);
            this.pnlRadius1.Name = "pnlRadius1";
            this.pnlRadius1.Radius = 2;
            this.pnlRadius1.Size = new System.Drawing.Size(43, 60);
            this.pnlRadius1.TabIndex = 8;
            this.pnlRadius1.Thickness = 3F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 597);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.pnlRadius1);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel1);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2BorderlessForm frmMain;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnCat3;
        private System.Windows.Forms.Button btnCat1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnCat4;
        private System.Windows.Forms.Button btnCat2;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnCloseApp;
        private EvolveSettings.Controls.EvolvePanel pnlRadius1;
        private EvolveSettings.Controls.EvolvePanel panelMain;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}