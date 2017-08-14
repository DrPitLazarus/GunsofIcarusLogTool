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
            
        }
    }
}
