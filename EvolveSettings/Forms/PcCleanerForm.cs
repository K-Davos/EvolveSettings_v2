﻿using Guna.UI2.WinForms;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EvolveSettings.Forms
{
    public partial class PcCleanerForm : Form
    {
        //WinTheme
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        bool _cleanSelectAll = true;
        List<string> _cleanPreviewList;

        public PcCleanerForm()
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

            cleanDriveB.Enabled = false;
            btnSelectAll.Enabled = false;
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
                pnlSelectionControl.FillColor = Color.White;
                pnlListCleanPreview.FillColor = Color.White;
                pnlAnalyzeClean.FillColor = Color.White;
                listCleanPreview.BackColor = Color.White;
                listCleanPreview.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                foreach (Guna2CheckBox chkbox in this.pnlSelectionControl.Controls.OfType<Guna2CheckBox>())
                {
                    chkbox.CheckedState.FillColor = themeColor;
                }
                foreach (Label label in this.pnlSelectionControl.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#212121");
                }
                lblWindows.ForeColor = Color.Black;
                lblEdge.ForeColor = Color.Black;
                lblChrome.ForeColor = Color.Black;
                lblFireFox.ForeColor = Color.Black;
                lblExplorer.ForeColor = Color.Black;
                label24.ForeColor = Color.Black;
                label25.ForeColor = Color.Black;
                lblSystem.ForeColor = Color.Black;
                lblFootprint.ForeColor = Color.Black;
                lblTitle.ForeColor = Color.Black;
            }
            else
            {
                //dark
                this.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlHeader.BackColor = ColorTranslator.FromHtml("#FF1F1F20");
                pnlSelectionControl.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlListCleanPreview.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                pnlAnalyzeClean.FillColor = ColorTranslator.FromHtml("#FF2D2D30");
                listCleanPreview.BackColor = ColorTranslator.FromHtml("#FF2D2D30");
                listCleanPreview.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                foreach (Guna2CheckBox chkbox in this.pnlSelectionControl.Controls.OfType<Guna2CheckBox>())
                {
                    chkbox.CheckedState.FillColor = themeColor;
                }
                foreach (Label label in this.pnlSelectionControl.Controls.OfType<Label>())
                {
                    label.ForeColor = ColorTranslator.FromHtml("#A2A4A5");
                }
                lblWindows.ForeColor = Color.White;
                lblEdge.ForeColor = Color.White;
                lblChrome.ForeColor = Color.White;
                lblFireFox.ForeColor = Color.White;
                lblExplorer.ForeColor = Color.White;
                label24.ForeColor = Color.White;
                label25.ForeColor = Color.White;
                lblSystem.ForeColor = Color.White;
                lblFootprint.ForeColor = Color.White;
                lblTitle.ForeColor = Color.White;
            }

            foreach (Guna2Button button in this.pnlAnalyzeClean.Controls.OfType<Guna2Button>())
            {
                button.FillColor = themeColor;
                button.ForeColor = Color.White;
            }
            lblChrome.ForeColor = Color.DimGray;
            lblWindows.ForeColor = Color.DimGray;
            lblEdge.ForeColor = Color.DimGray;
            lblExplorer.ForeColor = Color.DimGray;
            lblFireFox.ForeColor = Color.DimGray;
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

        private void cleanDriveB_Click(object sender, EventArgs e)
        {
            if (EvolveMessageBox.Show("Are you sure you want to remove all the selected files? Total disk space will be cleaned: " + lblFootprint.Text, "Pc Cleaner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CleanPC();
                EvolveMessageBox.Show("Files have been successfully deleted!");
            }
        }

        private void analyzeDriveB_Click(object sender, EventArgs e)
        {
            cleanDriveB.Enabled = true;
            btnSelectAll.Enabled = true;
            CleanHelper.PreviewSizeToBeFreed = new ByteSize(0);
            CleanHelper.PreviewCleanList.Clear();
            listCleanPreview.Items.Clear();
            PreviewCleanPC();
        }
        private void PreviewCleanPC()
        {
            try
            {
                if (checkBoxTemp.Checked) CleanHelper.PreviewTemp();
                if (checkBoxMiniDumps.Checked) CleanHelper.PreviewMinidumps();
                if (checkBoxErrorReports.Checked) CleanHelper.PreviewErrorReports();
                CleanHelper.PreviewChromeClean(chromeCache.Checked, chromeCookies.Checked, chromeHistory.Checked, chromeSession.Checked, chromePws.Checked);
                CleanHelper.PreviewFireFoxClean(firefoxCache.Checked, firefoxCookies.Checked, firefoxHistory.Checked);
                CleanHelper.PreviewEdgeClean(edgeCache.Checked, edgeCookies.Checked, edgeHistory.Checked, edgeSession.Checked);
                if (IECache.Checked) CleanHelper.PreviewInternetExplorerCache();
            }
            catch (Exception ex)
            {
                Logger.LogError("PcCleaner.CleanPC", ex.Message, ex.StackTrace);
            }
            finally
            {
                _cleanPreviewList = CleanHelper.PreviewCleanList;

                _cleanPreviewList.Sort();
                listCleanPreview.Items.AddRange(_cleanPreviewList.ToArray());

                for (int i = 0; i < listCleanPreview.Items.Count; i++)
                {
                    listCleanPreview.SetItemChecked(i, true);
                }

                GetFootprint();
            }
        }
        private void GetFootprint()
        {
            ByteSize footprint = CleanHelper.PreviewSizeToBeFreed;
            if (footprint > ByteSize.FromBytes(0)) lblFootprint.Text = footprint.ToString();
            else lblFootprint.Text = "-";
        }

        private void CleanPC()
        {
            for (int i = 0; i < listCleanPreview.CheckedItems.Count; i++)
            {
                CleanHelper.PreviewCleanList.Add(listCleanPreview.CheckedItems[i].ToString());
            }

            if (checkBoxBin.Checked) CleanHelper.EmptyRecycleBin();

            CleanHelper.Clean();

            listCleanPreview.Items.Clear();
            CleanHelper.PreviewCleanList.Clear();
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (listCleanPreview.Items.Count < 1)
            {
                foreach (System.Windows.Forms.CheckBox x in pnlSelectionControl.Controls.OfType<System.Windows.Forms.CheckBox>())
                {
                    x.Checked = !x.Checked;
                }
                return;
            }

            _cleanSelectAll = !_cleanSelectAll;
            for (int i = 0; i < listCleanPreview.Items.Count; i++)
            {
                listCleanPreview.SetItemChecked(i, _cleanSelectAll);
            }
        }
    }
}
