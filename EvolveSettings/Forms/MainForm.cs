using EvolveSettings.Controls;
using EvolveSettings.Forms;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static EvolveSettings.EffectBlur;

namespace EvolveSettings
{
    public partial class MainForm : Form
    {
        //Fields
        private int borderSize = 2;
        private Size formSize;

        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        SqlConnection connect = new SqlConnection(SqlConnectionHelper.connectReturn());

        public static bool adminkey { get; set; }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public MainForm()
        {
            InitializeComponent();
        }

            public MainForm(String usrname)
            {
            InitializeComponent();
            lblCurrentUser.Text = usrname;

            string sql = "select * from admin where username='" + lblCurrentUser.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connect);
            connect.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    lblUserType.Text = dr["usertype"].ToString();
                }
            }

            if (lblCurrentUser.Text == "admin")
            {
                btnUserManagement.Visible = true;
                btnPassManager.Visible = true;
                AdminKeyEnabled();
                lblUserMode.Text = "UserMode: Admin";
                OptionsHelper.CurrentOptions.CurrentUser = "Admin";
                OptionsHelper.CurrentOptions.UserName = string.Empty;
            }
            else if (lblUserType.Text == "admin")
            {
                btnUserManagement.Visible = true;
                btnPassManager.Visible = true;
                AdminKeyDisabled();
                lblUserMode.Text = "UserMode: Admin";
                OptionsHelper.CurrentOptions.CurrentUser = "Admin";
                OptionsHelper.CurrentOptions.UserName = lblCurrentUser.Text;
            }
            else
            {
                btnUserManagement.Visible = false;
                btnPassManager.Visible = false;
                AdminKeyDisabled();
                lblUserMode.Text = "UserMode: Guest";
                OptionsHelper.CurrentOptions.CurrentUser = "Guest";
                OptionsHelper.CurrentOptions.UserName = lblCurrentUser.Text;
            }
            lblUserType.Visible = false;

            CollapseMenu();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(98, 102, 244);//Border color

            txtOS.Text = EvolveUtilities.GetOS();
            txtBitness.Text = EvolveUtilities.GetBitness();
            txtNetFw.Text = ".NET Framework " + EvolveUtilities.GetNETFramework();
            txtAppVersion.Text = Program.GetCurrentVersionTostring();
            //btnLogout.Location = new Point(15, 641);
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            OptionsHelper.SaveSettings();
            LoadOptions();
            openChildForm(new HomeForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //resize form
            formSize = this.ClientSize;
            lblBlurEffect.Visible = false;
            pnlFlyOut.Visible = false;
            trackBarBlur.Enabled = false;
        }

        #region resize form
        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }


            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion

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

        # region acryl/blur
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
        #endregion acryl/blur

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
                this.BackColor = themeColor;//Border color
                pnlHeader.BackColor = SystemColors.Control;
                pnlFlyOut.FillColor = Color.White;
                lblLength.ForeColor = Color.Black;
                btnCloseApp.Image = EvolveSettings.Properties.Resources.quit_black;
                btnMaximize.Image = EvolveSettings.Properties.Resources.maximize_black;
                btnMinimize.Image = EvolveSettings.Properties.Resources.minimize_black;
            }
            else
            {
                //dark
                this.BackColor = themeColor;//Border color
                if (OptionsHelper.CurrentOptions.BlurEffect = true)
                {
                    pnlHeader.BackColor = Color.Black;
                }
                else
                {
                    pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                }
                pnlFlyOut.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                lblLength.ForeColor = Color.White;
                btnCloseApp.Image = EvolveSettings.Properties.Resources.quit;
                btnMaximize.Image = EvolveSettings.Properties.Resources.maximize;
                btnMinimize.Image = EvolveSettings.Properties.Resources.minimize;
            }
            pnlNav.BackColor = themeColor;
            trackBarBlur.ThumbColor = themeColor;
            foreach (Guna2Button button in this.pnlNav.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.BackColor = Color.Transparent;
            }
            foreach (EvolveToggleButton evolvebutton in this.pnlFlyOut.Controls.OfType<EvolveToggleButton>())
            {
                evolvebutton.OnBackColor = themeColor;
                evolvebutton.OffBackColor = Color.Gray;
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
            toggleBlurEffect.Checked = OptionsHelper.CurrentOptions.BlurEffect;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomeForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnWin11Tweaks_Click(object sender, EventArgs e)
        {
            openChildForm(new PrivacyAndServicesForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }
        private void btnNetwork_Click(object sender, EventArgs e)
        {
            openChildForm(new NetworkForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnPcCleaner_Click(object sender, EventArgs e)
        {
            openChildForm(new PcCleanerForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new SettingsForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnFileEncryptor_Click(object sender, EventArgs e)
        {
            openChildForm(new UserSecurityForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnPassManager_Click(object sender, EventArgs e)
        {
            openChildForm(new PasswordManagerForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
            btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            pnlFlyOut.Visible = false;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            AdjustForm();
        }

        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {

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
            if (this.pnlNav.Width > 180)
            {   //Collapse menu
                pnlNav.Width = 75;
                pictureBoxProfile.Visible = false;
                lblCurrentUser.Visible = false;
                txtOS.Visible = false;
                txtBitness.Visible = false;
                txtNetFw.Visible = false;
                lblversion.Visible = false;
                txtAppVersion.Visible = false;
                lblUserMode.Visible = false;
                //btnLogout.Location = new Point(15, 681);
                btnMenu.Location = new Point(25, 19);
                foreach (Guna2Button menuButton in pnlNav.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageOffset = new Point(17, 0);
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {   //Expand menu
                pnlNav.Width = 187;
                pictureBoxProfile.Visible = true;
                lblCurrentUser.Visible = true;
                txtOS.Visible = true;
                txtBitness.Visible = true;
                txtNetFw.Visible = true;
                lblversion.Visible = true;
                txtAppVersion.Visible = true;
                lblUserMode.Visible = true;
                //btnLogout.Location = new Point(144, 681);
                btnMenu.Location = new Point(155, 19);
                foreach (Guna2Button menuButton in pnlNav.Controls.OfType<Guna2Button>())
                {
                    menuButton.Text = "" + menuButton.Tag.ToString();
                    menuButton.ImageOffset = new Point(0, 0);
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void btnSystemMonitor_Click(object sender, EventArgs e)
        {
            SystemMonitorForm sysmon = new SystemMonitorForm();
            this.Hide();
            sysmon.ShowDialog();
            this.Show();
        }

        private void trackBarBlur_Scroll(object sender, ScrollEventArgs e)
        {
            lblLength.Text = trackBarBlur.Value.ToString();
            BlurOpacity = (int)e.NewValue;
        }

        private void toggleBlurEffect_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleBlurEffect.Checked)
            {
                EnableBlur();
                trackBarBlur.Enabled = true;
                pictureBoxProfile.BackColor = Color.Transparent;
                this.BackColor = Color.Black; //Border Color
                foreach (Guna2Button button in this.pnlNav.Controls.OfType<Guna2Button>())
                {
                    button.FillColor = Color.Transparent;
                    button.BackColor = Color.Transparent;
                }
            }
            else
            {
                LoadTheme();
                trackBarBlur.Enabled = false;
                Login login = new Login();
                login.Show();
                this.Dispose();
            }
            OptionsHelper.CurrentOptions.BlurEffect = toggleBlurEffect.Checked;
        }

        private void btnFlyOutPanel_Click(object sender, EventArgs e)
        {
                FlyOutPanel();
        }

        private void FlyOutPanel()
        {
            if (lblBlurEffect.Visible == false)
            {
                //guna2Transition1.Show(pnlFlyOut);
                if (OptionsHelper.CurrentOptions.BlurEffect == true)
                {
                    trackBarBlur.Enabled = true;
                }
                pnlFlyOut.Visible = true;
                pnlFlyOut.BringToFront();
                lblBlurEffect.Visible = true;
                btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.collapse;
            }
            else
            {
                pnlFlyOut.Visible = false;
                lblBlurEffect.Visible = false;
                btnFlyOutPanel.Image = EvolveSettings.Properties.Resources.expand;
            }
        }
    }
}
