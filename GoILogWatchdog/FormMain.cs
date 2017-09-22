﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace GoILogWatchdog
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetupComponents();
            GameState gameState = new GameState(this);
        }

        private void SetupComponents()
        {
            notifyIcon.Icon = Icon;

            labelProductName.Text = App.Title;
            labelVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();

            
            if (Config.GetBool("start_in_tray"))
                checkBoxStartInTray.Checked = true;
            else
                checkBoxNotifyStartup.Enabled = false;
            checkBoxStartInTray.CheckedChanged += SettingsCheckbox_Changed;
            if (Config.GetBool("notify_startup"))
                checkBoxNotifyStartup.Checked = true;
            checkBoxNotifyStartup.CheckedChanged += SettingsCheckbox_Changed;
            if (Config.GetBool("notify_autosave"))
                checkBoxNotifyAutosave.Checked = true;
            checkBoxNotifyAutosave.CheckedChanged += SettingsCheckbox_Changed;
        }

        public void ShowNotif(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowNotif), new object[] { message });
            }
            notifyIcon.ShowBalloonTip(3000, App.Title, message, ToolTipIcon.None);
        }

        private void SettingsCheckbox_Changed(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            string key = checkbox.Tag.ToString();
            string isChecked = checkbox.Checked.ToString().ToLower();
            Config.Set(key, isChecked);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (Config.GetBool("start_in_tray"))
            {
                this.WindowState = FormWindowState.Minimized;
                Hide();
            }
            if (Config.GetBool("notify_startup") && Config.GetBool("start_in_tray"))
            { 
                notifyIcon.ShowBalloonTip(3000, App.Title,
                    "Is running in the background.", ToolTipIcon.None);
            }
        }

        /**
         * Event: Open form from tray or balloon.
         * */
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        /*
         * Event: Minimize to tray on form resize.
         * */
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string clickedItem = e.ClickedItem.ToString();
            switch (clickedItem)
            {
                case "Exit":
                    Application.Exit();
                    break;
                case "Open":
                    Show();
                    this.WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;
            }
        }

        private void checkBoxStartInTray_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
                checkBoxNotifyStartup.Enabled = true;
            else
                checkBoxNotifyStartup.Enabled = false;
        }

        private void linkLabelGithubProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DrPitLazarus");
        }

        private void linkLabelGithubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DrPitLazarus/GunsofIcarusLogTool");
        }
    }
}
