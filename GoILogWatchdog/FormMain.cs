using System;
using System.IO;
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

            if (App.CheckStartOnLogin())
                checkBox1.Checked = true;
            checkBox1.CheckedChanged += SettingsStartOnLogin_CheckedChanged;
        }

        public void ShowNotification(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ShowNotification), new object[] { message });
            }
            notifyIcon.ShowBalloonTip(3000, App.Title, message, ToolTipIcon.None);
        }
#region General Form Events
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
         * Open form from tray.
         * */
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        /*
         * Minimize to tray on form resize.
         * */
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }
#endregion
        
#region Settings Tab Events

        private void SettingsCheckbox_Changed(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            string key = checkbox.Tag.ToString();
            string isChecked = checkbox.Checked.ToString().ToLower();
            Config.Set(key, isChecked);
        }

        private void checkBoxStartInTray_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
                checkBoxNotifyStartup.Enabled = true;
            else
                checkBoxNotifyStartup.Enabled = false;
        }

        private void SettingsStartOnLogin_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
                App.SetStartOnLogin(true);
            else
                App.SetStartOnLogin(false);
        }
#endregion

#region About Tab Events
        private void linkLabelGithubProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DrPitLazarus");
        }

        private void linkLabelGithubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DrPitLazarus/GunsofIcarusLogTool");
        }
#endregion

#region Context Menu Events

        private void toolStripMenuItemBug_Click(object sender, EventArgs e)
        {
            try
            {
                FileSaveResult result = App.MarkLastLogAs("bug");
                ShowNotification(result.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItemCrash_Click(object sender, EventArgs e)
        {
            try
            {
                FileSaveResult result = App.MarkLastLogAs("crash");
                ShowNotification(result.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
#endregion
    }
}
