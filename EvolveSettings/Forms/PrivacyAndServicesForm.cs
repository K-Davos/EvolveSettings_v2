using EvolveSettings.Controls;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class PrivacyAndServicesForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public PrivacyAndServicesForm()
        {
            InitializeComponent();

            //WinTheme
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
        private void LoadTheme()
        {
            var themeColor = WinTheme.GetAccentColor();//Windows Accent Color
            var lightColor = ControlPaint.Light(themeColor);
            var darkColor = ControlPaint.Dark(themeColor);

            var isDarkorLight = IsDarkTheme();
            if (isDarkorLight)
            {
                //light
                this.BackColor = SystemColors.Control;
            }
            else
            {
                //dark
                if (OptionsHelper.CurrentOptions.BlurEffect == true)
                {
                    this.BackColor = Color.Black;
                    pnlHeader.BackColor = Color.Black;
                    pnlBack.FillColor = Color.Transparent;
                }
                else
                {
                    this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                    pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                    pnlBack.FillColor = Color.Transparent;
                }
                scrollBarBackPanel.ThumbColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlWinUpdates.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlExcludeDriverUpdates.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlInsiderService.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlMsStore.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel1.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel2.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel3.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel4.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel5.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel6.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel7.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel8.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel9.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel10.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPrivacyPanel11.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                //Labels
                lblTitle.ForeColor = Color.White;
                lblWinUpdate.ForeColor = Color.White;
                lblWinUpdateSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblExcludeDrivers.ForeColor = Color.White;
                lblExcludeDriversSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblInsiderService.ForeColor = Color.White;
                lblInsiderServiceSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblMsStore.ForeColor = Color.White;
                lblMsStoreSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblTelemetryServices.ForeColor = Color.White;
                lblTelemetryServicesSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblTelemetryTasks.ForeColor = Color.White;
                lblTelemetryTasksSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblEnhancedPrivacy.ForeColor = Color.White;
                lblEnhancedPrivacySum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblEdgeTelemetry.ForeColor = Color.White;
                lblEdgeTelemetrySum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblEdgeDiscover.ForeColor = Color.White;
                lblEdgeDiscoverSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblChromeTelemetry.ForeColor = Color.White;
                lblChromeTelemetrySum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblStartMenuAds.ForeColor = Color.White;
                lblStartMenuAdsSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblHomegroup.ForeColor = Color.White;
                lblHomegroupSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblCortana.ForeColor = Color.White;
                lblCortanaSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblNvidiaTelemetry.ForeColor = Color.White;
                lblNvidiaTelemetrySum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblOfficeTelemetry.ForeColor = Color.White;
                lblOfficeTelemetrySum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblWinUpdateHeader.ForeColor = Color.White;
                lblPrivacyHeader.ForeColor = Color.White;
            }
            foreach (EvolveToggleButton button in this.pnlWinUpdates.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlExcludeDriverUpdates.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlInsiderService.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlMsStore.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel1.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel2.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel3.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel4.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel5.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel6.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel7.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel8.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel9.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel10.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            foreach (EvolveToggleButton button in this.pnlPrivacyPanel11.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF1F1F20");
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

        private void LoadOptions()
        {
            //Load saved settings
            toggleInsiderService.Checked = OptionsHelper.CurrentOptions.InsiderService;
            toggleWinUpdate.Checked = OptionsHelper.CurrentOptions.WindowsAutoUpdates;
            toggleExcludeDrivers.Checked = OptionsHelper.CurrentOptions.ExcludeWinDriverUpdates;
            toggleMsStoreUpdate.Checked = OptionsHelper.CurrentOptions.MsStoreUpdates;
            toggleDisableTelemetryServ.Checked = OptionsHelper.CurrentOptions.TelemetryServices;
            toggleDisableTelemetryTasks.Checked = OptionsHelper.CurrentOptions.TelemetryTasks;
            toggleEnhancePrivacy.Checked = OptionsHelper.CurrentOptions.EnhancePrivacy;
            toggleEdgeTelemetry.Checked = OptionsHelper.CurrentOptions.EdgeTelemetry;
            toggleChromeTelemetry.Checked = OptionsHelper.CurrentOptions.ChromeTelemetry;
            toggleStartMenuAds.Checked = OptionsHelper.CurrentOptions.StartMenuAds;
            toggleHomeGroup.Checked = OptionsHelper.CurrentOptions.HomeGroup;
            toggleCortana.Checked = OptionsHelper.CurrentOptions.Cortana;
            toggleNvidiaTelemetry.Checked = OptionsHelper.CurrentOptions.NvidiaTelemetry;
            toggleMsOfficeTelemetry.Checked = OptionsHelper.CurrentOptions.MsOfficeTelemetry;
        }
        #region Toggles
        private void ToggleWinUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleWinUpdate.Checked)
            {
                Helpers.EvolveHelper.DisableAutomaticUpdates();
            }
            else
            {
                Helpers.EvolveHelper.EnableAutomaticUpdates();
            }
            OptionsHelper.CurrentOptions.WindowsAutoUpdates = toggleWinUpdate.Checked;
        }

        private void ToggleExcludeDrivers_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleExcludeDrivers.Checked)
            {
                Helpers.EvolveHelper.DisableDriverUpdates();
            }
            else
            {
                Helpers.EvolveHelper.EnableDriverUpdates();
            }
            OptionsHelper.CurrentOptions.ExcludeWinDriverUpdates = toggleExcludeDrivers.Checked;
        }

        private void ToggleInsiderService_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleInsiderService.Checked)
            {
                Helpers.EvolveHelper.DisableInsiderService();
            }
            else
            {
                Helpers.EvolveHelper.EnableInsiderService();
            }
            OptionsHelper.CurrentOptions.InsiderService = toggleInsiderService.Checked;
        }

        private void ToggleMsStoreUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleMsStoreUpdate.Checked)
            {
                Helpers.EvolveHelper.DisableStoreUpdates();
            }
            else
            {
                Helpers.EvolveHelper.EnableStoreUpdates();
            }
            OptionsHelper.CurrentOptions.MsStoreUpdates = toggleMsStoreUpdate.Checked;
        }

        private void ToggleDisableTelemetryServ_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleDisableTelemetryServ.Checked)
            {
                Helpers.EvolveHelper.DisableTelemetryServices();
            }
            else
            {
                Helpers.EvolveHelper.EnableTelemetryServices();
            }
            OptionsHelper.CurrentOptions.TelemetryServices = toggleDisableTelemetryServ.Checked;
        }
        private void ToggleDisableTelemetryTasks_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleDisableTelemetryTasks.Checked)
            {
                Helpers.EvolveHelper.DisableTelemetryTasks();
            }
            else
            {
                Helpers.EvolveHelper.EnableTelemetryTasks();
            }
            OptionsHelper.CurrentOptions.TelemetryTasks = toggleDisableTelemetryTasks.Checked;
        }

        private void ToggleEnhancePrivacy_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleEnhancePrivacy.Checked)
            {
                Helpers.EvolveHelper.EnableEnhancePrivacy();
            }
            else
            {
                Helpers.EvolveHelper.DisableEnhancePrivacy();
            }
            OptionsHelper.CurrentOptions.EnhancePrivacy = toggleEnhancePrivacy.Checked;
        }

        private void ToggleEdgeTelemetry_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleEdgeTelemetry.Checked)
            {
                Helpers.EvolveHelper.DisableEdgeTelemetry();
            }
            else
            {
                Helpers.EvolveHelper.EnableEdgeTelemetry();
            }
            OptionsHelper.CurrentOptions.EdgeTelemetry = toggleEdgeTelemetry.Checked;
        }

        private void ToggleEdgeDiscover_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleEdgeDiscover.Checked)
            {
                Helpers.EvolveHelper.DisableEdgeDiscover();
            }
            else
            {
                Helpers.EvolveHelper.EnableEdgeDiscover();
            }
            OptionsHelper.CurrentOptions.EdgeDiscover = toggleEdgeDiscover.Checked;
        }

        private void ToggleChromeTelemetry_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleChromeTelemetry.Checked)
            {
                Helpers.EvolveHelper.DisableChromeTelemetry();
            }
            else
            {
                Helpers.EvolveHelper.EnableChromeTelemetry();
            }
            OptionsHelper.CurrentOptions.ChromeTelemetry = toggleChromeTelemetry.Checked;
        }

        private void ToggleStartMenuAds_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleStartMenuAds.Checked)
            {
                Helpers.EvolveHelper.DisableStartMenuAds();
            }
            else
            {
                Helpers.EvolveHelper.EnableStartMenuAds();
            }
            OptionsHelper.CurrentOptions.StartMenuAds = toggleStartMenuAds.Checked;
        }

        private void ToggleHomeGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleHomeGroup.Checked)
            {
                Helpers.EvolveHelper.DisableHomeGroup();
            }
            else
            {
                Helpers.EvolveHelper.EnableHomeGroup();
            }
            OptionsHelper.CurrentOptions.HomeGroup = toggleHomeGroup.Checked;
        }

        private void ToggleCortana_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleCortana.Checked)
            {
                Helpers.EvolveHelper.DisableCortana();
            }
            else
            {
                Helpers.EvolveHelper.EnableCortana();
            }
            OptionsHelper.CurrentOptions.Cortana = toggleCortana.Checked;
        }

        private void ToggleNvidiaTelemetry_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleNvidiaTelemetry.Checked == true)
            {
                Helpers.EvolveHelper.DisableNvidiaTelemetry();
            }
            else
            {
                Helpers.EvolveHelper.EnableNvidiaTelemetry();
            }
            OptionsHelper.CurrentOptions.NvidiaTelemetry = toggleNvidiaTelemetry.Checked;
        }

        private void ToggleMsOfficeTelemetry_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleMsOfficeTelemetry.Checked)
            {
                Helpers.EvolveHelper.DisableMsOfficeTelemetry();
            }
            else
            {
                Helpers.EvolveHelper.EnableMsOfficeTelemetry();
            }
            OptionsHelper.CurrentOptions.MsOfficeTelemetry = toggleMsOfficeTelemetry.Checked;
        }
        #endregion Toggles
    }
}
