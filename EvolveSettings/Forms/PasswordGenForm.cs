using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class PasswordGenForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public PasswordGenForm()
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
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblPasswordGen.ForeColor = Color.Black;
                btnClose.ForeColor = Color.Black;
                lblLength.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                foreach (Guna2TextBox txtbox in this.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                lblPasswordGen.ForeColor = Color.White;
                btnClose.ForeColor = Color.White;
                lblLength.ForeColor = Color.White;
            }
            guna2TrackBar1.ThumbColor = themeColor;
            chkSymbols.CheckedState.FillColor = themeColor;
            chkDigits.CheckedState.FillColor = themeColor;
            chkUppercase.CheckedState.FillColor = themeColor;
            foreach (Guna2GroupBox grpbox in this.Controls.OfType<Guna2GroupBox>())
            {
                grpbox.BorderColor = themeColor;
                grpbox.CustomBorderColor = themeColor;
            }
            foreach (Guna2Button button in this.Controls.OfType<Guna2Button>())
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
        }
        #endregion wintheme

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblLength.Text = guna2TrackBar1.Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtGenPassword.Text = Helpers.PasswordGenerator.GeneratePassword(GetGenerateConfig());
        }

        private Models.GenerateConfig GetGenerateConfig()
        {
            Models.GenerateConfig config = new Models.GenerateConfig();
            config.IsLowerCase = chkLowercase.Checked;
            config.IsUpperCase = chkUppercase.Checked;
            config.IsDigits = chkDigits.Checked;
            config.IsSymbols = chkSymbols.Checked;
            config.Length = guna2TrackBar1.Value;
            return config;
        }

        private void btnPassGenCopy_Click(object sender, EventArgs e)
        {
            if (txtGenPassword.Text.Trim().Length > 0)
            {
                Clipboard.SetText(txtGenPassword.Text);
            }
        }
    }
}
