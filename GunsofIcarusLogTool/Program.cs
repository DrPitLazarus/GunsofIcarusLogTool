using System;
using System.Windows.Forms;

namespace GunsofIcarusLogTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool firstInstance;
            var mutex = new System.Threading.Mutex(true, "GunsofIcarusLogTool", out firstInstance);

            if (!firstInstance)
            {
                ErrorMessage.ShowAlertMessage("Guns of Icarus Log Tool is already running.\n" +
                    "Maybe it's in the notification tray?", "Already running");
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Open form to change gameDir if not valid
            if (!App.GameDirIsValid())
            {
                FormChangeGameDir form = new FormChangeGameDir();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormMain());
                }
                else
                {
                    Application.Exit();
                }
            }
            // Open main form if no problems.
            else
            {
                Application.Run(new FormMain());
            }

            GC.KeepAlive(mutex);
        }
    }
}
