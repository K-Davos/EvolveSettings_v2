using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class NetworkForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        List<PingReply> _pingResults;
        string _shodanIP = string.Empty;
        PingReply tmpReply;

        string[] _currentDNS;

        public NetworkForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            boxDNS.Items.AddRange(Helpers.NetworkHelper.DNSOptions);
            boxAdapter.SelectedIndexChanged += boxAdapter_SelectedIndexChanged;
            LoadPingerDNSConfig();
            DisplayCurrentDNS();

            //WinTheme
            if (OptionsHelper.CurrentOptions.WinTheme == true)
            {
                LoadTheme();
            }
            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Disposed);

            Load += NetworkForm_Load;

            GetIP();
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
                pnlDnsServer.FillColor = Color.White;
                pnlPingIP.FillColor = Color.White;
                label1.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                label2.ForeColor = Color.Black;
                label3.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblNetworkAdapter.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
                label9.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                label11.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                lblPresetDNS.ForeColor = Color.Black;
                lblIPaddressPing.ForeColor = Color.Black;
                lblPingResults.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Black;
                chkCustomDns.ForeColor = Color.Black;
                chkAllNics.ForeColor = Color.Black;
                foreach (Guna2TextBox txtbox in this.pnlDnsServer.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF1F1F20");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                foreach (Guna2TextBox txtbox in this.pnlPingIP.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = SystemColors.Control;
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.Black;
                }
                boxAdapter.BackColor = Color.Transparent;
                boxAdapter.BorderColor = themeColor;
                boxAdapter.ForeColor = Color.Black;
                boxAdapter.FillColor = Color.White;
                boxDNS.BackColor = Color.Transparent;
                boxDNS.BorderColor = themeColor;
                boxDNS.ForeColor = Color.Black;
                boxDNS.FillColor = Color.White;
                listPingResults.BackColor = Color.White;
                listPingResults.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlDnsServer.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlPingIP.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                label1.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                label2.ForeColor = Color.White;
                label3.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                lblNetworkAdapter.ForeColor = Color.White; ;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label8.ForeColor = Color.White;
                label9.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                label11.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                lblPresetDNS.ForeColor = Color.White; ;
                lblIPaddressPing.ForeColor = Color.White; ;
                lblPingResults.ForeColor = Color.White; ;
                lblTitle.ForeColor = Color.White;
                foreach (Guna2TextBox txtbox in this.pnlDnsServer.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                foreach (Guna2TextBox txtbox in this.pnlPingIP.Controls.OfType<Guna2TextBox>())
                {
                    txtbox.BackColor = Color.Transparent;
                    txtbox.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                    txtbox.BorderColor = themeColor;
                    txtbox.ForeColor = Color.White;
                }
                boxAdapter.BackColor = Color.Transparent;
                boxAdapter.BorderColor = themeColor;
                boxAdapter.ForeColor = Color.White;
                boxAdapter.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                boxDNS.BackColor = Color.Transparent;
                boxDNS.BorderColor = themeColor;
                boxDNS.ForeColor = Color.White;
                boxDNS.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                listPingResults.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                listPingResults.ForeColor = Color.White;
            }

            foreach (Guna.UI2.WinForms.Guna2CheckBox checkbox in this.pnlDnsServer.Controls.OfType<Guna.UI2.WinForms.Guna2CheckBox>())
            {
                checkbox.CheckedState.FillColor = themeColor;
            }

            foreach (Guna2Button button in this.pnlDnsServer.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            foreach (Guna2Button button in this.pnlPingIP.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }

            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.ForeColor = this.BackColor;
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
            chkCustomDns.Checked = OptionsHelper.CurrentOptions.CustomDNS;
        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {
            if (chkCustomDns.Checked == true)
            {
                lblPresetDNS.Visible = true;
                label10.Visible = true;
                label12.Visible = true;
                txtDns4A.Visible = true;
                txtDns4B.Visible = true;
                txtDns6A.Visible = true;
                txtDns6B.Visible = true;
                boxDNS.Visible = false;
                lblPresetDNS.Visible = false;
            }
        }

        private void GetIP()
        {
            IPAddress[] ip = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in ip)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    lblIPaddress.Text = address.ToString();
                }
            }
        }
        private void LoadPingerDNSConfig()
        {
            NetworkInterface[] nics = Helpers.NetworkHelper.GetActiveNetworkAdapters();
            if (nics == null) return;
            if (nics.Length == 0) return;

            boxAdapter.Items.AddRange(nics.Select(z => z.Description).ToArray());
            if (boxAdapter.Items.Count > 0) boxAdapter.SelectedIndex = 0;

            linkDNSv4.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv4A.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv6.LinkClicked += linkDNSIP_LinkClicked;
            linkDNSv6A.LinkClicked += linkDNSIP_LinkClicked;

            LoadNetworkAdapterConfig();
        }

        private void LoadNetworkAdapterConfig()
        {
            if (boxAdapter.Items.Count <= 0) return;

            Helpers.NetworkHelper.GetActiveNetworkAdapters();
            if (Helpers.NetworkHelper.NetworkAdapters == null) return;
            if (Helpers.NetworkHelper.NetworkAdapters.Length == 0) return;

            _currentDNS = Helpers.NetworkHelper.GetDNSFromNetworkAdapter(Helpers.NetworkHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();
            if (_currentDNS == null) return;
            if (_currentDNS.Length == 0) return;

            if (Array.Exists(Helpers.NetworkHelper.CloudflareDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.CloudflareDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.OpenDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.OpenDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.Quad9DNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.Quad9DNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.GcoreDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.GcoreDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.GoogleDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.GoogleDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.AlternateDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.AlternateDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.AdguardDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.AdguardDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.CleanBrowsingDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.CleanBrowsingDNS;
                return;
            }
            else if (Array.Exists(Helpers.NetworkHelper.CleanBrowsingAdultDNSv4, x => _currentDNS.Select(y => y.ToString()).Contains(x)))
            {
                boxDNS.Text = Constants.CleanBrowsingAdultFilterDNS;
                return;
            }
            else
            {
                boxDNS.Text = Constants.CustomDNS;
                chkCustomDns.Checked = true;
                try
                {
                    if (_currentDNS.Length == 1)
                    {
                        linkDNSv4.Text = _currentDNS[0];
                        txtDns4A.Text = _currentDNS[0];
                    }
                    else if (_currentDNS.Length == 2)
                    {
                        linkDNSv4.Text = _currentDNS[0];
                        linkDNSv4A.Text = _currentDNS[1];
                        txtDns4A.Text = _currentDNS[0];
                        txtDns4B.Text = _currentDNS[1];
                    }
                    else if (_currentDNS.Length == 3)
                    {
                        linkDNSv6.Text = _currentDNS[0];
                        linkDNSv4.Text = _currentDNS[1];
                        linkDNSv4A.Text = _currentDNS[2];
                        txtDns6A.Text = _currentDNS[0];
                        txtDns4A.Text = _currentDNS[1];
                        txtDns4B.Text = _currentDNS[2];
                    }
                    else if (_currentDNS.Length == 4)
                    {
                        linkDNSv4.Text = _currentDNS[2];
                        linkDNSv4A.Text = _currentDNS[3];
                        linkDNSv6.Text = _currentDNS[0];
                        linkDNSv6A.Text = _currentDNS[1];

                        txtDns6A.Text = _currentDNS[2];
                        txtDns6B.Text = _currentDNS[3];
                        txtDns6A.Text = _currentDNS[0];
                        txtDns6B.Text = _currentDNS[1];
                    }
                }
                catch { }
                return;
            }
        }

        private void SetDNS(string[] v4, string[] v6)
        {
            if (chkAllNics.Checked)
            {
                Helpers.NetworkHelper.SetDNSForAllNICs(v4, v6);
            }
            else
            {
                Helpers.NetworkHelper.SetDNS(Helpers.NetworkHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name, v4, v6);
            }
            Helpers.NetworkHelper.GetActiveNetworkAdapters();
            DisplayCurrentDNS();
        }

        private void ResetDNS()
        {
            if (chkAllNics.Checked)
            {
                Helpers.NetworkHelper.ResetDefaultDNSForAllNICs();
            }
            else
            {
                Helpers.NetworkHelper.ResetDefaultDNS(Helpers.NetworkHelper.NetworkAdapters[boxAdapter.SelectedIndex].Name);
            }
            Helpers.NetworkHelper.GetActiveNetworkAdapters();
            DisplayCurrentDNS();
        }

        private void ApplyCustomDNS()
        {
            string[] customDns4 =
            {
                txtDns4A.Text,
                txtDns4B.Text
            };
            string[] customDns6 =
            {
                txtDns6A.Text,
                txtDns6B.Text
            };

            if (Array.Exists(customDns4, x => string.IsNullOrEmpty(x)) || Array.Exists(customDns6, x => string.IsNullOrEmpty(x)))
            {
                return;
            }

            SetDNS(customDns4, customDns6);

            txtDns4A.Text = string.Empty;
            txtDns4B.Text = string.Empty;
            txtDns6A.Text = string.Empty;
            txtDns6B.Text = string.Empty;
        }

        private void ApplySelectedDNS()
        {
            if (boxAdapter.Items.Count <= 0) return;
            if (boxAdapter.SelectedIndex <= -1) return;

            if (boxDNS.Text == Constants.AutomaticDNS)
            {
                ResetDNS();
                return;
            }
            else if (boxDNS.Text == Constants.CloudflareDNS)
            {
                SetDNS(Helpers.NetworkHelper.CloudflareDNSv4, Helpers.NetworkHelper.CloudflareDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.OpenDNS)
            {
                SetDNS(Helpers.NetworkHelper.OpenDNSv4, Helpers.NetworkHelper.OpenDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.Quad9DNS)
            {
                SetDNS(Helpers.NetworkHelper.Quad9DNSv4, Helpers.NetworkHelper.Quad9DNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.GcoreDNS)
            {
                SetDNS(Helpers.NetworkHelper.GcoreDNSv4, Helpers.NetworkHelper.GcoreDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.GoogleDNS)
            {
                SetDNS(Helpers.NetworkHelper.GoogleDNSv4, Helpers.NetworkHelper.GoogleDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.AlternateDNS)
            {
                SetDNS(Helpers.NetworkHelper.AlternateDNSv4, Helpers.NetworkHelper.AlternateDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.AdguardDNS)
            {
                SetDNS(Helpers.NetworkHelper.AdguardDNSv4, Helpers.NetworkHelper.AdguardDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.CleanBrowsingDNS)
            {
                SetDNS(Helpers.NetworkHelper.CleanBrowsingDNSv4, Helpers.NetworkHelper.CleanBrowsingDNSv6);
                return;
            }
            else if (boxDNS.Text == Constants.CleanBrowsingAdultFilterDNS)
            {
                SetDNS(Helpers.NetworkHelper.CleanBrowsingAdultDNSv4, Helpers.NetworkHelper.CleanBrowsingAdultDNSv6);
                return;
            }
        }

        private void ChkCustomDns_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomDns.Checked == true)
            {
                OptionsHelper.CurrentOptions.CustomDNS = chkCustomDns.Checked;
            }
            else
            {
                OptionsHelper.CurrentOptions.CustomDNS = chkCustomDns.Checked;
            }
            lblPresetDNS.Visible = chkCustomDns.Checked;
            label10.Visible = chkCustomDns.Checked;
            label12.Visible = chkCustomDns.Checked;
            txtDns4A.Visible = chkCustomDns.Checked;
            txtDns4B.Visible = chkCustomDns.Checked;
            txtDns6A.Visible = chkCustomDns.Checked;
            txtDns6B.Visible = chkCustomDns.Checked;
            boxDNS.Visible = !chkCustomDns.Checked;
            lblPresetDNS.Visible = !chkCustomDns.Checked;
        }
        private void linkDNSIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Clipboard.SetText(((LinkLabel)sender).Text);
            }
            catch { }
        }

        private void btnSetDns_Click(object sender, EventArgs e)
        {
            if (chkCustomDns.Checked)
            {
                ApplyCustomDNS();
            }
            else
            {
                ApplySelectedDNS();
            }
        }

        private void btnOpenNetwork_Click(object sender, EventArgs e)
        {
            Process.Start("NCPA.cpl");
        }
        private void DisplayCurrentDNS()
        {
            if (boxAdapter.Items.Count <= 0) return;
            if (boxAdapter.SelectedIndex <= -1) return;

            _currentDNS = Helpers.NetworkHelper.GetDNSFromNetworkAdapter(Helpers.NetworkHelper.NetworkAdapters[boxAdapter.SelectedIndex]).ToArray();

            if (_currentDNS == null) return;
            if (_currentDNS.Length == 0) return;

            try
            {
                if (_currentDNS.Length == 1)
                {
                    linkDNSv4.Text = _currentDNS[0];
                }
                else if (_currentDNS.Length == 2)
                {
                    linkDNSv4.Text = _currentDNS[0];
                    linkDNSv4A.Text = _currentDNS[1];
                }
                else if (_currentDNS.Length == 3)
                {
                    linkDNSv6.Text = _currentDNS[0];
                    linkDNSv4.Text = _currentDNS[1];
                    linkDNSv4A.Text = _currentDNS[2];
                }
                else if (_currentDNS.Length == 4)
                {
                    linkDNSv4.Text = _currentDNS[2];
                    linkDNSv4A.Text = _currentDNS[3];
                    linkDNSv6.Text = _currentDNS[0];
                    linkDNSv6A.Text = _currentDNS[1];
                }
            }
            catch { }
        }

        private void boxAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNetworkAdapterConfig();
        }
        private void flushCacheB_Click(object sender, EventArgs e)
        {
            if (EvolveMessageBox.Show("Are you sure you wish to clear the DNS cache ?\n\nThis may cause internet to disconnect for a moment.", "EvolveSettings", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EvolveUtilities.ClearDNSCache();
            }
        }
        private void btnPing_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPingInput.Text)) return;
            _pingResults = new List<PingReply>();
            listPingResults.Items.Clear();
            if (Helpers.NetworkHelper.PingHost(txtPingInput.Text) == null)
            {
                listPingResults.Items.Add(string.Format("{0} [{1}]", "HostNotFound", txtPingInput.Text));
                return;
            }
            Task pinger = new Task(() =>
            {
                btnShodan.Enabled = false;
                btnPing.Enabled = false;
                listPingResults.Items.Add(string.Format("{0}", "Pinging"));
                listPingResults.Items.Add("");
                for (int i = 0; i < 9; i++)
                {
                    // wait before each pinging
                    Thread.Sleep(1000);
                    tmpReply = Helpers.NetworkHelper.PingHost(txtPingInput.Text);

                    if (tmpReply.Address == null)
                    {
                        listPingResults.Items.Add(tmpReply.Status);
                    }
                    else
                    {
                        _pingResults.Add(tmpReply);
                        _shodanIP = _pingResults[i].Address.ToString();
                        listPingResults.Items.Add(string.Format("{0} - {1}: {2} ms - TTL: {3}", _pingResults[i].Status, "latency", _pingResults[i].RoundtripTime, _pingResults[i].Options.Ttl));
                    }
                }

                listPingResults.Items.Add("");

                // calculate statistics
                if (_pingResults.Count > 0)
                {
                    long maxLatency = _pingResults.Max(x => x.RoundtripTime);
                    long minLatency = _pingResults.Min(x => x.RoundtripTime);
                    double averageLatency = _pingResults.Average(x => x.RoundtripTime);

                    listPingResults.Items.Add(string.Format("{0} = {1}, {2} = {3}, {4} = {5:F2}", "min", minLatency, "max", maxLatency, "avg", averageLatency));
                }
                else
                {
                    listPingResults.Items.Add("Request timed out");
                }

                btnPing.Enabled = true;
                btnShodan.Enabled = true;
            });

            pinger.Start();
        }

        private void btnShodan_Click(object sender, EventArgs e)
        {
            IPAddress tryIP;
            if (IPAddress.TryParse(txtPingInput.Text, out tryIP))
            {
                Process.Start(string.Format("https://www.shodan.io/host/{0}", txtPingInput.Text));
                return;
            }

            if (!string.IsNullOrEmpty(_shodanIP))
            {
                Process.Start(string.Format("https://www.shodan.io/host/{0}", _shodanIP));
                return;
            }
        }

        private void copyB_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(_shodanIP);
            }
            catch { }
        }

        private void copyIPB_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtPingInput.Text);
            }
            catch { }
        }

        private void txtPingInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnPing.PerformClick();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (ExportDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllLines(ExportDialog.FileName, listPingResults.Items.Cast<string>());
                }
                catch (Exception ex)
                {
                    Logger.LogError("ExportResults", ex.Message, ex.StackTrace);
                    MessageBox.Show(ex.Message, "Evolve Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}