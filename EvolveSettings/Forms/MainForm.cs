using EvolveSettings.Forms;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;

namespace EvolveSettings
{
    public partial class MainForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        public Point mouseLocation;
        public static bool adminkey { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(String usrname)
        {
            InitializeComponent();
            CollapseMenu();

            txtOS.Text = EvolveUtilities.GetOS();
            txtBitness.Text = EvolveUtilities.GetBitness();
            txtNetFw.Text = ".NET Framework " + EvolveUtilities.GetNETFramework();
            txtAppVersion.Text = Program.GetCurrentVersionTostring();
            lblCurrentUser.Text = usrname;
            if (lblCurrentUser.Text == "Welcome: admin" )
            {
                btnUserManagement.Visible = true;
                btnPassManager.Visible = true;
                AdminKeyEnabled();
                lblUserMode.Text = "UserMode: Admin";
                OptionsHelper.CurrentOptions.CurrentUser = "Admin";
            }
            else
            {
                btnUserManagement.Visible = false;
                btnPassManager.Visible = false;
                AdminKeyDisabled();
                lblUserMode.Text = "UserMode: Guest";
                OptionsHelper.CurrentOptions.CurrentUser = "Guest";
            }
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            OptionsHelper.SaveSettings();
            openChildForm(new HomeForm());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
                activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
            }
            pnlNav.BackColor = themeColor;
            pnlHeader.BackColor = themeColor;
            pnlRadius.BackColor = themeColor;
            foreach (Guna2Button button in this.pnlNav.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
        }

        private void btnWin11Tweaks_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form());
        }
        private void btnNetwork_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form());
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm());
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void btnPassManager_Click(object sender, EventArgs e)
        {
            openChildForm(new PasswordManagerForm());
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            notifyIcon1.ShowBalloonTip(3000, "Evolve Settings", "The App has been moved to the system tray.", ToolTipIcon.Info);
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
                TopMost = true;
                Focus();
                BringToFront();
                TopMost = false;
        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        public static void AdminKeyEnabled()
        {
            adminkey = true;
        }

        public static void AdminKeyDisabled()
        {
            adminkey = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logfrm = new Login();
            this.Dispose();
            logfrm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.pnlNav.Width > 180) //Collapse menu
            {
                pnlNav.Width = 75;
                pictureBoxProfile.Visible = false;
                lblCurrentUser.Visible = false;
                txtOS.Visible = false;
                txtBitness.Visible = false;
                txtNetFw.Visible = false;
                lblversion.Visible = false;
                txtAppVersion.Visible = false;
                lblUserMode.Visible = false;
                btnLogout.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Guna2Button menuButton in pnlNav.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageOffset = new Point(17, 0);
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                pnlNav.Width = 187;
                pictureBoxProfile.Visible = true;
                lblCurrentUser.Visible = true;
                txtOS.Visible = true;
                txtBitness.Visible = true;
                txtNetFw.Visible = true;
                lblversion.Visible = true;
                txtAppVersion.Visible = true;
                lblUserMode.Visible = true;
                btnLogout.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Guna2Button menuButton in pnlNav.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageOffset = new Point(0, 0);
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
    }
}
