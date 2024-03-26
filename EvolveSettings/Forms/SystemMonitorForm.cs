using EvolveSettings.Controls;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static EvolveSettings.EffectBlur;

namespace EvolveSettings.Forms
{
    public partial class SystemMonitorForm : Form
    {
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        PerformanceCounter ramCounter;
        PerformanceCounter driveCounter;
        PerformanceCounter driveCounter2;
        PerformanceCounter performanceSystem;

        private System.Timers.Timer _timer;

        //Network monitor
        private const double timerUpdate = 1000;
        private NetworkInterface[] nicArr;
        public static Timer timer;

        int num_cores;
        int num_logical_processors;

        private bool ExitWasClicked = false;
        public static bool ShowUserLogOutMsgBox { get; set; }

        public SystemMonitorForm()
        {
            InitializeComponent();
            Load += frmSystemMonitor_Load;

            //WinTheme
            LoadTheme();
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);

            _timer = new System.Timers.Timer();
            _timer.Interval = 1200;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;
            if (toggleSysMonitor.Checked == true)
            {
                _timer.Enabled = true;
                InitializeTimer();
            }
            EnableBlur();
            GetProcessorCounts(out num_cores, out num_logical_processors);
            LoadOptions();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Acryl/Blur
        private uint _blurOpacity;

        public double BlurOpacity
        {
            get { return _blurOpacity; }
            set { _blurOpacity = (uint)value; EnableBlur(); }
        }

        private uint _blurBackgroundColor = 0x990000;

        internal void EnableBlur()
        {
            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_ACRYLICBLURBEHIND;
            accent.GradientColor = (_blurOpacity << 24) | (_blurBackgroundColor & 0xFFFFFF);
            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;
            SetWindowCompositionAttribute(this.Handle, ref data);
            Marshal.FreeHGlobal(accentPtr);
        }

        //WinTheme
        public bool IsDarkTheme()
        {
            bool is_light_mode = true;
            try
            {
                var v = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", "1");
                if (v != null && v.ToString() == "0")
                    is_light_mode = false;
            }
            catch { }
            return is_light_mode;
        }
        private void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            var isDarkorLight = IsDarkTheme();
            if (isDarkorLight)
            {
                //light
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlSysMonitor.FillColor = Color.White;
                pnlPwrSaving.FillColor = Color.White;
                pnlGameMode.FillColor = Color.White;
                evolvePanel.BackColor = Color.White;
                /*foreach (Guna2TextBox txtbox in this.panel9.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }*/
                foreach (Label label in this.pnlSysMonitor.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Label label in this.pnlPwrSaving.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Label label in this.pnlGameMode.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Label label in this.evolvePanel.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Guna2ProgressBar circleProgressBar in this.evolvePanel.Controls.OfType<Guna2ProgressBar>())
                {
                    circleProgressBar.BackColor = Color.White;
                    circleProgressBar.ProgressColor = themeColor;
                    circleProgressBar.ProgressColor2 = Color.Red;
                }
                foreach (Guna2CircleProgressBar circleProgressBar in this.evolvePanel.Controls.OfType<Guna2CircleProgressBar>())
                {
                    circleProgressBar.BackColor = Color.White;
                    circleProgressBar.ProgressColor = themeColor;
                    circleProgressBar.ProgressColor2 = Color.Red;
                }
                label7.ForeColor = Color.Black;
                label18.ForeColor = Color.Black;
                label19.ForeColor = Color.Black;
                label29.ForeColor = Color.Black;
                label32.ForeColor = Color.Black;
                label34.ForeColor = Color.Black;
                cmbInterface.BackColor = Color.White;
                cmbInterface.ForeColor = Color.Black;
                cmbInterface.BorderColor = themeColor;
                btnClearCache.FillColor = themeColor;
                btnClearDNS.FillColor = themeColor;
            }
            else
            {
                //dark
                this.BackColor = Color.Black;
                pnlSysMonitor.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPwrSaving.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlGameMode.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                evolvePanel.BackColor = Color.Black;
                btnClose.ForeColor = Color.White;
                lblSysMonitor.ForeColor = Color.White;
                //evolvePanel1.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                /*foreach (Guna2TextBox txtbox in this.panel9.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }*/
                foreach (Label label in this.pnlSysMonitor.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Label label in this.pnlPwrSaving.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Label label in this.pnlGameMode.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Label label in this.evolvePanel.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Guna2ProgressBar circleProgressBar in this.evolvePanel.Controls.OfType<Guna2ProgressBar>())
                {
                    circleProgressBar.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                    circleProgressBar.ProgressColor = themeColor;
                    circleProgressBar.ProgressColor2 = Color.Red;
                }
                foreach (Guna2CircleProgressBar circleProgressBar in this.evolvePanel.Controls.OfType<Guna2CircleProgressBar>())
                {
                    circleProgressBar.BackColor = Color.Black;
                    circleProgressBar.ProgressColor = themeColor;
                    circleProgressBar.ProgressColor2 = Color.Red;
                }
                label7.ForeColor = Color.White;
                label18.ForeColor = Color.White;
                label19.ForeColor = Color.White;
                label29.ForeColor = Color.White;
                label32.ForeColor = Color.White;
                label34.ForeColor = Color.White;
                cmbInterface.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                cmbInterface.ForeColor = Color.White;
                cmbInterface.BorderColor = themeColor;
                btnClearCache.FillColor = themeColor;
                btnClearDNS.FillColor = themeColor;
            }

            //Buttons
            foreach (EvolveToggleButton button in this.pnlSysMonitor.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = this.BackColor;
            }

            foreach (EvolveToggleButton button in this.pnlPwrSaving.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = this.BackColor;
            }

            foreach (EvolveToggleButton button in this.pnlGameMode.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = this.BackColor;
            }

            foreach (Guna2Button button in this.pnlSysMonitor.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.evolvePanel.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                LoadTheme();
            }
        }

        private void Form_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
            OptionsHelper.SaveSettings();
        }

        private void LoadOptions()
        {
            //toggleSettingsHomePage.CheckedChanged += new EventHandler(ToggleSettingsHomePage_CheckedChanged); //EventHandeler Method

            //Load saved settings
            toggleSysMonitor.Checked = OptionsHelper.CurrentOptions.SystemMonitor;
            togglePowerSavingsMode.Checked = OptionsHelper.CurrentOptions.PowerSavingsMode;
            toggleGameMode.Checked = OptionsHelper.CurrentOptions.GameMode;
        }

        private void frmSystemMonitor_Load(object sender, EventArgs e)
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            driveCounter = new PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", "_Total");
            driveCounter2 = new PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", "_Total");
            performanceSystem = new PerformanceCounter("System", "System Up Time");

            if (toggleSysMonitor.Checked == true)
            {
                lbl_Download.Visible = true;
                lbl_Upload.Visible = true;
                lbl_InterfaceType.Visible = true;
                lbl_Speed.Visible = true;
                lbl_BytesSent.Visible = true;
                lbl_BytesReceived.Visible = true;
                lbl_IPAddress.Visible = true;
                lbl_DriveReadWrite.Visible = true;
                lbl_FreeDriveSpace.Visible = true;
                lblCurrentDate.Visible = true;
                lblGetSysUpTime.Visible = true;
                lblCores.Visible = true;
                lblLogicalCpuCores.Visible = true;
                lblMemUsage.Visible = true;
                lblFreeMemUsage.Visible = true;
                lblHandleCountValue.Visible = true;
                lblProcessCountValue.Visible = true;
                lblThreadCountValue.Visible = true;
            }
            else
            {
                lbl_Download.Visible = false;
                lbl_Upload.Visible = false;
                lbl_InterfaceType.Visible = false;
                lbl_Speed.Visible = false;
                lbl_BytesSent.Visible = false;
                lbl_BytesReceived.Visible = false;
                lbl_IPAddress.Visible = false;
                lbl_DriveReadWrite.Visible = false;
                lbl_FreeDriveSpace.Visible = false;
                lblCurrentDate.Visible = false;
                lblGetSysUpTime.Visible = false;
                lblCores.Visible = false;
                lblLogicalCpuCores.Visible = false;
                lblMemUsage.Visible = false;
                lblFreeMemUsage.Visible = false;
                lblHandleCountValue.Visible = false;
                lblProcessCountValue.Visible = false;
                lblThreadCountValue.Visible = false;
            }
        }

        private void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            //Monitor and get the values of the cpu and memory
            int cpuValue = GetCpuValue();
            int cpuOSUsage = GetCpuOSValue();
            int cpuUserUsage = GetCpuUserValue();
            int threadCountValue = GetThreadCountValue();
            int handleCountValue = GetHandleCountValue();
            int memValue = GetMemValue();

            int freeDiskSpaceValue = GetFreeDiskSpaceValue();
            int freeDiskSpaceCTotal = GetFreeDiskSpaceCTotal();
            int freeSpaceDiskCValue = GetFreeSpaceDiskCValue();
            GetProcessesValue();

            if (progressBarCPU.InvokeRequired)
            {
                progressBarCPU.Invoke(new Action(() => progressBarCPU.Value = cpuValue));
            }
            else
            {
                progressBarCPU.Value = cpuValue;
            }
            if (progressBarMem.InvokeRequired)
            {
                progressBarMem.Invoke(new Action(() => progressBarMem.Value = memValue));
            }
            else
            {
                progressBarMem.Value = memValue;
            }
            if (lblMemUsage.InvokeRequired)
            {
                lblMemUsage.Invoke(new Action(() => lblMemUsage.Text = memValue.ToString() + " %"));
            }
            else
            {
                lblMemUsage.Text = memValue.ToString() + " %";
            }
            if (progressBarOSUsage.InvokeRequired)
            {
                progressBarOSUsage.Invoke(new Action(() => progressBarOSUsage.Value = cpuOSUsage));
            }
            else
            {
                progressBarOSUsage.Value = cpuOSUsage;
            }
            if (progressBarUserUsage.InvokeRequired)
            {
                progressBarUserUsage.Invoke(new Action(() => progressBarUserUsage.Value = cpuUserUsage));
            }
            else
            {
                progressBarUserUsage.Value = cpuUserUsage;
            }
            if (this.lblThreadCountValue.InvokeRequired)
            {
                this.lblThreadCountValue.Invoke(new Action(() => this.lblThreadCountValue.Text = threadCountValue.ToString()));
            }
            else
            {
                this.lblThreadCountValue.Text = threadCountValue.ToString();
            }
            if (this.lblHandleCountValue.InvokeRequired)
            {
                this.lblHandleCountValue.Invoke(new Action(() => this.lblHandleCountValue.Text = handleCountValue.ToString()));
            }
            else
            {
                this.lblHandleCountValue.Text = handleCountValue.ToString();
            }
            if (progressFreeDiskSpace.InvokeRequired)
            {
                progressFreeDiskSpace.Invoke(new Action(() => progressFreeDiskSpace.Value = freeDiskSpaceValue));
            }
            else
            {
                progressFreeDiskSpace.Value = freeDiskSpaceValue;
            }
            if (progressFreeDiskSpaceC.InvokeRequired)
            {
                progressFreeDiskSpaceC.Invoke(new Action(() => progressFreeDiskSpaceC.Value = freeSpaceDiskCValue));
            }
            else
            {
                progressFreeDiskSpaceC.Value = freeSpaceDiskCValue;
            }
        }

        private int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(200);
            int returnvalue = (int)CpuCounter.NextValue();
            return returnvalue;
        }
        private int GetCpuOSValue()
        {
            var CpuOSCounter = new PerformanceCounter("Processor", "% Privileged time", "_Total");
            CpuOSCounter.NextValue();
            System.Threading.Thread.Sleep(200);
            int returnvalue = (int)CpuOSCounter.NextValue();
            return returnvalue;
        }
        private int GetCpuUserValue()
        {
            var CpuUserCounter = new PerformanceCounter("Processor", "% User Time", "_Total");
            CpuUserCounter.NextValue();
            System.Threading.Thread.Sleep(200);
            int returnvalue = (int)CpuUserCounter.NextValue();
            return returnvalue;
        }
        private int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Memory", "% Committed Bytes in use");
            int returnvalue = (int)MemCounter.NextValue() - 10;
            return returnvalue;
        }
        private int GetThreadCountValue()
        {
            var ThreadsCounter = new PerformanceCounter("Process", "Thread Count", "_Total");
            System.Threading.Thread.Sleep(200);
            int returnvalue = (int)ThreadsCounter.NextValue();
            return returnvalue;
        }
        private int GetHandleCountValue()
        {
            var HandleCounter = new PerformanceCounter("Process", "Handle Count", "_Total");
            System.Threading.Thread.Sleep(200);
            int returnvalue = (int)HandleCounter.NextValue();
            return returnvalue;
        }
        private int GetFreeDiskSpaceValue()
        {
            var FreeDiskSpaceCounter = new PerformanceCounter("LogicalDisk", "% Free Space", "_Total");
            System.Threading.Thread.Sleep(200);
            int returnvalue = (int)FreeDiskSpaceCounter.NextValue();
            return returnvalue;
        }
        private int GetFreeSpaceDiskCValue()
        {
            var FreeDiskSpaceCCounter = new PerformanceCounter("LogicalDisk", "% Free Space", "C:");
            int returnvalue = (int)FreeDiskSpaceCCounter.NextValue();
            return returnvalue;
        }
        private int GetFreeDiskSpaceCTotal()
        {
            var FreeDiskSpaceTotal = new PerformanceCounter("LogicalDisk", "% Free Space", "C:");
            int returnvalue = (int)FreeDiskSpaceTotal.NextValue() * 447 / 100;
            return returnvalue;
        }

        private void GetProcessesValue()
        {
            Process[] processlist = Process.GetProcesses();
            int size = processlist.Length; lblProcessCountValue.Text = size.ToString();
        }

        private void GetProcessorCounts(out int num_cores, out int num_logical_processors)
        {
            string query;
            ManagementObjectSearcher searcher;

            // Get the number of physical processors.
            query = "SELECT * FROM Win32_ComputerSystem";
            searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject sys in searcher.Get())

                // Get the number of cores.
                query = "SELECT * FROM Win32_Processor";
            num_cores = 0;
            searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject proc in searcher.Get())
                num_cores += int.Parse(proc["NumberOfCores"].ToString());

            num_logical_processors = Environment.ProcessorCount;

            lblCores.Text = num_cores.ToString();
            lblLogicalCpuCores.Text = num_logical_processors.ToString();
        }

        //Network monitor
        // Initialize all network interfaces on the computer
        private void InitializeNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            List<string> goodAdapters = new List<string>();

            foreach (NetworkInterface nicnac in nicArr)
            {
                if (nicnac.SupportsMulticast && nicnac.GetIPv4Statistics().UnicastPacketsReceived >= 1 && nicnac.OperationalStatus.ToString() == "Up")
                {
                    goodAdapters.Add(nicnac.Name);
                    //cmbInterface.Items.Add(nicnac.Name);
                }

            }
            if (goodAdapters.Count != cmbInterface.Items.Count && goodAdapters.Count != 0)
            {
                cmbInterface.Items.Clear();
                foreach (string gadpt in goodAdapters)
                {
                    cmbInterface.Items.Add(gadpt);
                }
                cmbInterface.SelectedIndex = 0;
            }
            if (goodAdapters.Count == 0) cmbInterface.Items.Clear();
        }

        // Initialize the Timer
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            System.Threading.Thread.Sleep(500);
            timer.Start();
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            lblGetSysUpTime.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortDateString();
            lblGetSysUpTime.Text = (int)performanceSystem.NextValue() / 60 + " minutes";
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();

            //Updates all available ram
            ManagementObjectSearcher ramAll = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in ramAll.Get())
            {
                lblFreeMemUsage.Text = "Free: " + Math.Round(ramCounter.NextValue() / 1024) + "GB/" + Math.Round(double.Parse(obj["TotalVisibleMemorySize"].ToString()) / 1048576, 2, MidpointRounding.ToEven) + "GB";
            }

            //Gets C:\ drive info
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in allDrives)
            {
                lbl_FreeDriveSpace.Text = "Free space: " + drive.TotalFreeSpace / 1073741824 + "GB / " + drive.TotalSize / 1073741824 + "GB";
                float driveFull = drive.TotalSize / 1073741824;
                float driveUsed = driveFull - drive.TotalFreeSpace / 1073741824;
                break;
            }

            //Gets read and write speed of drive
            double write = driveCounter2.NextValue();
            double read = driveCounter.NextValue();
            lbl_DriveReadWrite.Text = "Read/Write: " + Math.Round(read / 1024, 2) + "kB/s / " + Math.Round(write / 1024, 2) + "kB/s";

            InitializeNetworkInterface();
            UpdateNetworkInterface();
        }

        // Update GUI components for the network interfaces
        private void UpdateNetworkInterface()
        {
            //MessageBox.Show(cmbInterface.Items.Count.ToString());
            if (cmbInterface.Items.Count >= 1)
            {
                // Grab NetworkInterface object that describes the current interface
                NetworkInterface nic = nicArr[cmbInterface.SelectedIndex];

                // Grab the stats for that interface
                IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

                var bytesSentSpeed = (long)(interfaceStats.BytesSent
                                            - double.Parse(lbl_BytesSent.Text)) / 1024;
                var bytesReceivedSpeed = (long)(interfaceStats.BytesReceived
                                            - double.Parse(lbl_BytesReceived.Text)) / 1024;

                // Update the labels
                lbl_Speed.Text = nic.Speed.ToString();
                lbl_InterfaceType.Text = nic.NetworkInterfaceType.ToString();
                lbl_Speed.Text = (nic.Speed).ToString("N0");
                lbl_BytesReceived.Text = interfaceStats.BytesReceived.ToString("N0");
                lbl_BytesSent.Text = interfaceStats.BytesSent.ToString("N0");
                lbl_Upload.Text = bytesSentSpeed.ToString() + " KB/s";
                lbl_Download.Text = bytesReceivedSpeed.ToString() + " KB/s";

                UnicastIPAddressInformationCollection ipInfo = nic.GetIPProperties().UnicastAddresses;

                foreach (UnicastIPAddressInformation item in ipInfo)
                {
                    if (item.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        lbl_IPAddress.Text = item.Address.ToString();
                        //uniCastIPInfo = item;
                        break;
                    }
                }
            }
        }

        private void ToggleSysMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSysMonitor.Checked == true)
            {
                EnableSystemHealth();
            }
            else if (toggleSysMonitor.Checked == false)
            {

                DisableSystemHealth();
            }
            OptionsHelper.CurrentOptions.SystemMonitor = toggleSysMonitor.Checked;
        }

        private void EnableSystemHealth()
        {
            lblCurrentDate.Visible = true;
            lblGetSysUpTime.Visible = true;
            lblCores.Visible = true;
            lblLogicalCpuCores.Visible = true;
            lblMemUsage.Visible = true;
            lblFreeMemUsage.Visible = true;
            lblHandleCountValue.Visible = true;
            lblProcessCountValue.Visible = true;
            lblThreadCountValue.Visible = true;
            lbl_FreeDriveSpace.Visible = true;
            lbl_Download.Visible = true;
            lbl_Upload.Visible = true;
            lbl_InterfaceType.Visible = true;
            lbl_Speed.Visible = true;
            lbl_BytesSent.Visible = true;
            lbl_BytesReceived.Visible = true;
            lbl_IPAddress.Visible = true;
            lbl_DriveReadWrite.Visible = true;
            progressBarCPU.Visible = true;
            progressBarMem.Visible = true;
            progressBarOSUsage.Visible = true;
            progressBarUserUsage.Visible = true;
            progressFreeDiskSpace.Visible = true;
            progressFreeDiskSpaceC.Visible = true;
            _timer.Enabled = true;
            InitializeTimer();
        }

        private void DisableSystemHealth()
        {
            lblCurrentDate.Visible = false;
            lblGetSysUpTime.Visible = false;
            lblCores.Visible = false;
            lblLogicalCpuCores.Visible = false;
            lblMemUsage.Visible = false;
            lblFreeMemUsage.Visible = false;
            lblHandleCountValue.Visible = false;
            lblProcessCountValue.Visible = false;
            lblThreadCountValue.Visible = false;
            lbl_FreeDriveSpace.Visible = false;
            lbl_Download.Visible = false;
            lbl_Upload.Visible = false;
            lbl_InterfaceType.Visible = false;
            lbl_Speed.Visible = false;
            lbl_BytesSent.Visible = false;
            lbl_BytesReceived.Visible = false;
            lbl_IPAddress.Visible = false;
            lbl_DriveReadWrite.Visible = false;
            progressBarCPU.Visible = false;
            progressBarMem.Visible = false;
            progressBarOSUsage.Visible = false;
            progressBarUserUsage.Visible = false;
            progressFreeDiskSpace.Visible = false;
            progressFreeDiskSpaceC.Visible = false;
            _timer.Enabled = false;
            timer.Stop();
        }

        private void TogglePowerSavingsMode_CheckedChanged(object sender, EventArgs e)
        {
            if (togglePowerSavingsMode.Checked)
            {
                Helpers.EvolveHelper.SetPowerSavingPowerPlan();
            }
            else
            {
                Helpers.EvolveHelper.SetPerformancePowerPlan();
            }
            OptionsHelper.CurrentOptions.PowerSavingsMode = togglePowerSavingsMode.Checked;
        }

        private void ToggleGameMode_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleGameMode.Checked)
            {
                Helpers.EvolveHelper.GameMode();
            }
            else
            {
                Helpers.EvolveHelper.DesktopMode();
            }
            OptionsHelper.CurrentOptions.GameMode = toggleGameMode.Checked;
            ShowUserLogOutMsgBox = true;
            //Program.ShowMessageBox();
        }

        private void evolveButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("True");
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = @"C:\Program Files (x86)\Evolve\Data\CStandbyList.exe";
            myProcess.Start();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ExitWasClicked = true;
            if (ExitWasClicked == true)
            {
                if (timer != null && timer.Enabled) { timer.Stop(); }
            }
            //if (frmDashboard.timer != null && frmDashboard.timer.Enabled) { frmDashboard.timer.Stop(); }
            _timer.Enabled = false;
            this.Dispose();
        }

        private void btnClearDNS_Click(object sender, EventArgs e)
        {
            //new PopUpForm().Show(); //Show please wait splash form
            EvolveUtilities.ClearDNSCache();
        }
    }
}
