namespace EvolveSettings.Forms
{
    partial class PrivacyAndServicesForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMsStore = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.toggleMsStoreUpdate = new EvolveSettings.Controls.EvolveToggleButton();
            this.lblMsStoreSum = new System.Windows.Forms.Label();
            this.lblMsStore = new System.Windows.Forms.Label();
            this.pnlInsiderService = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.toggleInsiderService = new EvolveSettings.Controls.EvolveToggleButton();
            this.lblInsiderServiceSum = new System.Windows.Forms.Label();
            this.lblInsiderService = new System.Windows.Forms.Label();
            this.pnlExcludeDriverUpdates = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.toggleExcludeDrivers = new EvolveSettings.Controls.EvolveToggleButton();
            this.lblExcludeDriversSum = new System.Windows.Forms.Label();
            this.lblExcludeDrivers = new System.Windows.Forms.Label();
            this.pnlWinUpdates = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.toggleWinUpdate = new EvolveSettings.Controls.EvolveToggleButton();
            this.lblWinUpdateSum = new System.Windows.Forms.Label();
            this.lblWinUpdate = new System.Windows.Forms.Label();
            this.pnlBack = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlMsStore.SuspendLayout();
            this.pnlInsiderService.SuspendLayout();
            this.pnlExcludeDriverUpdates.SuspendLayout();
            this.pnlWinUpdates.SuspendLayout();
            this.pnlBack.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1322, 49);
            this.pnlHeader.TabIndex = 18;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 38);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Privacy And Services ";
            this.lblTitle.UseCompatibleTextRendering = true;
            // 
            // pnlMsStore
            // 
            this.pnlMsStore.BackColor = System.Drawing.Color.Transparent;
            this.pnlMsStore.Controls.Add(this.lblMsStore);
            this.pnlMsStore.Controls.Add(this.lblMsStoreSum);
            this.pnlMsStore.Controls.Add(this.toggleMsStoreUpdate);
            this.pnlMsStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMsStore.FillColor = System.Drawing.Color.White;
            this.pnlMsStore.Location = new System.Drawing.Point(20, 3);
            this.pnlMsStore.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.pnlMsStore.Name = "pnlMsStore";
            this.pnlMsStore.Radius = 2;
            this.pnlMsStore.ShadowColor = System.Drawing.Color.Black;
            this.pnlMsStore.ShadowDepth = 250;
            this.pnlMsStore.ShadowShift = 3;
            this.pnlMsStore.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlMsStore.Size = new System.Drawing.Size(1241, 65);
            this.pnlMsStore.TabIndex = 0;
            // 
            // toggleMsStoreUpdate
            // 
            this.toggleMsStoreUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleMsStoreUpdate.AutoSize = true;
            this.toggleMsStoreUpdate.Location = new System.Drawing.Point(1175, 22);
            this.toggleMsStoreUpdate.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleMsStoreUpdate.Name = "toggleMsStoreUpdate";
            this.toggleMsStoreUpdate.OffBackColor = System.Drawing.Color.Gray;
            this.toggleMsStoreUpdate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleMsStoreUpdate.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toggleMsStoreUpdate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleMsStoreUpdate.Size = new System.Drawing.Size(45, 22);
            this.toggleMsStoreUpdate.TabIndex = 23;
            this.toggleMsStoreUpdate.UseVisualStyleBackColor = true;
            this.toggleMsStoreUpdate.CheckedChanged += new System.EventHandler(this.ToggleMsStoreUpdate_CheckedChanged);
            // 
            // lblMsStoreSum
            // 
            this.lblMsStoreSum.AutoSize = true;
            this.lblMsStoreSum.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsStoreSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblMsStoreSum.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblMsStoreSum.Location = new System.Drawing.Point(21, 32);
            this.lblMsStoreSum.Name = "lblMsStoreSum";
            this.lblMsStoreSum.Size = new System.Drawing.Size(226, 13);
            this.lblMsStoreSum.TabIndex = 13;
            this.lblMsStoreSum.Text = "Disable Microsoft Store automatic updates";
            // 
            // lblMsStore
            // 
            this.lblMsStore.AutoSize = true;
            this.lblMsStore.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsStore.ForeColor = System.Drawing.Color.Black;
            this.lblMsStore.Location = new System.Drawing.Point(21, 15);
            this.lblMsStore.Name = "lblMsStore";
            this.lblMsStore.Size = new System.Drawing.Size(103, 17);
            this.lblMsStore.TabIndex = 14;
            this.lblMsStore.Text = "Microsoft Store";
            // 
            // pnlInsiderService
            // 
            this.pnlInsiderService.BackColor = System.Drawing.Color.Transparent;
            this.pnlInsiderService.Controls.Add(this.lblInsiderService);
            this.pnlInsiderService.Controls.Add(this.lblInsiderServiceSum);
            this.pnlInsiderService.Controls.Add(this.toggleInsiderService);
            this.pnlInsiderService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInsiderService.FillColor = System.Drawing.Color.White;
            this.pnlInsiderService.Location = new System.Drawing.Point(20, 3);
            this.pnlInsiderService.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.pnlInsiderService.Name = "pnlInsiderService";
            this.pnlInsiderService.Radius = 2;
            this.pnlInsiderService.ShadowColor = System.Drawing.Color.Black;
            this.pnlInsiderService.ShadowDepth = 250;
            this.pnlInsiderService.ShadowShift = 3;
            this.pnlInsiderService.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlInsiderService.Size = new System.Drawing.Size(1241, 65);
            this.pnlInsiderService.TabIndex = 0;
            // 
            // toggleInsiderService
            // 
            this.toggleInsiderService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleInsiderService.AutoSize = true;
            this.toggleInsiderService.Location = new System.Drawing.Point(1175, 22);
            this.toggleInsiderService.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleInsiderService.Name = "toggleInsiderService";
            this.toggleInsiderService.OffBackColor = System.Drawing.Color.Gray;
            this.toggleInsiderService.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleInsiderService.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toggleInsiderService.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleInsiderService.Size = new System.Drawing.Size(45, 22);
            this.toggleInsiderService.TabIndex = 28;
            this.toggleInsiderService.UseVisualStyleBackColor = true;
            this.toggleInsiderService.CheckedChanged += new System.EventHandler(this.ToggleInsiderService_CheckedChanged);
            // 
            // lblInsiderServiceSum
            // 
            this.lblInsiderServiceSum.AutoSize = true;
            this.lblInsiderServiceSum.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiderServiceSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblInsiderServiceSum.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInsiderServiceSum.Location = new System.Drawing.Point(21, 32);
            this.lblInsiderServiceSum.Name = "lblInsiderServiceSum";
            this.lblInsiderServiceSum.Size = new System.Drawing.Size(923, 13);
            this.lblInsiderServiceSum.TabIndex = 13;
            this.lblInsiderServiceSum.Text = "Windows insider program allows you to test the latest features before released to" +
    " the public. It\'s considered an unnecesaary service for some users who don\'t wis" +
    "h to participate. ";
            // 
            // lblInsiderService
            // 
            this.lblInsiderService.AutoSize = true;
            this.lblInsiderService.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiderService.ForeColor = System.Drawing.Color.Black;
            this.lblInsiderService.Location = new System.Drawing.Point(21, 15);
            this.lblInsiderService.Name = "lblInsiderService";
            this.lblInsiderService.Size = new System.Drawing.Size(98, 17);
            this.lblInsiderService.TabIndex = 14;
            this.lblInsiderService.Text = "Insider Service";
            // 
            // pnlExcludeDriverUpdates
            // 
            this.pnlExcludeDriverUpdates.BackColor = System.Drawing.Color.Transparent;
            this.pnlExcludeDriverUpdates.Controls.Add(this.lblExcludeDrivers);
            this.pnlExcludeDriverUpdates.Controls.Add(this.lblExcludeDriversSum);
            this.pnlExcludeDriverUpdates.Controls.Add(this.toggleExcludeDrivers);
            this.pnlExcludeDriverUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExcludeDriverUpdates.FillColor = System.Drawing.Color.White;
            this.pnlExcludeDriverUpdates.Location = new System.Drawing.Point(20, 3);
            this.pnlExcludeDriverUpdates.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.pnlExcludeDriverUpdates.Name = "pnlExcludeDriverUpdates";
            this.pnlExcludeDriverUpdates.Radius = 2;
            this.pnlExcludeDriverUpdates.ShadowColor = System.Drawing.Color.Black;
            this.pnlExcludeDriverUpdates.ShadowDepth = 250;
            this.pnlExcludeDriverUpdates.ShadowShift = 3;
            this.pnlExcludeDriverUpdates.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlExcludeDriverUpdates.Size = new System.Drawing.Size(1241, 65);
            this.pnlExcludeDriverUpdates.TabIndex = 0;
            // 
            // toggleExcludeDrivers
            // 
            this.toggleExcludeDrivers.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleExcludeDrivers.AutoSize = true;
            this.toggleExcludeDrivers.Location = new System.Drawing.Point(1175, 22);
            this.toggleExcludeDrivers.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleExcludeDrivers.Name = "toggleExcludeDrivers";
            this.toggleExcludeDrivers.OffBackColor = System.Drawing.Color.Gray;
            this.toggleExcludeDrivers.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleExcludeDrivers.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toggleExcludeDrivers.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleExcludeDrivers.Size = new System.Drawing.Size(45, 22);
            this.toggleExcludeDrivers.TabIndex = 19;
            this.toggleExcludeDrivers.UseVisualStyleBackColor = true;
            this.toggleExcludeDrivers.CheckedChanged += new System.EventHandler(this.ToggleExcludeDrivers_CheckedChanged);
            // 
            // lblExcludeDriversSum
            // 
            this.lblExcludeDriversSum.AutoSize = true;
            this.lblExcludeDriversSum.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcludeDriversSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblExcludeDriversSum.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblExcludeDriversSum.Location = new System.Drawing.Point(21, 32);
            this.lblExcludeDriversSum.Name = "lblExcludeDriversSum";
            this.lblExcludeDriversSum.Size = new System.Drawing.Size(522, 13);
            this.lblExcludeDriversSum.TabIndex = 13;
            this.lblExcludeDriversSum.Text = "This is useful when windows update constantly replaces a properly working driver " +
    "with a faulty one.";
            // 
            // lblExcludeDrivers
            // 
            this.lblExcludeDrivers.AutoSize = true;
            this.lblExcludeDrivers.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcludeDrivers.ForeColor = System.Drawing.Color.Black;
            this.lblExcludeDrivers.Location = new System.Drawing.Point(21, 15);
            this.lblExcludeDrivers.Name = "lblExcludeDrivers";
            this.lblExcludeDrivers.Size = new System.Drawing.Size(148, 17);
            this.lblExcludeDrivers.TabIndex = 14;
            this.lblExcludeDrivers.Text = "Exclude driver updates";
            // 
            // pnlWinUpdates
            // 
            this.pnlWinUpdates.BackColor = System.Drawing.Color.Transparent;
            this.pnlWinUpdates.Controls.Add(this.lblWinUpdate);
            this.pnlWinUpdates.Controls.Add(this.lblWinUpdateSum);
            this.pnlWinUpdates.Controls.Add(this.toggleWinUpdate);
            this.pnlWinUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWinUpdates.FillColor = System.Drawing.Color.White;
            this.pnlWinUpdates.Location = new System.Drawing.Point(20, 20);
            this.pnlWinUpdates.Margin = new System.Windows.Forms.Padding(20, 20, 20, 3);
            this.pnlWinUpdates.Name = "pnlWinUpdates";
            this.pnlWinUpdates.Radius = 2;
            this.pnlWinUpdates.ShadowColor = System.Drawing.Color.Black;
            this.pnlWinUpdates.ShadowDepth = 250;
            this.pnlWinUpdates.ShadowShift = 3;
            this.pnlWinUpdates.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlWinUpdates.Size = new System.Drawing.Size(1241, 65);
            this.pnlWinUpdates.TabIndex = 0;
            // 
            // toggleWinUpdate
            // 
            this.toggleWinUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleWinUpdate.AutoSize = true;
            this.toggleWinUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.toggleWinUpdate.Location = new System.Drawing.Point(1175, 22);
            this.toggleWinUpdate.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleWinUpdate.Name = "toggleWinUpdate";
            this.toggleWinUpdate.OffBackColor = System.Drawing.Color.Gray;
            this.toggleWinUpdate.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleWinUpdate.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toggleWinUpdate.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleWinUpdate.Size = new System.Drawing.Size(45, 22);
            this.toggleWinUpdate.TabIndex = 15;
            this.toggleWinUpdate.UseVisualStyleBackColor = true;
            this.toggleWinUpdate.CheckedChanged += new System.EventHandler(this.ToggleWinUpdate_CheckedChanged);
            // 
            // lblWinUpdateSum
            // 
            this.lblWinUpdateSum.AutoSize = true;
            this.lblWinUpdateSum.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinUpdateSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(151)))), ((int)(((byte)(176)))));
            this.lblWinUpdateSum.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWinUpdateSum.Location = new System.Drawing.Point(21, 32);
            this.lblWinUpdateSum.Name = "lblWinUpdateSum";
            this.lblWinUpdateSum.Size = new System.Drawing.Size(939, 13);
            this.lblWinUpdateSum.TabIndex = 13;
            this.lblWinUpdateSum.Text = "Disable automatic downloading and installation of Windows updates. A notification" +
    " is shown when new updates are available. This will also disable the delivery op" +
    "timization service";
            // 
            // lblWinUpdate
            // 
            this.lblWinUpdate.AutoSize = true;
            this.lblWinUpdate.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblWinUpdate.Location = new System.Drawing.Point(21, 15);
            this.lblWinUpdate.Name = "lblWinUpdate";
            this.lblWinUpdate.Size = new System.Drawing.Size(113, 17);
            this.lblWinUpdate.TabIndex = 14;
            this.lblWinUpdate.Text = "Windows Update";
            // 
            // pnlBack
            // 
            this.pnlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBack.AutoScroll = true;
            this.pnlBack.BackColor = System.Drawing.Color.Transparent;
            this.pnlBack.Controls.Add(this.tableLayoutPanel3);
            this.pnlBack.Controls.Add(this.tableLayoutPanel2);
            this.pnlBack.Controls.Add(this.tableLayoutPanel1);
            this.pnlBack.Controls.Add(this.tableLayoutPanel4);
            this.pnlBack.FillColor = System.Drawing.Color.White;
            this.pnlBack.Location = new System.Drawing.Point(20, 64);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Radius = 5;
            this.pnlBack.ShadowColor = System.Drawing.Color.Black;
            this.pnlBack.ShadowShift = 0;
            this.pnlBack.Size = new System.Drawing.Size(1281, 679);
            this.pnlBack.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pnlInsiderService, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1281, 71);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.pnlMsStore, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 230);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1281, 71);
            this.tableLayoutPanel3.TabIndex = 32;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.pnlWinUpdates, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1281, 88);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlExcludeDriverUpdates, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 71);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // PrivacyAndServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 762);
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrivacyAndServicesForm";
            this.Text = "PrivacyAndServicesForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMsStore.ResumeLayout(false);
            this.pnlMsStore.PerformLayout();
            this.pnlInsiderService.ResumeLayout(false);
            this.pnlInsiderService.PerformLayout();
            this.pnlExcludeDriverUpdates.ResumeLayout(false);
            this.pnlExcludeDriverUpdates.PerformLayout();
            this.pnlWinUpdates.ResumeLayout(false);
            this.pnlWinUpdates.PerformLayout();
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMsStore;
        private System.Windows.Forms.Label lblMsStore;
        private System.Windows.Forms.Label lblMsStoreSum;
        private Controls.EvolveToggleButton toggleMsStoreUpdate;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlInsiderService;
        private System.Windows.Forms.Label lblInsiderService;
        private System.Windows.Forms.Label lblInsiderServiceSum;
        private Controls.EvolveToggleButton toggleInsiderService;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlExcludeDriverUpdates;
        private System.Windows.Forms.Label lblExcludeDrivers;
        private System.Windows.Forms.Label lblExcludeDriversSum;
        private Controls.EvolveToggleButton toggleExcludeDrivers;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlWinUpdates;
        private System.Windows.Forms.Label lblWinUpdate;
        private System.Windows.Forms.Label lblWinUpdateSum;
        private Controls.EvolveToggleButton toggleWinUpdate;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}