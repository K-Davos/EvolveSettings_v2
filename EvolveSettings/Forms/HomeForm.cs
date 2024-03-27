using EvolveSettings.Controls;
using Guna.UI2.Native;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class HomeForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        bool update = false;

        public HomeForm()
        {
            InitializeComponent();

            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            LoadOptions();
        }

        #region wintheme
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
        public void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            var isDarkorLight = IsDarkTheme();
            if (isDarkorLight)
            {
                //light
                this.BackColor = SystemColors.Control;
                lblTitle.ForeColor = Color.Black;
                foreach (EvolvePanel panel in this.Controls.OfType<EvolvePanel>())
                {
                    panel.BackColor = Color.White;
                }
            }
            else
            {
                //dark
                this.BackColor = Color.Black;
                lblTitle.ForeColor = Color.White;
                foreach (EvolvePanel panel in this.Controls.OfType<EvolvePanel>())
                {
                    panel.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
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
        #endregion wintheme

        WinAPI WinAPI = new WinAPI();

        private void HomeForm_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle, 150, WinAPI.CENTER);

            timer1.Start();
        }

        private void LoadOptions()
        {
            //Load saved settings
        }

        #region diagnostics
        PerformanceCounter cpu = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total", true);
        ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

        private void UpdateUiElements()
        {
            //lblCPU.Text = ((int)Math.Round(cpu.NextValue(), 2)).ToString() + " %";

            //Cpu
            progressBarCPU.Value = (int)Math.Round(cpu.NextValue(), 2);

            // --------------------------------------------------------------------------------------------------------
            //Memory
            float totalMemory = 0;
            float freeMemory = 0;

            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();

            foreach (ManagementObject result in results)
            {
                totalMemory = (float.Parse(result["TotalVisibleMemorySize"].ToString()) / 1024);
                freeMemory = (float.Parse(result["FreePhysicalMemory"].ToString()) / 1024);
            }

            var RamVal = 100 - ((freeMemory / totalMemory) * 100);
            progressBarRAM.Value = (int)RamVal;

            lblRamTotalData.Text = ((int)totalMemory).ToString() + " Megabytes";
            lblRamUsedData.Text = ((int)totalMemory - (int)freeMemory).ToString() + " Megabytes";
            lblRamAvailableData.Text = ((int)freeMemory).ToString() + " Megabytes";

            if (!update)
            {
                UpdateDiskAndCPUInfo();
                update = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateUiElements();
        }

        private void UpdateDiskAndCPUInfo()
        {
            //Cpu Elements
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                lblCpuSpeedData.Text = float.Parse(obj["CurrentClockSpeed"].ToString()) / 1000 + " GHz";
                lblCpuCoresData.Text = obj["NumberOfCores"].ToString();
                lblCpuThreadsData.Text = obj["NumberOfLogicalProcessors"].ToString();
            }

            // --------------------------------------------------------------------------------------------------------
            //Disk Space
            double totalFreeSpace = 0;
            double totalSpace = 0;
            double usedSpace = 0;

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    totalFreeSpace += d.AvailableFreeSpace;
                    totalSpace += d.TotalSize;
                }
            }

            usedSpace = 100 - (totalFreeSpace / totalSpace) * 100;
            var u_s = totalSpace - totalFreeSpace;
            progressBarStorage.Value = (int)usedSpace;
            lblStorageTotalData.Text = ((int)Math.Round((totalSpace / 1024d / 1024d / 1024d), 2)).ToString() + " Gigabytes";
            lblStorageUsedData.Text = ((int)Math.Round((u_s / 1024d / 1024d / 1024d), 2)).ToString() + " Gigabytes";
            lblStorageAvailableData.Text = ((int)Math.Round((totalFreeSpace / 1024d / 1024d / 1024d), 2)).ToString() + " Gigabytes";
        }
        #endregion diagnostics

        private void lblTitle_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 0)
            {
                timer1.Stop();
                timer2.Stop();
                this.Close();
            }
            else
            {
                this.Opacity -= 0.1;
            }
        }

        private void btnCpuInfo_Click(object sender, EventArgs e)
        {
            CpuInformationForm cpufrm = new CpuInformationForm();
            cpufrm.ShowDialog();
        }
    }
}
