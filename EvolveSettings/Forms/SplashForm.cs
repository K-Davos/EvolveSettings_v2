using System;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            timer1.Start();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar.Value = startPoint;
            if (progressBar.Value == 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Login frmlogin = new Login();
                this.Hide();
                frmlogin.ShowDialog();
            }
        }
    }
}
