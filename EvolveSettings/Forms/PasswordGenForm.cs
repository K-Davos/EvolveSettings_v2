using Guna.UI2.WinForms;
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
    public partial class PasswordGenForm : Form
    {
        public PasswordGenForm()
        {
            InitializeComponent();
        }

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
