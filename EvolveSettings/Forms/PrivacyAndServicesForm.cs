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
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlBack.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlWinUpdates.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlExcludeDriverUpdates.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlInsiderService.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlMsStore.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                lblTitle.ForeColor = Color.White;
                lblWinUpdate.ForeColor = Color.White;
                lblWinUpdateSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblExcludeDrivers.ForeColor = Color.White;
                lblExcludeDriversSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblInsiderService.ForeColor = Color.White;
                lblInsiderServiceSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblMsStore.ForeColor = Color.White;
                lblMsStoreSum.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
            }
            foreach (EvolveToggleButton button in this.pnlWinUpdates.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF2D2D30");
            }
            foreach (EvolveToggleButton button in this.pnlExcludeDriverUpdates.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF2D2D30");
            }
            foreach (EvolveToggleButton button in this.pnlInsiderService.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF2D2D30");
            }
            foreach (EvolveToggleButton button in this.pnlMsStore.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = ColorTranslator.FromHtml("#FF2D2D30");
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
        }

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
    }
}
