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

            groupBoxAbout.Text = App.Title;
            labelVersion.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            /* Update UI with current settings. */
            if (Config.GetBool("start_in_tray"))
                checkBoxStartInTray.Checked = true;
            checkBoxStartInTray.CheckedChanged += SettingsCheckbox_Changed;

            if (Config.GetBool("notify_startup"))
                checkBoxNotifyStartup.Checked = true;
            checkBoxNotifyStartup.CheckedChanged += SettingsCheckbox_Changed;

            if (Config.GetBool("notify_autosave"))
                checkBoxNotifyAutosave.Checked = true;
            checkBoxNotifyAutosave.CheckedChanged += SettingsCheckbox_Changed;

            if (App.CheckStartOnLogin())
                checkBoxStartOnLogin.Checked = true;
            checkBoxStartOnLogin.CheckedChanged += SettingsStartOnLogin_CheckedChanged;

            /* Scrolls activity text down when not visible. */
            textBoxActivity.VisibleChanged += (sender, e) =>
            {
                if (textBoxActivity.Visible)
                {
                    textBoxActivity.SelectionStart = textBoxActivity.TextLength;
                    textBoxActivity.ScrollToCaret();
                }
            };

            AppendActivityText(App.Title + " started.");
        }

        public void AppendActivityText(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendActivityText), new object[] { message });
                return;
            }
            string timestamp = DateTime.Now.ToLongTimeString();
            textBoxActivity.AppendText(string.Format("{0}> {1}\r\n", timestamp, message));
        }

        public void UpdateGameStateLabel(bool state)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(UpdateGameStateLabel), new object[] { state });
                return;
            }
            string message = "Game is ";
            if (!state)
                message += "not ";
            message += "running.";
            labelGameState.Text = message;
        }

        public void ShowNotification(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(ShowNotification), new object[] { message });
                return;
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
            AppendActivityText(string.Format("Setting \"{0}\" updated to {1}.", key, isChecked));
        }

        private void SettingsStartOnLogin_CheckedChanged(object sender, EventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox.Checked)
                App.SetStartOnLogin(true);
            else
                App.SetStartOnLogin(false);
            AppendActivityText(string.Format("Setting \"start_on_login\" updated to {0}.", checkbox.Checked.ToString().ToLower()));
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
                AppendActivityText(result.Message);
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
                AppendActivityText(result.Message);
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

        private void buttonOpenWatchdogFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(App.BaseDirectory);
        }
    }
}
