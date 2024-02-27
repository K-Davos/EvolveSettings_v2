using EvolveSettings.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvolveSettings
{
    public partial class MainForm : Form
    {
        public Point mouseLocation;

        public MainForm()
        {
            InitializeComponent();
            openChildForm(new HomePageForm());
        }

        public MainForm(String usrname)
        {
            InitializeComponent();

            label1.Text = usrname;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                //activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new HomePageForm());
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

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
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
            Show();
            WindowState = FormWindowState.Normal;
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
    }
}
