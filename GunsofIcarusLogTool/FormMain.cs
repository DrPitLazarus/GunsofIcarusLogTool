using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GunsofIcarusLogTool
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetComponents();
            GameStatus gameStatus = new GameStatus();
            Debug.WriteLine("baseDir: " + App.baseDir);
        }

        /*
         * Load extra data for some components.
         * */
        private void SetComponents()
        {
            // Radiobuttons for autosave.
            switch (Config.Get("autosave"))
            {
                case "automatic":
                    radioButtonAutosaveAutomatic.Checked = true;
                    break;
                case "prompt":
                    radioButtonAutosavePrompt.Checked = true;
                    break;
                default:
                    radioButtonAutosaveDisabled.Checked = true;
                    break;
            }

            radioButtonAutosaveAutomatic.CheckedChanged += new EventHandler(radioButtonAutosave_CheckedChanged);
            radioButtonAutosavePrompt.CheckedChanged += new EventHandler(radioButtonAutosave_CheckedChanged);
            radioButtonAutosaveDisabled.CheckedChanged += new EventHandler(radioButtonAutosave_CheckedChanged);

            // Checkbox for minimizeToTray.
            if (Config.Get("minimizeToTray") == "true")
            {
                checkBoxMinimizeToTray.Checked = true;
            }
            checkBoxMinimizeToTray.CheckedChanged += new EventHandler(checkBoxMinimizeToTray_CheckedChanged);
        }

        /*
         * Button: Open output_log.txt in default text viewer.
         * */
        private void buttonOpenLog_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Config.Get("gameDir") + App.outputLogPath);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage("Failed to open output_log.txt. \n\n" + ex.ToString());
                //TODO: better exception handling.
            }
        }

        /*
         * Button: Open OutputLogs folder in explorer.
         * */
        private void buttonOpenLogFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(App.baseDir + App.saveLogPath);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage("Failed to open OutputLogs folder. \n\n" + ex.ToString());
                //TODO: better exception handling.
            }
        }

        /*
         * Button: Open SaveLog dialog.
         * */
        private void buttonSaveLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(Config.Get("gameDir") + App.outputLogPath))
            {
                FormSaveLog saveLogDialog = new FormSaveLog();
                saveLogDialog.ShowDialog();
            }
            else
            {
                ErrorMessage.ShowErrorMessage("We couldn't find output_log.txt. Try running the game first?");
                //TODO: better exception handling.
            }

        }

        /*
         * Button: Open OutputLogs_Autosave in explorer.
         * */
        private void buttonOpenLogFolderAutosave_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(App.baseDir + App.saveLogAutosavePath);
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage("Failed to open OutputLogs_Autosave folder. \n\n" + ex.ToString());
                //TODO: better exception handling.
            }
        }

        private void checkBoxMinimizeToTray_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMinimizeToTray.Checked)
                Config.Set("minimizeToTray", "true");
            else
                Config.Set("minimizeToTray", "false");
        }

        /*
         * Event: When window is being minimized, try to minimize to tray.
         * */
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized
                && Config.Get("minimizeToTray") == "true")
            {
                Hide();
                notifyIcon.Visible = true;
            }

        }

        /*
         * NotifyIcon: Open FormMain and hide tray icon.
         * */
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        /*
         * Event: Save config for autosave when radiobutton checked changed.
         * */
        private void radioButtonAutosave_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            // Ignore when radiobutton is unchecked.
            if (!rb.Checked) return;

            if (radioButtonAutosaveAutomatic.Checked)
            {
                Config.Set("autosave", "automatic");
            }
            else if (radioButtonAutosavePrompt.Checked)
            {
                Config.Set("autosave", "prompt");
            }
            else
            {
                Config.Set("autosave", "disabled");
            }
        }
    }
}
