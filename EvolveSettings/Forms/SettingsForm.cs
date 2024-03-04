using EvolveSettings.Controls;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvolveSettings.Forms
{
    public partial class SettingsForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;
        public static bool UseWinTheme { get; set; }

        string resetConfigMessage = "Are you sure you want to reset to default configuration?";

        public SettingsForm()
        {
            InitializeComponent();

            //WinTheme
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);

            if (MainForm.adminkey == true)
            {
                toggleUserAccounts.Visible = true;
            }
            else
            {
                toggleUserAccounts.Visible = false;
                label3.Text = "DISABLED: Option only available when admin!";
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
                pnlHeader.BackColor = SystemColors.Control;
                lblTitle.ForeColor = Color.Black;
                foreach (Guna2ShadowPanel panel in this.tableLayoutPanel1.Controls.OfType<Guna2ShadowPanel>())
                {
                    panel.FillColor = Color.White;
                }
                foreach (Label label in this.pnlTheme.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Label label in this.pnlAutoStart.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Label label in this.pnlResetConfig.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                foreach (Label label in this.pnlDisableAccSignup.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                lblAutoStart.ForeColor = Color.Black;
                lblWinTheme.ForeColor = Color.Black;
                lblDefaultSettings.ForeColor = Color.Black;
                lblDisableAccSignup.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                lblTitle.ForeColor = Color.White;
                foreach (Guna2ShadowPanel panel in this.tableLayoutPanel1.Controls.OfType<Guna2ShadowPanel>())
                {
                    panel.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                }
                foreach (Label label in this.pnlTheme.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Label label in this.pnlAutoStart.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Label label in this.pnlResetConfig.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                foreach (Label label in this.pnlDisableAccSignup.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                lblAutoStart.ForeColor = Color.White;
                lblWinTheme.ForeColor = Color.White;
                lblDefaultSettings.ForeColor = Color.White;
                lblDisableAccSignup.ForeColor = Color.White;
            }
            //Buttons
            foreach (EvolveToggleButton button in this.pnlTheme.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = this.BackColor;
            }
            foreach (EvolveToggleButton button in this.pnlAutoStart.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = this.BackColor;
            }
            foreach (EvolveToggleButton button in this.pnlDisableAccSignup.Controls.OfType<EvolveToggleButton>())
            {
                button.OnBackColor = themeColor;
                button.OffBackColor = this.BackColor;
            }
            foreach (Guna2Button button in this.pnlResetConfig.Controls.OfType<Guna2Button>())
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
        #endregion wintheme

        private void LoadOptions()
        {
            //Load saved settings
            btnAutoStart.Checked = OptionsHelper.CurrentOptions.AutoStart;
            toggleWinTheme.Checked = OptionsHelper.CurrentOptions.WinTheme;
            toggleUserAccounts.Checked = OptionsHelper.CurrentOptions.SignUp;
        }

        private void BtnAutoStart_CheckedChanged(object sender, System.EventArgs e)
        {
            if (btnAutoStart.Checked)
            {
                EvolveUtilities.RegisterAutoStart();
            }
            else
            {
                EvolveUtilities.UnregisterAutoStart();
            }
            OptionsHelper.CurrentOptions.AutoStart = btnAutoStart.Checked;
        }

        private void ToggleWinTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleWinTheme.Checked)
            {
                //UseWinTheme = true;
                LoadTheme();
            }
            else
            {
                EvolveUtilities.Restart();
            }
            OptionsHelper.CurrentOptions.WinTheme = toggleWinTheme.Checked;
        }

        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(resetConfigMessage, "EvolveSettings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EvolveUtilities.ResetAppConfig();
            }
        }

        private void toggleUserAccounts_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleUserAccounts.Checked)
            {
                SignUpDisabled();
            }
            else
            {
                SignUpEnabled();
            }
            OptionsHelper.CurrentOptions.SignUp = toggleUserAccounts.Checked;
        }

        public static void SignUpDisabled()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Evolve\\EvolveSettings", true))
                {
                    k.SetValue("Admin", 0);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("CoreHelper.SignUpDisabled", ex.Message, ex.StackTrace);
            }
        }

        public static void SignUpEnabled()
        {
            try
            {
                using (RegistryKey k = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Evolve\\EvolveSettings", true))
                {
                    k.SetValue("Admin", 1);
                }
            }
            catch (Exception ex)
            {
                Logger.LogError("CoreHelper.SignUpDisabled", ex.Message, ex.StackTrace);
            }
        }
    }
}
