namespace EvolveSettings.Forms
{
    partial class NetworkForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPingIP = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtPingInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExport = new Guna.UI2.WinForms.Guna2Button();
            this.btnShodan = new Guna.UI2.WinForms.Guna2Button();
            this.copyB = new Guna.UI2.WinForms.Guna2Button();
            this.copyIPB = new Guna.UI2.WinForms.Guna2Button();
            this.btnPing = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblIPaddressPing = new System.Windows.Forms.Label();
            this.lblPingResults = new System.Windows.Forms.Label();
            this.pnlDnsServer = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.boxDNS = new Guna.UI2.WinForms.Guna2ComboBox();
            this.boxAdapter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDns6A = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDns6B = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDns4B = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDns4A = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkCustomDns = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAllNics = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnOpenNetwork = new Guna.UI2.WinForms.Guna2Button();
            this.flushCacheB = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetDns = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblIPaddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPresetDNS = new System.Windows.Forms.Label();
            this.lblNetworkAdapter = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkDNSv6A = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.linkDNSv6 = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4 = new System.Windows.Forms.LinkLabel();
            this.linkDNSv4A = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.DefineURLIconDialog = new System.Windows.Forms.OpenFileDialog();
            this.listPingResults = new EvolveSettings.Controls.EvolveListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlPingIP.SuspendLayout();
            this.pnlDnsServer.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlPingIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDnsServer, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1222, 716);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlPingIP
            // 
            this.pnlPingIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPingIP.BackColor = System.Drawing.Color.Transparent;
            this.pnlPingIP.Controls.Add(this.listPingResults);
            this.pnlPingIP.Controls.Add(this.txtPingInput);
            this.pnlPingIP.Controls.Add(this.btnExport);
            this.pnlPingIP.Controls.Add(this.btnShodan);
            this.pnlPingIP.Controls.Add(this.copyB);
            this.pnlPingIP.Controls.Add(this.copyIPB);
            this.pnlPingIP.Controls.Add(this.btnPing);
            this.pnlPingIP.Controls.Add(this.label9);
            this.pnlPingIP.Controls.Add(this.label8);
            this.pnlPingIP.Controls.Add(this.lblIPaddressPing);
            this.pnlPingIP.Controls.Add(this.lblPingResults);
            this.pnlPingIP.FillColor = System.Drawing.Color.White;
            this.pnlPingIP.Location = new System.Drawing.Point(616, 3);
            this.pnlPingIP.Margin = new System.Windows.Forms.Padding(5, 3, 28, 25);
            this.pnlPingIP.Name = "pnlPingIP";
            this.pnlPingIP.Radius = 5;
            this.pnlPingIP.ShadowColor = System.Drawing.Color.Black;
            this.pnlPingIP.ShadowDepth = 250;
            this.pnlPingIP.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlPingIP.Size = new System.Drawing.Size(578, 688);
            this.pnlPingIP.TabIndex = 1;
            // 
            // txtPingInput
            // 
            this.txtPingInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPingInput.Animated = true;
            this.txtPingInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtPingInput.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtPingInput.BorderRadius = 5;
            this.txtPingInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPingInput.DefaultText = "";
            this.txtPingInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPingInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPingInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPingInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPingInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPingInput.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPingInput.ForeColor = System.Drawing.Color.Black;
            this.txtPingInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPingInput.Location = new System.Drawing.Point(90, 165);
            this.txtPingInput.Name = "txtPingInput";
            this.txtPingInput.PasswordChar = '\0';
            this.txtPingInput.PlaceholderText = "";
            this.txtPingInput.SelectedText = "";
            this.txtPingInput.Size = new System.Drawing.Size(194, 34);
            this.txtPingInput.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPingInput.TabIndex = 170;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Animated = true;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BorderRadius = 15;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnExport.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(180, 511);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 32);
            this.btnExport.TabIndex = 169;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnShodan
            // 
            this.btnShodan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShodan.Animated = true;
            this.btnShodan.BackColor = System.Drawing.Color.Transparent;
            this.btnShodan.BorderRadius = 15;
            this.btnShodan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShodan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShodan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShodan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShodan.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnShodan.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShodan.ForeColor = System.Drawing.Color.White;
            this.btnShodan.Location = new System.Drawing.Point(444, 612);
            this.btnShodan.Name = "btnShodan";
            this.btnShodan.Size = new System.Drawing.Size(104, 32);
            this.btnShodan.TabIndex = 168;
            this.btnShodan.Text = "Check";
            this.btnShodan.Click += new System.EventHandler(this.btnShodan_Click);
            // 
            // copyB
            // 
            this.copyB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyB.Animated = true;
            this.copyB.BackColor = System.Drawing.Color.Transparent;
            this.copyB.BorderRadius = 15;
            this.copyB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyB.FillColor = System.Drawing.Color.MidnightBlue;
            this.copyB.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyB.ForeColor = System.Drawing.Color.White;
            this.copyB.Location = new System.Drawing.Point(324, 612);
            this.copyB.Name = "copyB";
            this.copyB.Size = new System.Drawing.Size(104, 32);
            this.copyB.TabIndex = 167;
            this.copyB.Text = "Copy IP";
            this.copyB.Click += new System.EventHandler(this.copyB_Click);
            // 
            // copyIPB
            // 
            this.copyIPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyIPB.Animated = true;
            this.copyIPB.BackColor = System.Drawing.Color.Transparent;
            this.copyIPB.BorderRadius = 15;
            this.copyIPB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyIPB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyIPB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyIPB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyIPB.FillColor = System.Drawing.Color.MidnightBlue;
            this.copyIPB.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyIPB.ForeColor = System.Drawing.Color.White;
            this.copyIPB.Location = new System.Drawing.Point(444, 168);
            this.copyIPB.Name = "copyIPB";
            this.copyIPB.Size = new System.Drawing.Size(104, 32);
            this.copyIPB.TabIndex = 166;
            this.copyIPB.Text = "Copy";
            this.copyIPB.Click += new System.EventHandler(this.copyIPB_Click);
            // 
            // btnPing
            // 
            this.btnPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPing.Animated = true;
            this.btnPing.BackColor = System.Drawing.Color.Transparent;
            this.btnPing.BorderRadius = 15;
            this.btnPing.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPing.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPing.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPing.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPing.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnPing.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPing.ForeColor = System.Drawing.Color.White;
            this.btnPing.Location = new System.Drawing.Point(324, 168);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(104, 32);
            this.btnPing.TabIndex = 164;
            this.btnPing.Text = "Ping";
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(321, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 36);
            this.label9.TabIndex = 165;
            this.label9.Text = "Check for IP information on Shodan.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 161;
            this.label8.Text = "Ping IP Address";
            // 
            // lblIPaddressPing
            // 
            this.lblIPaddressPing.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPaddressPing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblIPaddressPing.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblIPaddressPing.Location = new System.Drawing.Point(87, 144);
            this.lblIPaddressPing.Name = "lblIPaddressPing";
            this.lblIPaddressPing.Size = new System.Drawing.Size(129, 17);
            this.lblIPaddressPing.TabIndex = 162;
            this.lblIPaddressPing.Text = "IP Address";
            // 
            // lblPingResults
            // 
            this.lblPingResults.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPingResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblPingResults.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPingResults.Location = new System.Drawing.Point(87, 269);
            this.lblPingResults.Name = "lblPingResults";
            this.lblPingResults.Size = new System.Drawing.Size(129, 17);
            this.lblPingResults.TabIndex = 163;
            this.lblPingResults.Text = "Results";
            // 
            // pnlDnsServer
            // 
            this.pnlDnsServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDnsServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlDnsServer.Controls.Add(this.boxDNS);
            this.pnlDnsServer.Controls.Add(this.boxAdapter);
            this.pnlDnsServer.Controls.Add(this.txtDns6A);
            this.pnlDnsServer.Controls.Add(this.txtDns6B);
            this.pnlDnsServer.Controls.Add(this.txtDns4B);
            this.pnlDnsServer.Controls.Add(this.txtDns4A);
            this.pnlDnsServer.Controls.Add(this.chkCustomDns);
            this.pnlDnsServer.Controls.Add(this.chkAllNics);
            this.pnlDnsServer.Controls.Add(this.btnOpenNetwork);
            this.pnlDnsServer.Controls.Add(this.flushCacheB);
            this.pnlDnsServer.Controls.Add(this.btnSetDns);
            this.pnlDnsServer.Controls.Add(this.label7);
            this.pnlDnsServer.Controls.Add(this.label6);
            this.pnlDnsServer.Controls.Add(this.lblIPaddress);
            this.pnlDnsServer.Controls.Add(this.label5);
            this.pnlDnsServer.Controls.Add(this.lblPresetDNS);
            this.pnlDnsServer.Controls.Add(this.lblNetworkAdapter);
            this.pnlDnsServer.Controls.Add(this.label10);
            this.pnlDnsServer.Controls.Add(this.label3);
            this.pnlDnsServer.Controls.Add(this.linkDNSv6A);
            this.pnlDnsServer.Controls.Add(this.label12);
            this.pnlDnsServer.Controls.Add(this.linkDNSv6);
            this.pnlDnsServer.Controls.Add(this.linkDNSv4);
            this.pnlDnsServer.Controls.Add(this.linkDNSv4A);
            this.pnlDnsServer.Controls.Add(this.label11);
            this.pnlDnsServer.Controls.Add(this.label1);
            this.pnlDnsServer.Controls.Add(this.label2);
            this.pnlDnsServer.FillColor = System.Drawing.Color.White;
            this.pnlDnsServer.Location = new System.Drawing.Point(28, 3);
            this.pnlDnsServer.Margin = new System.Windows.Forms.Padding(28, 3, 5, 25);
            this.pnlDnsServer.Name = "pnlDnsServer";
            this.pnlDnsServer.Radius = 5;
            this.pnlDnsServer.ShadowColor = System.Drawing.Color.Black;
            this.pnlDnsServer.ShadowDepth = 250;
            this.pnlDnsServer.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlDnsServer.Size = new System.Drawing.Size(578, 688);
            this.pnlDnsServer.TabIndex = 0;
            // 
            // boxDNS
            // 
            this.boxDNS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxDNS.BackColor = System.Drawing.Color.Transparent;
            this.boxDNS.BorderColor = System.Drawing.Color.MidnightBlue;
            this.boxDNS.BorderRadius = 5;
            this.boxDNS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boxDNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxDNS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxDNS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxDNS.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDNS.ForeColor = System.Drawing.Color.Black;
            this.boxDNS.ItemHeight = 16;
            this.boxDNS.Location = new System.Drawing.Point(82, 269);
            this.boxDNS.Name = "boxDNS";
            this.boxDNS.ShadowDecoration.BorderRadius = 0;
            this.boxDNS.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.boxDNS.Size = new System.Drawing.Size(406, 22);
            this.boxDNS.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.boxDNS.TabIndex = 193;
            // 
            // boxAdapter
            // 
            this.boxAdapter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAdapter.BackColor = System.Drawing.Color.Transparent;
            this.boxAdapter.BorderColor = System.Drawing.Color.MidnightBlue;
            this.boxAdapter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.boxAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxAdapter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxAdapter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.boxAdapter.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxAdapter.ForeColor = System.Drawing.Color.Black;
            this.boxAdapter.ItemHeight = 16;
            this.boxAdapter.Location = new System.Drawing.Point(82, 177);
            this.boxAdapter.Name = "boxAdapter";
            this.boxAdapter.ShadowDecoration.BorderRadius = 0;
            this.boxAdapter.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.boxAdapter.Size = new System.Drawing.Size(406, 22);
            this.boxAdapter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.boxAdapter.TabIndex = 192;
            // 
            // txtDns6A
            // 
            this.txtDns6A.Animated = true;
            this.txtDns6A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtDns6A.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDns6A.BorderRadius = 5;
            this.txtDns6A.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDns6A.DefaultText = "";
            this.txtDns6A.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDns6A.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDns6A.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns6A.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns6A.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns6A.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns6A.ForeColor = System.Drawing.Color.Black;
            this.txtDns6A.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns6A.Location = new System.Drawing.Point(294, 255);
            this.txtDns6A.Name = "txtDns6A";
            this.txtDns6A.PasswordChar = '\0';
            this.txtDns6A.PlaceholderText = "";
            this.txtDns6A.SelectedText = "";
            this.txtDns6A.Size = new System.Drawing.Size(194, 34);
            this.txtDns6A.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDns6A.TabIndex = 191;
            this.txtDns6A.Visible = false;
            // 
            // txtDns6B
            // 
            this.txtDns6B.Animated = true;
            this.txtDns6B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtDns6B.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDns6B.BorderRadius = 5;
            this.txtDns6B.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDns6B.DefaultText = "";
            this.txtDns6B.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDns6B.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDns6B.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns6B.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns6B.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns6B.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns6B.ForeColor = System.Drawing.Color.Black;
            this.txtDns6B.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns6B.Location = new System.Drawing.Point(294, 314);
            this.txtDns6B.Name = "txtDns6B";
            this.txtDns6B.PasswordChar = '\0';
            this.txtDns6B.PlaceholderText = "";
            this.txtDns6B.SelectedText = "";
            this.txtDns6B.Size = new System.Drawing.Size(194, 34);
            this.txtDns6B.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDns6B.TabIndex = 190;
            this.txtDns6B.Visible = false;
            // 
            // txtDns4B
            // 
            this.txtDns4B.Animated = true;
            this.txtDns4B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtDns4B.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDns4B.BorderRadius = 5;
            this.txtDns4B.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDns4B.DefaultText = "";
            this.txtDns4B.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDns4B.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDns4B.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns4B.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns4B.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns4B.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns4B.ForeColor = System.Drawing.Color.Black;
            this.txtDns4B.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns4B.Location = new System.Drawing.Point(82, 314);
            this.txtDns4B.Name = "txtDns4B";
            this.txtDns4B.PasswordChar = '\0';
            this.txtDns4B.PlaceholderText = "";
            this.txtDns4B.SelectedText = "";
            this.txtDns4B.Size = new System.Drawing.Size(194, 34);
            this.txtDns4B.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDns4B.TabIndex = 189;
            this.txtDns4B.Visible = false;
            // 
            // txtDns4A
            // 
            this.txtDns4A.Animated = true;
            this.txtDns4A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.txtDns4A.BorderColor = System.Drawing.Color.MidnightBlue;
            this.txtDns4A.BorderRadius = 5;
            this.txtDns4A.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDns4A.DefaultText = "";
            this.txtDns4A.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDns4A.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDns4A.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns4A.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDns4A.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns4A.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDns4A.ForeColor = System.Drawing.Color.Black;
            this.txtDns4A.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDns4A.Location = new System.Drawing.Point(82, 255);
            this.txtDns4A.Name = "txtDns4A";
            this.txtDns4A.PasswordChar = '\0';
            this.txtDns4A.PlaceholderText = "";
            this.txtDns4A.SelectedText = "";
            this.txtDns4A.Size = new System.Drawing.Size(194, 34);
            this.txtDns4A.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDns4A.TabIndex = 188;
            this.txtDns4A.Visible = false;
            // 
            // chkCustomDns
            // 
            this.chkCustomDns.Animated = true;
            this.chkCustomDns.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCustomDns.CheckedState.BorderRadius = 0;
            this.chkCustomDns.CheckedState.BorderThickness = 0;
            this.chkCustomDns.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkCustomDns.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomDns.Location = new System.Drawing.Point(294, 394);
            this.chkCustomDns.Name = "chkCustomDns";
            this.chkCustomDns.Size = new System.Drawing.Size(15, 15);
            this.chkCustomDns.TabIndex = 187;
            this.chkCustomDns.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkCustomDns.UncheckedState.BorderRadius = 0;
            this.chkCustomDns.UncheckedState.BorderThickness = 0;
            this.chkCustomDns.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkCustomDns.CheckedChanged += new System.EventHandler(this.ChkCustomDns_CheckedChanged);
            // 
            // chkAllNics
            // 
            this.chkAllNics.Animated = true;
            this.chkAllNics.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAllNics.CheckedState.BorderRadius = 0;
            this.chkAllNics.CheckedState.BorderThickness = 0;
            this.chkAllNics.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkAllNics.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllNics.Location = new System.Drawing.Point(294, 370);
            this.chkAllNics.Name = "chkAllNics";
            this.chkAllNics.Size = new System.Drawing.Size(15, 15);
            this.chkAllNics.TabIndex = 186;
            this.chkAllNics.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAllNics.UncheckedState.BorderRadius = 0;
            this.chkAllNics.UncheckedState.BorderThickness = 0;
            this.chkAllNics.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // btnOpenNetwork
            // 
            this.btnOpenNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenNetwork.Animated = true;
            this.btnOpenNetwork.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenNetwork.BorderRadius = 15;
            this.btnOpenNetwork.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenNetwork.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenNetwork.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenNetwork.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenNetwork.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnOpenNetwork.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenNetwork.ForeColor = System.Drawing.Color.White;
            this.btnOpenNetwork.Location = new System.Drawing.Point(412, 612);
            this.btnOpenNetwork.Name = "btnOpenNetwork";
            this.btnOpenNetwork.Size = new System.Drawing.Size(141, 32);
            this.btnOpenNetwork.TabIndex = 185;
            this.btnOpenNetwork.Text = "Network Connections";
            this.btnOpenNetwork.Click += new System.EventHandler(this.btnOpenNetwork_Click);
            // 
            // flushCacheB
            // 
            this.flushCacheB.Animated = true;
            this.flushCacheB.BackColor = System.Drawing.Color.Transparent;
            this.flushCacheB.BorderRadius = 15;
            this.flushCacheB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.flushCacheB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.flushCacheB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.flushCacheB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.flushCacheB.FillColor = System.Drawing.Color.MidnightBlue;
            this.flushCacheB.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushCacheB.ForeColor = System.Drawing.Color.White;
            this.flushCacheB.Location = new System.Drawing.Point(180, 370);
            this.flushCacheB.Name = "flushCacheB";
            this.flushCacheB.Size = new System.Drawing.Size(96, 32);
            this.flushCacheB.TabIndex = 184;
            this.flushCacheB.Text = "Clear Cache";
            this.flushCacheB.Click += new System.EventHandler(this.flushCacheB_Click);
            // 
            // btnSetDns
            // 
            this.btnSetDns.Animated = true;
            this.btnSetDns.BackColor = System.Drawing.Color.Transparent;
            this.btnSetDns.BorderRadius = 15;
            this.btnSetDns.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetDns.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetDns.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetDns.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetDns.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSetDns.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDns.ForeColor = System.Drawing.Color.White;
            this.btnSetDns.Location = new System.Drawing.Point(82, 370);
            this.btnSetDns.Name = "btnSetDns";
            this.btnSetDns.Size = new System.Drawing.Size(96, 32);
            this.btnSetDns.TabIndex = 183;
            this.btnSetDns.Text = "Set dns";
            this.btnSetDns.Click += new System.EventHandler(this.btnSetDns_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(79, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 182;
            this.label7.Text = "IP Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 180;
            this.label6.Text = "DNS Server";
            // 
            // lblIPaddress
            // 
            this.lblIPaddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIPaddress.AutoSize = true;
            this.lblIPaddress.Font = new System.Drawing.Font("Nirmala UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblIPaddress.Location = new System.Drawing.Point(79, 548);
            this.lblIPaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPaddress.Name = "lblIPaddress";
            this.lblIPaddress.Size = new System.Drawing.Size(62, 13);
            this.lblIPaddress.TabIndex = 181;
            this.lblIPaddress.Tag = "";
            this.lblIPaddress.Text = "IP Address";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(81, 573);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 179;
            this.label5.Text = "Current DNS Settings";
            // 
            // lblPresetDNS
            // 
            this.lblPresetDNS.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresetDNS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblPresetDNS.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPresetDNS.Location = new System.Drawing.Point(79, 232);
            this.lblPresetDNS.Name = "lblPresetDNS";
            this.lblPresetDNS.Size = new System.Drawing.Size(116, 17);
            this.lblPresetDNS.TabIndex = 178;
            this.lblPresetDNS.Text = "Preset DNS Servers";
            // 
            // lblNetworkAdapter
            // 
            this.lblNetworkAdapter.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkAdapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblNetworkAdapter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNetworkAdapter.Location = new System.Drawing.Point(79, 155);
            this.lblNetworkAdapter.Name = "lblNetworkAdapter";
            this.lblNetworkAdapter.Size = new System.Drawing.Size(98, 17);
            this.lblNetworkAdapter.TabIndex = 177;
            this.lblNetworkAdapter.Text = "Network Adapter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(79, 236);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 167;
            this.label10.Tag = "";
            this.label10.Text = "IPv4";
            this.label10.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(210, 594);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 172;
            this.label3.Tag = "";
            this.label3.Text = "IPv6";
            // 
            // linkDNSv6A
            // 
            this.linkDNSv6A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDNSv6A.AutoSize = true;
            this.linkDNSv6A.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv6A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv6A.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv6A.Location = new System.Drawing.Point(208, 631);
            this.linkDNSv6A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv6A.Name = "linkDNSv6A";
            this.linkDNSv6A.Size = new System.Drawing.Size(11, 13);
            this.linkDNSv6A.TabIndex = 176;
            this.linkDNSv6A.TabStop = true;
            this.linkDNSv6A.Tag = "";
            this.linkDNSv6A.Text = "-";
            this.linkDNSv6A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(295, 236);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 168;
            this.label12.Tag = "";
            this.label12.Text = "IPv6";
            this.label12.Visible = false;
            // 
            // linkDNSv6
            // 
            this.linkDNSv6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDNSv6.AutoSize = true;
            this.linkDNSv6.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv6.Location = new System.Drawing.Point(208, 610);
            this.linkDNSv6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv6.Name = "linkDNSv6";
            this.linkDNSv6.Size = new System.Drawing.Size(11, 13);
            this.linkDNSv6.TabIndex = 174;
            this.linkDNSv6.TabStop = true;
            this.linkDNSv6.Tag = "themeable";
            this.linkDNSv6.Text = "-";
            this.linkDNSv6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkDNSv4
            // 
            this.linkDNSv4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDNSv4.AutoSize = true;
            this.linkDNSv4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv4.Location = new System.Drawing.Point(79, 610);
            this.linkDNSv4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv4.Name = "linkDNSv4";
            this.linkDNSv4.Size = new System.Drawing.Size(11, 13);
            this.linkDNSv4.TabIndex = 173;
            this.linkDNSv4.TabStop = true;
            this.linkDNSv4.Tag = "themeable";
            this.linkDNSv4.Text = "-";
            // 
            // linkDNSv4A
            // 
            this.linkDNSv4A.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkDNSv4A.AutoSize = true;
            this.linkDNSv4A.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkDNSv4A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv4A.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.linkDNSv4A.Location = new System.Drawing.Point(79, 631);
            this.linkDNSv4A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkDNSv4A.Name = "linkDNSv4A";
            this.linkDNSv4A.Size = new System.Drawing.Size(11, 13);
            this.linkDNSv4A.TabIndex = 175;
            this.linkDNSv4A.TabStop = true;
            this.linkDNSv4A.Tag = "themeable";
            this.linkDNSv4A.Text = "-";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(314, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 169;
            this.label11.Text = "Use custom DNS";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(81, 594);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 171;
            this.label1.Tag = "";
            this.label1.Text = "IPv4";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(314, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 170;
            this.label2.Text = "Set for all networks";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1222, 49);
            this.pnlHeader.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 38);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Network";
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // ExportDialog
            // 
            this.ExportDialog.Filter = "Text [*.txt]|*.txt";
            this.ExportDialog.Title = "EvolveSettings";
            // 
            // DefineURLIconDialog
            // 
            this.DefineURLIconDialog.Filter = "Icon [*.ico]|*.ico|Executable [*.exe]|*.exe";
            // 
            // listPingResults
            // 
            this.listPingResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPingResults.BackColor = System.Drawing.Color.DimGray;
            this.listPingResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPingResults.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listPingResults.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPingResults.FormattingEnabled = true;
            this.listPingResults.Location = new System.Drawing.Point(90, 289);
            this.listPingResults.Name = "listPingResults";
            this.listPingResults.Radius = 5;
            this.listPingResults.Size = new System.Drawing.Size(194, 200);
            this.listPingResults.TabIndex = 171;
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 762);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NetworkForm";
            this.Text = "NetworkForm";
            this.Load += new System.EventHandler(this.NetworkForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlPingIP.ResumeLayout(false);
            this.pnlPingIP.PerformLayout();
            this.pnlDnsServer.ResumeLayout(false);
            this.pnlDnsServer.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlDnsServer;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlPingIP;
        private Guna.UI2.WinForms.Guna2ComboBox boxDNS;
        private Guna.UI2.WinForms.Guna2ComboBox boxAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txtDns6A;
        private Guna.UI2.WinForms.Guna2TextBox txtDns6B;
        private Guna.UI2.WinForms.Guna2TextBox txtDns4B;
        private Guna.UI2.WinForms.Guna2TextBox txtDns4A;
        private Guna.UI2.WinForms.Guna2CheckBox chkCustomDns;
        private Guna.UI2.WinForms.Guna2CheckBox chkAllNics;
        private Guna.UI2.WinForms.Guna2Button btnOpenNetwork;
        private Guna.UI2.WinForms.Guna2Button flushCacheB;
        private Guna.UI2.WinForms.Guna2Button btnSetDns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIPaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPresetDNS;
        private System.Windows.Forms.Label lblNetworkAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkDNSv6A;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel linkDNSv6;
        private System.Windows.Forms.LinkLabel linkDNSv4;
        private System.Windows.Forms.LinkLabel linkDNSv4A;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Controls.EvolveListView listPingResults;
        private Guna.UI2.WinForms.Guna2TextBox txtPingInput;
        private Guna.UI2.WinForms.Guna2Button btnExport;
        private Guna.UI2.WinForms.Guna2Button btnShodan;
        private Guna.UI2.WinForms.Guna2Button copyB;
        private Guna.UI2.WinForms.Guna2Button copyIPB;
        private Guna.UI2.WinForms.Guna2Button btnPing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIPaddressPing;
        private System.Windows.Forms.Label lblPingResults;
        internal System.Windows.Forms.SaveFileDialog ExportDialog;
        internal System.Windows.Forms.OpenFileDialog DefineURLIconDialog;
    }
}