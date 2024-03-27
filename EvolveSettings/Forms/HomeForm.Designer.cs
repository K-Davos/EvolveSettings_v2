namespace EvolveSettings.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCpuSpeedData = new System.Windows.Forms.Label();
            this.lblCpuThreadsData = new System.Windows.Forms.Label();
            this.lblStorageAvailableData = new System.Windows.Forms.Label();
            this.lblRamAvailableData = new System.Windows.Forms.Label();
            this.lblCpuCoresData = new System.Windows.Forms.Label();
            this.lblStorageUsedData = new System.Windows.Forms.Label();
            this.lblRamUsedData = new System.Windows.Forms.Label();
            this.lblCpuThreads = new System.Windows.Forms.Label();
            this.lblStorageAvailable = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRamAvailable = new System.Windows.Forms.Label();
            this.lblStorageTotalData = new System.Windows.Forms.Label();
            this.lblRamTotalData = new System.Windows.Forms.Label();
            this.lblCpuCores = new System.Windows.Forms.Label();
            this.lblStorageUsed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRamUsed = new System.Windows.Forms.Label();
            this.lblCpuSpeed = new System.Windows.Forms.Label();
            this.lblStorageTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRamTotal = new System.Windows.Forms.Label();
            this.lblStorage = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.progressBarCPU = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressBarRAM = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressBarStorage = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnCpuInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnGpuInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnOSInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnNICinfo = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(179)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 44);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Home";
            this.lblTitle.UseCompatibleTextRendering = true;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblCpuSpeedData
            // 
            this.lblCpuSpeedData.AutoSize = true;
            this.lblCpuSpeedData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuSpeedData.ForeColor = System.Drawing.Color.White;
            this.lblCpuSpeedData.Location = new System.Drawing.Point(243, 405);
            this.lblCpuSpeedData.Name = "lblCpuSpeedData";
            this.lblCpuSpeedData.Size = new System.Drawing.Size(80, 17);
            this.lblCpuSpeedData.TabIndex = 55;
            this.lblCpuSpeedData.Text = "Calculating...";
            // 
            // lblCpuThreadsData
            // 
            this.lblCpuThreadsData.AutoSize = true;
            this.lblCpuThreadsData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuThreadsData.ForeColor = System.Drawing.Color.White;
            this.lblCpuThreadsData.Location = new System.Drawing.Point(243, 447);
            this.lblCpuThreadsData.Name = "lblCpuThreadsData";
            this.lblCpuThreadsData.Size = new System.Drawing.Size(80, 17);
            this.lblCpuThreadsData.TabIndex = 53;
            this.lblCpuThreadsData.Text = "Calculating...";
            // 
            // lblStorageAvailableData
            // 
            this.lblStorageAvailableData.AutoSize = true;
            this.lblStorageAvailableData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageAvailableData.ForeColor = System.Drawing.Color.White;
            this.lblStorageAvailableData.Location = new System.Drawing.Point(616, 447);
            this.lblStorageAvailableData.Name = "lblStorageAvailableData";
            this.lblStorageAvailableData.Size = new System.Drawing.Size(80, 17);
            this.lblStorageAvailableData.TabIndex = 52;
            this.lblStorageAvailableData.Text = "Calculating...";
            // 
            // lblRamAvailableData
            // 
            this.lblRamAvailableData.AutoSize = true;
            this.lblRamAvailableData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamAvailableData.ForeColor = System.Drawing.Color.White;
            this.lblRamAvailableData.Location = new System.Drawing.Point(415, 447);
            this.lblRamAvailableData.Name = "lblRamAvailableData";
            this.lblRamAvailableData.Size = new System.Drawing.Size(80, 17);
            this.lblRamAvailableData.TabIndex = 51;
            this.lblRamAvailableData.Text = "Calculating...";
            // 
            // lblCpuCoresData
            // 
            this.lblCpuCoresData.AutoSize = true;
            this.lblCpuCoresData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuCoresData.ForeColor = System.Drawing.Color.White;
            this.lblCpuCoresData.Location = new System.Drawing.Point(243, 426);
            this.lblCpuCoresData.Name = "lblCpuCoresData";
            this.lblCpuCoresData.Size = new System.Drawing.Size(80, 17);
            this.lblCpuCoresData.TabIndex = 50;
            this.lblCpuCoresData.Text = "Calculating...";
            // 
            // lblStorageUsedData
            // 
            this.lblStorageUsedData.AutoSize = true;
            this.lblStorageUsedData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageUsedData.ForeColor = System.Drawing.Color.White;
            this.lblStorageUsedData.Location = new System.Drawing.Point(616, 426);
            this.lblStorageUsedData.Name = "lblStorageUsedData";
            this.lblStorageUsedData.Size = new System.Drawing.Size(80, 17);
            this.lblStorageUsedData.TabIndex = 49;
            this.lblStorageUsedData.Text = "Calculating...";
            // 
            // lblRamUsedData
            // 
            this.lblRamUsedData.AutoSize = true;
            this.lblRamUsedData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamUsedData.ForeColor = System.Drawing.Color.White;
            this.lblRamUsedData.Location = new System.Drawing.Point(415, 426);
            this.lblRamUsedData.Name = "lblRamUsedData";
            this.lblRamUsedData.Size = new System.Drawing.Size(80, 17);
            this.lblRamUsedData.TabIndex = 48;
            this.lblRamUsedData.Text = "Calculating...";
            // 
            // lblCpuThreads
            // 
            this.lblCpuThreads.AutoSize = true;
            this.lblCpuThreads.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuThreads.ForeColor = System.Drawing.Color.White;
            this.lblCpuThreads.Location = new System.Drawing.Point(144, 447);
            this.lblCpuThreads.Name = "lblCpuThreads";
            this.lblCpuThreads.Size = new System.Drawing.Size(61, 17);
            this.lblCpuThreads.TabIndex = 47;
            this.lblCpuThreads.Text = "Threads:";
            // 
            // lblStorageAvailable
            // 
            this.lblStorageAvailable.AutoSize = true;
            this.lblStorageAvailable.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageAvailable.ForeColor = System.Drawing.Color.White;
            this.lblStorageAvailable.Location = new System.Drawing.Point(545, 447);
            this.lblStorageAvailable.Name = "lblStorageAvailable";
            this.lblStorageAvailable.Size = new System.Drawing.Size(69, 17);
            this.lblStorageAvailable.TabIndex = 46;
            this.lblStorageAvailable.Text = "Avaliable:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(544, 447);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "Avaliable:";
            // 
            // lblRamAvailable
            // 
            this.lblRamAvailable.AutoSize = true;
            this.lblRamAvailable.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamAvailable.ForeColor = System.Drawing.Color.White;
            this.lblRamAvailable.Location = new System.Drawing.Point(344, 447);
            this.lblRamAvailable.Name = "lblRamAvailable";
            this.lblRamAvailable.Size = new System.Drawing.Size(69, 17);
            this.lblRamAvailable.TabIndex = 44;
            this.lblRamAvailable.Text = "Avaliable:";
            // 
            // lblStorageTotalData
            // 
            this.lblStorageTotalData.AutoSize = true;
            this.lblStorageTotalData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageTotalData.ForeColor = System.Drawing.Color.White;
            this.lblStorageTotalData.Location = new System.Drawing.Point(616, 405);
            this.lblStorageTotalData.Name = "lblStorageTotalData";
            this.lblStorageTotalData.Size = new System.Drawing.Size(80, 17);
            this.lblStorageTotalData.TabIndex = 43;
            this.lblStorageTotalData.Text = "Calculating...";
            // 
            // lblRamTotalData
            // 
            this.lblRamTotalData.AutoSize = true;
            this.lblRamTotalData.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamTotalData.ForeColor = System.Drawing.Color.White;
            this.lblRamTotalData.Location = new System.Drawing.Point(415, 405);
            this.lblRamTotalData.Name = "lblRamTotalData";
            this.lblRamTotalData.Size = new System.Drawing.Size(80, 17);
            this.lblRamTotalData.TabIndex = 54;
            this.lblRamTotalData.Text = "Calculating...";
            // 
            // lblCpuCores
            // 
            this.lblCpuCores.AutoSize = true;
            this.lblCpuCores.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuCores.ForeColor = System.Drawing.Color.White;
            this.lblCpuCores.Location = new System.Drawing.Point(144, 426);
            this.lblCpuCores.Name = "lblCpuCores";
            this.lblCpuCores.Size = new System.Drawing.Size(46, 17);
            this.lblCpuCores.TabIndex = 42;
            this.lblCpuCores.Text = "Cores:";
            // 
            // lblStorageUsed
            // 
            this.lblStorageUsed.AutoSize = true;
            this.lblStorageUsed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageUsed.ForeColor = System.Drawing.Color.White;
            this.lblStorageUsed.Location = new System.Drawing.Point(545, 426);
            this.lblStorageUsed.Name = "lblStorageUsed";
            this.lblStorageUsed.Size = new System.Drawing.Size(42, 17);
            this.lblStorageUsed.TabIndex = 41;
            this.lblStorageUsed.Text = "Used:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(544, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 40;
            this.label11.Text = "Used:";
            // 
            // lblRamUsed
            // 
            this.lblRamUsed.AutoSize = true;
            this.lblRamUsed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamUsed.ForeColor = System.Drawing.Color.White;
            this.lblRamUsed.Location = new System.Drawing.Point(344, 426);
            this.lblRamUsed.Name = "lblRamUsed";
            this.lblRamUsed.Size = new System.Drawing.Size(42, 17);
            this.lblRamUsed.TabIndex = 39;
            this.lblRamUsed.Text = "Used:";
            // 
            // lblCpuSpeed
            // 
            this.lblCpuSpeed.AutoSize = true;
            this.lblCpuSpeed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuSpeed.ForeColor = System.Drawing.Color.White;
            this.lblCpuSpeed.Location = new System.Drawing.Point(144, 405);
            this.lblCpuSpeed.Name = "lblCpuSpeed";
            this.lblCpuSpeed.Size = new System.Drawing.Size(95, 17);
            this.lblCpuSpeed.TabIndex = 38;
            this.lblCpuSpeed.Text = "CurrentSpeed:";
            // 
            // lblStorageTotal
            // 
            this.lblStorageTotal.AutoSize = true;
            this.lblStorageTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorageTotal.ForeColor = System.Drawing.Color.White;
            this.lblStorageTotal.Location = new System.Drawing.Point(545, 405);
            this.lblStorageTotal.Name = "lblStorageTotal";
            this.lblStorageTotal.Size = new System.Drawing.Size(43, 17);
            this.lblStorageTotal.TabIndex = 37;
            this.lblStorageTotal.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(544, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total:";
            // 
            // lblRamTotal
            // 
            this.lblRamTotal.AutoSize = true;
            this.lblRamTotal.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRamTotal.ForeColor = System.Drawing.Color.White;
            this.lblRamTotal.Location = new System.Drawing.Point(344, 405);
            this.lblRamTotal.Name = "lblRamTotal";
            this.lblRamTotal.Size = new System.Drawing.Size(43, 17);
            this.lblRamTotal.TabIndex = 35;
            this.lblRamTotal.Text = "Total:";
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("Nirmala UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorage.ForeColor = System.Drawing.Color.White;
            this.lblStorage.Location = new System.Drawing.Point(579, 362);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(96, 31);
            this.lblStorage.TabIndex = 34;
            this.lblStorage.Text = "Storage";
            this.lblStorage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Font = new System.Drawing.Font("Nirmala UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRAM.ForeColor = System.Drawing.Color.White;
            this.lblRAM.Location = new System.Drawing.Point(399, 362);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(67, 31);
            this.lblRAM.TabIndex = 33;
            this.lblRAM.Text = "RAM";
            this.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(245, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(365, 45);
            this.label22.TabIndex = 32;
            this.label22.Text = "SYSTEM DIAGNOSTICS";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Font = new System.Drawing.Font("Nirmala UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPU.ForeColor = System.Drawing.Color.White;
            this.lblCPU.Location = new System.Drawing.Point(195, 362);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(59, 31);
            this.lblCPU.TabIndex = 31;
            this.lblCPU.Text = "CPU";
            this.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.BackColor = System.Drawing.Color.Transparent;
            this.progressBarCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.progressBarCPU.FillColor = System.Drawing.Color.DimGray;
            this.progressBarCPU.FillThickness = 15;
            this.progressBarCPU.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarCPU.ForeColor = System.Drawing.Color.Silver;
            this.progressBarCPU.ImageSize = new System.Drawing.Size(95, 95);
            this.progressBarCPU.InnerColor = System.Drawing.Color.Transparent;
            this.progressBarCPU.Location = new System.Drawing.Point(161, 194);
            this.progressBarCPU.Minimum = 0;
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.ProgressColor = System.Drawing.Color.Red;
            this.progressBarCPU.ProgressColor2 = System.Drawing.Color.Blue;
            this.progressBarCPU.ProgressThickness = 15;
            this.progressBarCPU.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBarCPU.ShowText = true;
            this.progressBarCPU.Size = new System.Drawing.Size(135, 135);
            this.progressBarCPU.TabIndex = 173;
            this.progressBarCPU.UseTransparentBackground = true;
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.BackColor = System.Drawing.Color.Transparent;
            this.progressBarRAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.progressBarRAM.FillColor = System.Drawing.Color.DimGray;
            this.progressBarRAM.FillThickness = 15;
            this.progressBarRAM.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarRAM.ForeColor = System.Drawing.Color.Silver;
            this.progressBarRAM.ImageSize = new System.Drawing.Size(95, 95);
            this.progressBarRAM.InnerColor = System.Drawing.Color.Transparent;
            this.progressBarRAM.Location = new System.Drawing.Point(370, 194);
            this.progressBarRAM.Minimum = 0;
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.ProgressColor = System.Drawing.Color.Red;
            this.progressBarRAM.ProgressColor2 = System.Drawing.Color.Blue;
            this.progressBarRAM.ProgressThickness = 15;
            this.progressBarRAM.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBarRAM.ShowText = true;
            this.progressBarRAM.Size = new System.Drawing.Size(135, 135);
            this.progressBarRAM.TabIndex = 173;
            this.progressBarRAM.UseTransparentBackground = true;
            // 
            // progressBarStorage
            // 
            this.progressBarStorage.BackColor = System.Drawing.Color.Transparent;
            this.progressBarStorage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.progressBarStorage.FillColor = System.Drawing.Color.DimGray;
            this.progressBarStorage.FillThickness = 15;
            this.progressBarStorage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarStorage.ForeColor = System.Drawing.Color.Silver;
            this.progressBarStorage.ImageSize = new System.Drawing.Size(95, 95);
            this.progressBarStorage.InnerColor = System.Drawing.Color.Transparent;
            this.progressBarStorage.Location = new System.Drawing.Point(571, 194);
            this.progressBarStorage.Minimum = 0;
            this.progressBarStorage.Name = "progressBarStorage";
            this.progressBarStorage.ProgressColor = System.Drawing.Color.Red;
            this.progressBarStorage.ProgressColor2 = System.Drawing.Color.Blue;
            this.progressBarStorage.ProgressThickness = 15;
            this.progressBarStorage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBarStorage.ShowText = true;
            this.progressBarStorage.Size = new System.Drawing.Size(135, 135);
            this.progressBarStorage.TabIndex = 173;
            this.progressBarStorage.UseTransparentBackground = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCpuInfo
            // 
            this.btnCpuInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCpuInfo.Animated = true;
            this.btnCpuInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCpuInfo.BorderRadius = 15;
            this.btnCpuInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCpuInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCpuInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCpuInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCpuInfo.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnCpuInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCpuInfo.ForeColor = System.Drawing.Color.White;
            this.btnCpuInfo.Location = new System.Drawing.Point(125, 518);
            this.btnCpuInfo.Name = "btnCpuInfo";
            this.btnCpuInfo.Size = new System.Drawing.Size(96, 32);
            this.btnCpuInfo.TabIndex = 1005;
            this.btnCpuInfo.Text = "Cpu Info";
            this.btnCpuInfo.Click += new System.EventHandler(this.btnCpuInfo_Click);
            // 
            // btnGpuInfo
            // 
            this.btnGpuInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGpuInfo.Animated = true;
            this.btnGpuInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnGpuInfo.BorderRadius = 15;
            this.btnGpuInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGpuInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGpuInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGpuInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGpuInfo.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnGpuInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGpuInfo.ForeColor = System.Drawing.Color.White;
            this.btnGpuInfo.Location = new System.Drawing.Point(236, 518);
            this.btnGpuInfo.Name = "btnGpuInfo";
            this.btnGpuInfo.Size = new System.Drawing.Size(96, 32);
            this.btnGpuInfo.TabIndex = 1006;
            this.btnGpuInfo.Text = "Gpu Info";
            this.btnGpuInfo.Click += new System.EventHandler(this.btnGpuInfo_Click);
            // 
            // btnOSInfo
            // 
            this.btnOSInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOSInfo.Animated = true;
            this.btnOSInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnOSInfo.BorderRadius = 15;
            this.btnOSInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOSInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOSInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOSInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOSInfo.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnOSInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOSInfo.ForeColor = System.Drawing.Color.White;
            this.btnOSInfo.Location = new System.Drawing.Point(347, 518);
            this.btnOSInfo.Name = "btnOSInfo";
            this.btnOSInfo.Size = new System.Drawing.Size(96, 32);
            this.btnOSInfo.TabIndex = 1007;
            this.btnOSInfo.Text = "OS Info";
            this.btnOSInfo.Click += new System.EventHandler(this.btnOSInfo_Click);
            // 
            // btnNICinfo
            // 
            this.btnNICinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNICinfo.Animated = true;
            this.btnNICinfo.BackColor = System.Drawing.Color.Transparent;
            this.btnNICinfo.BorderRadius = 15;
            this.btnNICinfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNICinfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNICinfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNICinfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNICinfo.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnNICinfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNICinfo.ForeColor = System.Drawing.Color.White;
            this.btnNICinfo.Location = new System.Drawing.Point(460, 518);
            this.btnNICinfo.Name = "btnNICinfo";
            this.btnNICinfo.Size = new System.Drawing.Size(96, 32);
            this.btnNICinfo.TabIndex = 1008;
            this.btnNICinfo.Text = "Network Info";
            this.btnNICinfo.Click += new System.EventHandler(this.btnNICinfo_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(853, 574);
            this.Controls.Add(this.btnNICinfo);
            this.Controls.Add(this.btnOSInfo);
            this.Controls.Add(this.btnGpuInfo);
            this.Controls.Add(this.btnCpuInfo);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.progressBarStorage);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.lblCpuSpeedData);
            this.Controls.Add(this.lblCpuThreadsData);
            this.Controls.Add(this.lblStorageAvailableData);
            this.Controls.Add(this.lblRamAvailableData);
            this.Controls.Add(this.lblCpuCoresData);
            this.Controls.Add(this.lblStorageUsedData);
            this.Controls.Add(this.lblRamUsedData);
            this.Controls.Add(this.lblCpuThreads);
            this.Controls.Add(this.lblStorageAvailable);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblRamAvailable);
            this.Controls.Add(this.lblStorageTotalData);
            this.Controls.Add(this.lblRamTotalData);
            this.Controls.Add(this.lblCpuCores);
            this.Controls.Add(this.lblStorageUsed);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRamUsed);
            this.Controls.Add(this.lblCpuSpeed);
            this.Controls.Add(this.lblStorageTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblRamTotal);
            this.Controls.Add(this.lblStorage);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCpuSpeedData;
        private System.Windows.Forms.Label lblCpuThreadsData;
        private System.Windows.Forms.Label lblStorageAvailableData;
        private System.Windows.Forms.Label lblRamAvailableData;
        private System.Windows.Forms.Label lblCpuCoresData;
        private System.Windows.Forms.Label lblStorageUsedData;
        private System.Windows.Forms.Label lblRamUsedData;
        private System.Windows.Forms.Label lblCpuThreads;
        private System.Windows.Forms.Label lblStorageAvailable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRamAvailable;
        private System.Windows.Forms.Label lblStorageTotalData;
        private System.Windows.Forms.Label lblRamTotalData;
        private System.Windows.Forms.Label lblCpuCores;
        private System.Windows.Forms.Label lblStorageUsed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRamUsed;
        private System.Windows.Forms.Label lblCpuSpeed;
        private System.Windows.Forms.Label lblStorageTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRamTotal;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblCPU;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBarCPU;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBarRAM;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBarStorage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Button btnCpuInfo;
        private Guna.UI2.WinForms.Guna2Button btnGpuInfo;
        private Guna.UI2.WinForms.Guna2Button btnOSInfo;
        private Guna.UI2.WinForms.Guna2Button btnNICinfo;
    }
}