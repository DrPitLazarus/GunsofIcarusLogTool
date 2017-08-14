using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GunsofIcarusLogTool
{
    public partial class FormSaveLog : Form
    {
        private string saveLogPath = App.saveLogPath;

        public FormSaveLog(bool autosave = false)
        {
            InitializeComponent();
            labelLastWriteDate.Text = "Last Write Timestamp: " + App.OutputLogLastWriteDate();
            if (autosave)
                saveLogPath = App.saveLogAutosavePath;
        }

        /*
         * Button: Append timestamp to rename box.
         * */
        private void buttonAppendTimestamp_Click(object sender, EventArgs e)
        {
            textBoxRename.Text += App.OutputLogLastWriteDate().ToString().Replace(':', '-');
        }

        /*
         * Button: Save the log.
         * */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Remove whitespace at end of rename.
            string rename = textBoxRename.Text.TrimEnd(' ');

            string filename = "output_log.txt";
            if (rename.Length > 0)
            {
                filename = "output_log " + rename + ".txt";
            }
            
            if (App.CopyOutputLog(saveLogPath + filename))
            {
                string fullpath = App.baseDir + saveLogPath + filename;
                if (checkBoxShowInExplorer.Checked)
                {
                    ProcessStartInfo proc = new ProcessStartInfo();
                    proc.FileName = "explorer.exe";
                    proc.Arguments = "/e, /select, \"" + fullpath + "\"";
                    Process.Start(proc);
                }

                
                this.Close();
            }
        }
    }
}
