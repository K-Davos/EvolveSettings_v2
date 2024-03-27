namespace EvolveSettings.Forms
{
    partial class CpuInformationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.lblProcTypeData = new System.Windows.Forms.Label();
            this.lblThermals = new System.Windows.Forms.Label();
            this.lblProcType = new System.Windows.Forms.Label();
            this.lblNrOfLogicalProcData = new System.Windows.Forms.Label();
            this.lblNrOfLogicalProc = new System.Windows.Forms.Label();
            this.lblClockSpeedData = new System.Windows.Forms.Label();
            this.lblClockSpeed = new System.Windows.Forms.Label();
            this.lblAddressWidthData = new System.Windows.Forms.Label();
            this.lblArchitectureData = new System.Windows.Forms.Label();
            this.lblAddressWidth = new System.Windows.Forms.Label();
            this.lblArchitecture = new System.Windows.Forms.Label();
            this.lblNrOfCoresData = new System.Windows.Forms.Label();
            this.lblNrOfCores = new System.Windows.Forms.Label();
            this.lblCharacteristicsData = new System.Windows.Forms.Label();
            this.lblVirtualizationFwData = new System.Windows.Forms.Label();
            this.lblCharacteristics = new System.Windows.Forms.Label();
            this.lblVirtualizationFw = new System.Windows.Forms.Label();
            this.lblCaptionsData = new System.Windows.Forms.Label();
            this.lblManufacturerData = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblCaptions = new System.Windows.Forms.Label();
            this.lblDeviceIDData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTextFiletxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThermals = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThermals)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Cores";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Temperature";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(622, 179);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 21);
            this.label25.TabIndex = 25;
            this.label25.Visible = false;
            // 
            // lblProcTypeData
            // 
            this.lblProcTypeData.AutoSize = true;
            this.lblProcTypeData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcTypeData.ForeColor = System.Drawing.Color.White;
            this.lblProcTypeData.Location = new System.Drawing.Point(265, 407);
            this.lblProcTypeData.Name = "lblProcTypeData";
            this.lblProcTypeData.Size = new System.Drawing.Size(16, 15);
            this.lblProcTypeData.TabIndex = 47;
            this.lblProcTypeData.Text = "...";
            // 
            // lblThermals
            // 
            this.lblThermals.AutoSize = true;
            this.lblThermals.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThermals.ForeColor = System.Drawing.Color.White;
            this.lblThermals.Location = new System.Drawing.Point(535, 179);
            this.lblThermals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThermals.Name = "lblThermals";
            this.lblThermals.Size = new System.Drawing.Size(92, 21);
            this.lblThermals.TabIndex = 23;
            this.lblThermals.Text = "THERMALS";
            this.lblThermals.Visible = false;
            // 
            // lblProcType
            // 
            this.lblProcType.AutoSize = true;
            this.lblProcType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcType.ForeColor = System.Drawing.Color.White;
            this.lblProcType.Location = new System.Drawing.Point(71, 407);
            this.lblProcType.Name = "lblProcType";
            this.lblProcType.Size = new System.Drawing.Size(85, 15);
            this.lblProcType.TabIndex = 46;
            this.lblProcType.Text = "ProcessorType:";
            // 
            // lblNrOfLogicalProcData
            // 
            this.lblNrOfLogicalProcData.AutoSize = true;
            this.lblNrOfLogicalProcData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfLogicalProcData.ForeColor = System.Drawing.Color.White;
            this.lblNrOfLogicalProcData.Location = new System.Drawing.Point(265, 324);
            this.lblNrOfLogicalProcData.Name = "lblNrOfLogicalProcData";
            this.lblNrOfLogicalProcData.Size = new System.Drawing.Size(16, 15);
            this.lblNrOfLogicalProcData.TabIndex = 45;
            this.lblNrOfLogicalProcData.Text = "...";
            // 
            // lblNrOfLogicalProc
            // 
            this.lblNrOfLogicalProc.AutoSize = true;
            this.lblNrOfLogicalProc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfLogicalProc.ForeColor = System.Drawing.Color.White;
            this.lblNrOfLogicalProc.Location = new System.Drawing.Point(71, 324);
            this.lblNrOfLogicalProc.Name = "lblNrOfLogicalProc";
            this.lblNrOfLogicalProc.Size = new System.Drawing.Size(161, 15);
            this.lblNrOfLogicalProc.TabIndex = 44;
            this.lblNrOfLogicalProc.Text = "NumberOfLogicalProcessors:";
            // 
            // lblClockSpeedData
            // 
            this.lblClockSpeedData.AutoSize = true;
            this.lblClockSpeedData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockSpeedData.ForeColor = System.Drawing.Color.White;
            this.lblClockSpeedData.Location = new System.Drawing.Point(265, 241);
            this.lblClockSpeedData.Name = "lblClockSpeedData";
            this.lblClockSpeedData.Size = new System.Drawing.Size(16, 15);
            this.lblClockSpeedData.TabIndex = 43;
            this.lblClockSpeedData.Text = "...";
            // 
            // lblClockSpeed
            // 
            this.lblClockSpeed.AutoSize = true;
            this.lblClockSpeed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockSpeed.ForeColor = System.Drawing.Color.White;
            this.lblClockSpeed.Location = new System.Drawing.Point(71, 241);
            this.lblClockSpeed.Name = "lblClockSpeed";
            this.lblClockSpeed.Size = new System.Drawing.Size(112, 15);
            this.lblClockSpeed.TabIndex = 42;
            this.lblClockSpeed.Text = "CurrentClockSpeed:";
            // 
            // lblAddressWidthData
            // 
            this.lblAddressWidthData.AutoSize = true;
            this.lblAddressWidthData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressWidthData.ForeColor = System.Drawing.Color.White;
            this.lblAddressWidthData.Location = new System.Drawing.Point(265, 462);
            this.lblAddressWidthData.Name = "lblAddressWidthData";
            this.lblAddressWidthData.Size = new System.Drawing.Size(16, 15);
            this.lblAddressWidthData.TabIndex = 41;
            this.lblAddressWidthData.Text = "...";
            // 
            // lblArchitectureData
            // 
            this.lblArchitectureData.AutoSize = true;
            this.lblArchitectureData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchitectureData.ForeColor = System.Drawing.Color.White;
            this.lblArchitectureData.Location = new System.Drawing.Point(265, 379);
            this.lblArchitectureData.Name = "lblArchitectureData";
            this.lblArchitectureData.Size = new System.Drawing.Size(16, 15);
            this.lblArchitectureData.TabIndex = 40;
            this.lblArchitectureData.Text = "...";
            // 
            // lblAddressWidth
            // 
            this.lblAddressWidth.AutoSize = true;
            this.lblAddressWidth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressWidth.ForeColor = System.Drawing.Color.White;
            this.lblAddressWidth.Location = new System.Drawing.Point(72, 462);
            this.lblAddressWidth.Name = "lblAddressWidth";
            this.lblAddressWidth.Size = new System.Drawing.Size(84, 15);
            this.lblAddressWidth.TabIndex = 39;
            this.lblAddressWidth.Text = "AddressWidth:";
            // 
            // lblArchitecture
            // 
            this.lblArchitecture.AutoSize = true;
            this.lblArchitecture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchitecture.ForeColor = System.Drawing.Color.White;
            this.lblArchitecture.Location = new System.Drawing.Point(71, 379);
            this.lblArchitecture.Name = "lblArchitecture";
            this.lblArchitecture.Size = new System.Drawing.Size(75, 15);
            this.lblArchitecture.TabIndex = 38;
            this.lblArchitecture.Text = "Architecture:";
            // 
            // lblNrOfCoresData
            // 
            this.lblNrOfCoresData.AutoSize = true;
            this.lblNrOfCoresData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfCoresData.ForeColor = System.Drawing.Color.White;
            this.lblNrOfCoresData.Location = new System.Drawing.Point(265, 296);
            this.lblNrOfCoresData.Name = "lblNrOfCoresData";
            this.lblNrOfCoresData.Size = new System.Drawing.Size(16, 15);
            this.lblNrOfCoresData.TabIndex = 48;
            this.lblNrOfCoresData.Text = "...";
            // 
            // lblNrOfCores
            // 
            this.lblNrOfCores.AutoSize = true;
            this.lblNrOfCores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfCores.ForeColor = System.Drawing.Color.White;
            this.lblNrOfCores.Location = new System.Drawing.Point(71, 296);
            this.lblNrOfCores.Name = "lblNrOfCores";
            this.lblNrOfCores.Size = new System.Drawing.Size(97, 15);
            this.lblNrOfCores.TabIndex = 37;
            this.lblNrOfCores.Text = "NumberOfCores:";
            // 
            // lblCharacteristicsData
            // 
            this.lblCharacteristicsData.AutoSize = true;
            this.lblCharacteristicsData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacteristicsData.ForeColor = System.Drawing.Color.White;
            this.lblCharacteristicsData.Location = new System.Drawing.Point(265, 434);
            this.lblCharacteristicsData.Name = "lblCharacteristicsData";
            this.lblCharacteristicsData.Size = new System.Drawing.Size(16, 15);
            this.lblCharacteristicsData.TabIndex = 36;
            this.lblCharacteristicsData.Text = "...";
            // 
            // lblVirtualizationFwData
            // 
            this.lblVirtualizationFwData.AutoSize = true;
            this.lblVirtualizationFwData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirtualizationFwData.ForeColor = System.Drawing.Color.White;
            this.lblVirtualizationFwData.Location = new System.Drawing.Point(265, 351);
            this.lblVirtualizationFwData.Name = "lblVirtualizationFwData";
            this.lblVirtualizationFwData.Size = new System.Drawing.Size(16, 15);
            this.lblVirtualizationFwData.TabIndex = 35;
            this.lblVirtualizationFwData.Text = "...";
            // 
            // lblCharacteristics
            // 
            this.lblCharacteristics.AutoSize = true;
            this.lblCharacteristics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacteristics.ForeColor = System.Drawing.Color.White;
            this.lblCharacteristics.Location = new System.Drawing.Point(71, 434);
            this.lblCharacteristics.Name = "lblCharacteristics";
            this.lblCharacteristics.Size = new System.Drawing.Size(87, 15);
            this.lblCharacteristics.TabIndex = 34;
            this.lblCharacteristics.Text = "Characteristics:";
            // 
            // lblVirtualizationFw
            // 
            this.lblVirtualizationFw.AutoSize = true;
            this.lblVirtualizationFw.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirtualizationFw.ForeColor = System.Drawing.Color.White;
            this.lblVirtualizationFw.Location = new System.Drawing.Point(71, 351);
            this.lblVirtualizationFw.Name = "lblVirtualizationFw";
            this.lblVirtualizationFw.Size = new System.Drawing.Size(170, 15);
            this.lblVirtualizationFw.TabIndex = 33;
            this.lblVirtualizationFw.Text = "VirtualizationFirmwareEnabled:";
            // 
            // lblCaptionsData
            // 
            this.lblCaptionsData.AutoSize = true;
            this.lblCaptionsData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionsData.ForeColor = System.Drawing.Color.White;
            this.lblCaptionsData.Location = new System.Drawing.Point(265, 268);
            this.lblCaptionsData.Name = "lblCaptionsData";
            this.lblCaptionsData.Size = new System.Drawing.Size(16, 15);
            this.lblCaptionsData.TabIndex = 32;
            this.lblCaptionsData.Text = "...";
            // 
            // lblManufacturerData
            // 
            this.lblManufacturerData.AutoSize = true;
            this.lblManufacturerData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturerData.ForeColor = System.Drawing.Color.White;
            this.lblManufacturerData.Location = new System.Drawing.Point(265, 213);
            this.lblManufacturerData.Name = "lblManufacturerData";
            this.lblManufacturerData.Size = new System.Drawing.Size(16, 15);
            this.lblManufacturerData.TabIndex = 31;
            this.lblManufacturerData.Text = "...";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManufacturer.ForeColor = System.Drawing.Color.White;
            this.lblManufacturer.Location = new System.Drawing.Point(71, 213);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(82, 15);
            this.lblManufacturer.TabIndex = 30;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblCaptions
            // 
            this.lblCaptions.AutoSize = true;
            this.lblCaptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptions.ForeColor = System.Drawing.Color.White;
            this.lblCaptions.Location = new System.Drawing.Point(71, 268);
            this.lblCaptions.Name = "lblCaptions";
            this.lblCaptions.Size = new System.Drawing.Size(52, 15);
            this.lblCaptions.TabIndex = 29;
            this.lblCaptions.Text = "Caption:";
            // 
            // lblDeviceIDData
            // 
            this.lblDeviceIDData.AutoSize = true;
            this.lblDeviceIDData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceIDData.ForeColor = System.Drawing.Color.White;
            this.lblDeviceIDData.Location = new System.Drawing.Point(265, 185);
            this.lblDeviceIDData.Name = "lblDeviceIDData";
            this.lblDeviceIDData.Size = new System.Drawing.Size(16, 15);
            this.lblDeviceIDData.TabIndex = 28;
            this.lblDeviceIDData.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveDataToCSVToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.saveDataToCSVToolStripMenuItem.Text = "Save Data to CSV";
            this.saveDataToCSVToolStripMenuItem.Click += new System.EventHandler(this.saveDataToCSVToolStripMenuItem_Click);
            // 
            // saveToTextFiletxtToolStripMenuItem
            // 
            this.saveToTextFiletxtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToTextFiletxtToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToTextFiletxtToolStripMenuItem.Name = "saveToTextFiletxtToolStripMenuItem";
            this.saveToTextFiletxtToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.saveToTextFiletxtToolStripMenuItem.Text = "Save Data to TXT";
            this.saveToTextFiletxtToolStripMenuItem.Click += new System.EventHandler(this.saveToTextFiletxtToolStripMenuItem_Click);
            // 
            // copyInformationToolStripMenuItem
            // 
            this.copyInformationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copyInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyInformationToolStripMenuItem.Name = "copyInformationToolStripMenuItem";
            this.copyInformationToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.copyInformationToolStripMenuItem.Text = "Copy Information";
            this.copyInformationToolStripMenuItem.Click += new System.EventHandler(this.copyInformationToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyInformationToolStripMenuItem,
            this.saveToTextFiletxtToolStripMenuItem,
            this.saveDataToCSVToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(52, 23);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceID.ForeColor = System.Drawing.Color.White;
            this.lblDeviceID.Location = new System.Drawing.Point(71, 185);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(59, 15);
            this.lblDeviceID.TabIndex = 27;
            this.lblDeviceID.Text = "Device ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(728, 98);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(59, 27);
            this.menuStrip1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Getting Values...";
            // 
            // dataGridViewThermals
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewThermals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThermals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewThermals.ColumnHeadersHeight = 50;
            this.dataGridViewThermals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewThermals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cores,
            this.Temperature});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewThermals.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewThermals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewThermals.Location = new System.Drawing.Point(539, 213);
            this.dataGridViewThermals.Name = "dataGridViewThermals";
            this.dataGridViewThermals.RowHeadersVisible = false;
            this.dataGridViewThermals.RowHeadersWidth = 50;
            this.dataGridViewThermals.Size = new System.Drawing.Size(248, 264);
            this.dataGridViewThermals.TabIndex = 49;
            this.dataGridViewThermals.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewThermals.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewThermals.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewThermals.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewThermals.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewThermals.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewThermals.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewThermals.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewThermals.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewThermals.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewThermals.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewThermals.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridViewThermals.ThemeStyle.HeaderStyle.Height = 50;
            this.dataGridViewThermals.ThemeStyle.ReadOnly = false;
            this.dataGridViewThermals.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewThermals.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewThermals.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewThermals.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewThermals.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewThermals.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewThermals.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewThermals.Visible = false;
            this.dataGridViewThermals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewThermals_CellContentClick);
            // 
            // Cores
            // 
            this.Cores.FillWeight = 80.38084F;
            this.Cores.HeaderText = "Cores";
            this.Cores.MinimumWidth = 6;
            this.Cores.Name = "Cores";
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.MinimumWidth = 6;
            this.Temperature.Name = "Temperature";
            // 
            // CpuInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(853, 574);
            this.Controls.Add(this.dataGridViewThermals);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblProcTypeData);
            this.Controls.Add(this.lblThermals);
            this.Controls.Add(this.lblProcType);
            this.Controls.Add(this.lblNrOfLogicalProcData);
            this.Controls.Add(this.lblNrOfLogicalProc);
            this.Controls.Add(this.lblClockSpeedData);
            this.Controls.Add(this.lblClockSpeed);
            this.Controls.Add(this.lblAddressWidthData);
            this.Controls.Add(this.lblArchitectureData);
            this.Controls.Add(this.lblAddressWidth);
            this.Controls.Add(this.lblArchitecture);
            this.Controls.Add(this.lblNrOfCoresData);
            this.Controls.Add(this.lblNrOfCores);
            this.Controls.Add(this.lblCharacteristicsData);
            this.Controls.Add(this.lblVirtualizationFwData);
            this.Controls.Add(this.lblCharacteristics);
            this.Controls.Add(this.lblVirtualizationFw);
            this.Controls.Add(this.lblCaptionsData);
            this.Controls.Add(this.lblManufacturerData);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblCaptions);
            this.Controls.Add(this.lblDeviceIDData);
            this.Controls.Add(this.lblDeviceID);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CpuInformationForm";
            this.Text = "CpuInformationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CpuInformationForm_FormClosing);
            this.Load += new System.EventHandler(this.CpuInformationForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThermals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblProcTypeData;
        private System.Windows.Forms.Label lblThermals;
        private System.Windows.Forms.Label lblProcType;
        private System.Windows.Forms.Label lblNrOfLogicalProcData;
        private System.Windows.Forms.Label lblNrOfLogicalProc;
        private System.Windows.Forms.Label lblClockSpeedData;
        private System.Windows.Forms.Label lblClockSpeed;
        private System.Windows.Forms.Label lblAddressWidthData;
        private System.Windows.Forms.Label lblArchitectureData;
        private System.Windows.Forms.Label lblAddressWidth;
        private System.Windows.Forms.Label lblArchitecture;
        private System.Windows.Forms.Label lblNrOfCoresData;
        private System.Windows.Forms.Label lblNrOfCores;
        private System.Windows.Forms.Label lblCharacteristicsData;
        private System.Windows.Forms.Label lblVirtualizationFwData;
        private System.Windows.Forms.Label lblCharacteristics;
        private System.Windows.Forms.Label lblVirtualizationFw;
        private System.Windows.Forms.Label lblCaptionsData;
        private System.Windows.Forms.Label lblManufacturerData;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblCaptions;
        private System.Windows.Forms.Label lblDeviceIDData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTextFiletxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewThermals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
    }
}