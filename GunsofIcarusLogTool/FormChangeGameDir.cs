using System;
using System.Windows.Forms;

namespace GunsofIcarusLogTool
{
    public partial class FormChangeGameDir : Form
    {
        public FormChangeGameDir()
        {
            InitializeComponent();
        }

        /*
         * Button: Open file dialog to select game file, save path, and close form.
         * */
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = @"Select ..\steamapps\common\Guns of Icarus Online\GunsOfIcarusOnline.exe",
                Filter = "GoI Game file|GunsOfIcarusOnline.exe",
                FileName = "GunsOfIcarusOnline.exe"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string gamePath = dialog.FileName;
                // Remove exe file from path.
                gamePath = gamePath.Substring(0, gamePath.LastIndexOf('\\') + 1);
                Config.Set("gameDir", gamePath);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
