namespace EvolveSettings.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDisableAccSignup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDefaultSettings = new Guna.UI2.WinForms.Guna2Button();
            this.lblDefaultSettings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWinTheme = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAutoStart = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTheme = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlAutoStart = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlResetConfig = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlDisableAccSignup = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.toggleUserAccounts = new EvolveSettings.Controls.EvolveToggleButton();
            this.btnAutoStart = new EvolveSettings.Controls.EvolveToggleButton();
            this.toggleWinTheme = new EvolveSettings.Controls.EvolveToggleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTheme.SuspendLayout();
            this.pnlAutoStart.SuspendLayout();
            this.pnlResetConfig.SuspendLayout();
            this.pnlDisableAccSignup.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 35);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Settings";
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // lblDisableAccSignup
            // 
            this.lblDisableAccSignup.AutoSize = true;
            this.lblDisableAccSignup.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisableAccSignup.ForeColor = System.Drawing.Color.White;
            this.lblDisableAccSignup.Location = new System.Drawing.Point(12, 11);
            this.lblDisableAccSignup.Name = "lblDisableAccSignup";
            this.lblDisableAccSignup.Size = new System.Drawing.Size(132, 25);
            this.lblDisableAccSignup.TabIndex = 15;
            this.lblDisableAccSignup.Text = "User Accounts";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Disable register new user accounts.";
            // 
            // btnDefaultSettings
            // 
            this.btnDefaultSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultSettings.Animated = true;
            this.btnDefaultSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnDefaultSettings.BorderRadius = 15;
            this.btnDefaultSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDefaultSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDefaultSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDefaultSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDefaultSettings.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnDefaultSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDefaultSettings.ForeColor = System.Drawing.Color.White;
            this.btnDefaultSettings.Location = new System.Drawing.Point(173, 71);
            this.btnDefaultSettings.Name = "btnDefaultSettings";
            this.btnDefaultSettings.Size = new System.Drawing.Size(96, 32);
            this.btnDefaultSettings.TabIndex = 1004;
            this.btnDefaultSettings.Text = "Reset";
            this.btnDefaultSettings.Click += new System.EventHandler(this.btnDefaultSettings_Click);
            // 
            // lblDefaultSettings
            // 
            this.lblDefaultSettings.AutoSize = true;
            this.lblDefaultSettings.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultSettings.ForeColor = System.Drawing.Color.White;
            this.lblDefaultSettings.Location = new System.Drawing.Point(17, 11);
            this.lblDefaultSettings.Name = "lblDefaultSettings";
            this.lblDefaultSettings.Size = new System.Drawing.Size(145, 25);
            this.lblDefaultSettings.TabIndex = 14;
            this.lblDefaultSettings.Text = "Default Settings";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 39);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reset application configuration to default settings";
            // 
            // lblWinTheme
            // 
            this.lblWinTheme.AutoSize = true;
            this.lblWinTheme.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinTheme.ForeColor = System.Drawing.Color.White;
            this.lblWinTheme.Location = new System.Drawing.Point(12, 11);
            this.lblWinTheme.Name = "lblWinTheme";
            this.lblWinTheme.Size = new System.Drawing.Size(69, 25);
            this.lblWinTheme.TabIndex = 15;
            this.lblWinTheme.Text = "Theme";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 42);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enable to use windows selected light/dark mode and accent colors";
            // 
            // lblAutoStart
            // 
            this.lblAutoStart.AutoSize = true;
            this.lblAutoStart.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoStart.ForeColor = System.Drawing.Color.White;
            this.lblAutoStart.Location = new System.Drawing.Point(17, 11);
            this.lblAutoStart.Name = "lblAutoStart";
            this.lblAutoStart.Size = new System.Drawing.Size(91, 25);
            this.lblAutoStart.TabIndex = 12;
            this.lblAutoStart.Text = "AutoStart";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label14.Location = new System.Drawing.Point(19, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(218, 39);
            this.label14.TabIndex = 13;
            this.label14.Text = "Start Evolve Dashboard with windows";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnlDisableAccSignup, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlResetConfig, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlAutoStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTheme, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1185, 130);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // pnlTheme
            // 
            this.pnlTheme.BackColor = System.Drawing.Color.Transparent;
            this.pnlTheme.Controls.Add(this.label2);
            this.pnlTheme.Controls.Add(this.toggleWinTheme);
            this.pnlTheme.Controls.Add(this.lblWinTheme);
            this.pnlTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTheme.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlTheme.Location = new System.Drawing.Point(3, 3);
            this.pnlTheme.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnlTheme.Name = "pnlTheme";
            this.pnlTheme.Radius = 5;
            this.pnlTheme.ShadowColor = System.Drawing.Color.Black;
            this.pnlTheme.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlTheme.Size = new System.Drawing.Size(283, 124);
            this.pnlTheme.TabIndex = 0;
            // 
            // pnlAutoStart
            // 
            this.pnlAutoStart.BackColor = System.Drawing.Color.Transparent;
            this.pnlAutoStart.Controls.Add(this.btnAutoStart);
            this.pnlAutoStart.Controls.Add(this.label14);
            this.pnlAutoStart.Controls.Add(this.lblAutoStart);
            this.pnlAutoStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAutoStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlAutoStart.Location = new System.Drawing.Point(299, 3);
            this.pnlAutoStart.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnlAutoStart.Name = "pnlAutoStart";
            this.pnlAutoStart.Radius = 5;
            this.pnlAutoStart.ShadowColor = System.Drawing.Color.Black;
            this.pnlAutoStart.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlAutoStart.Size = new System.Drawing.Size(283, 124);
            this.pnlAutoStart.TabIndex = 1;
            // 
            // pnlResetConfig
            // 
            this.pnlResetConfig.BackColor = System.Drawing.Color.Transparent;
            this.pnlResetConfig.Controls.Add(this.btnDefaultSettings);
            this.pnlResetConfig.Controls.Add(this.lblDefaultSettings);
            this.pnlResetConfig.Controls.Add(this.label4);
            this.pnlResetConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResetConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlResetConfig.Location = new System.Drawing.Point(595, 3);
            this.pnlResetConfig.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.pnlResetConfig.Name = "pnlResetConfig";
            this.pnlResetConfig.Radius = 5;
            this.pnlResetConfig.ShadowColor = System.Drawing.Color.Black;
            this.pnlResetConfig.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlResetConfig.Size = new System.Drawing.Size(283, 124);
            this.pnlResetConfig.TabIndex = 1;
            // 
            // pnlDisableAccSignup
            // 
            this.pnlDisableAccSignup.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisableAccSignup.Controls.Add(this.toggleUserAccounts);
            this.pnlDisableAccSignup.Controls.Add(this.lblDisableAccSignup);
            this.pnlDisableAccSignup.Controls.Add(this.label3);
            this.pnlDisableAccSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisableAccSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlDisableAccSignup.Location = new System.Drawing.Point(891, 3);
            this.pnlDisableAccSignup.Name = "pnlDisableAccSignup";
            this.pnlDisableAccSignup.Radius = 5;
            this.pnlDisableAccSignup.ShadowColor = System.Drawing.Color.Black;
            this.pnlDisableAccSignup.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlDisableAccSignup.Size = new System.Drawing.Size(291, 124);
            this.pnlDisableAccSignup.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1185, 49);
            this.pnlHeader.TabIndex = 16;
            // 
            // toggleUserAccounts
            // 
            this.toggleUserAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleUserAccounts.AutoSize = true;
            this.toggleUserAccounts.Location = new System.Drawing.Point(229, 81);
            this.toggleUserAccounts.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleUserAccounts.Name = "toggleUserAccounts";
            this.toggleUserAccounts.OffBackColor = System.Drawing.Color.Gray;
            this.toggleUserAccounts.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleUserAccounts.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toggleUserAccounts.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleUserAccounts.Size = new System.Drawing.Size(45, 22);
            this.toggleUserAccounts.TabIndex = 17;
            this.toggleUserAccounts.UseVisualStyleBackColor = true;
            this.toggleUserAccounts.CheckedChanged += new System.EventHandler(this.toggleUserAccounts_CheckedChanged);
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAutoStart.AutoSize = true;
            this.btnAutoStart.Location = new System.Drawing.Point(221, 81);
            this.btnAutoStart.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.OffBackColor = System.Drawing.Color.Gray;
            this.btnAutoStart.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnAutoStart.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAutoStart.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnAutoStart.Size = new System.Drawing.Size(45, 22);
            this.btnAutoStart.TabIndex = 14;
            this.btnAutoStart.UseVisualStyleBackColor = true;
            this.btnAutoStart.CheckedChanged += new System.EventHandler(this.BtnAutoStart_CheckedChanged);
            // 
            // toggleWinTheme
            // 
            this.toggleWinTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleWinTheme.AutoSize = true;
            this.toggleWinTheme.Location = new System.Drawing.Point(222, 81);
            this.toggleWinTheme.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleWinTheme.Name = "toggleWinTheme";
            this.toggleWinTheme.OffBackColor = System.Drawing.Color.Gray;
            this.toggleWinTheme.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleWinTheme.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toggleWinTheme.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleWinTheme.Size = new System.Drawing.Size(45, 22);
            this.toggleWinTheme.TabIndex = 14;
            this.toggleWinTheme.UseVisualStyleBackColor = true;
            this.toggleWinTheme.CheckedChanged += new System.EventHandler(this.ToggleWinTheme_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1185, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTheme.ResumeLayout(false);
            this.pnlTheme.PerformLayout();
            this.pnlAutoStart.ResumeLayout(false);
            this.pnlAutoStart.PerformLayout();
            this.pnlResetConfig.ResumeLayout(false);
            this.pnlResetConfig.PerformLayout();
            this.pnlDisableAccSignup.ResumeLayout(false);
            this.pnlDisableAccSignup.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAutoStart;
        private System.Windows.Forms.Label label14;
        private Controls.EvolveToggleButton btnAutoStart;
        private System.Windows.Forms.Label lblWinTheme;
        private System.Windows.Forms.Label label2;
        public Controls.EvolveToggleButton toggleWinTheme;
        private System.Windows.Forms.Label lblDefaultSettings;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnDefaultSettings;
        private System.Windows.Forms.Label lblDisableAccSignup;
        private System.Windows.Forms.Label label3;
        private Controls.EvolveToggleButton toggleUserAccounts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTheme;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDisableAccSignup;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlResetConfig;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlAutoStart;
        private System.Windows.Forms.Panel pnlHeader;
    }
}