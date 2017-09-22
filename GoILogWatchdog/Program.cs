using System;
using System.Windows.Forms;

namespace GoILogWatchdog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mutex = new System.Threading.Mutex(true, App.Name + "DrPitLazarus", 
                out bool isFirstInstance);

            if (!isFirstInstance)
            {
                MessageBox.Show(App.Title + " is already running.\n" +
                    "Try looking in the system tray or in task manager.",
                    App.Title + " is already running", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (App.IsGoIValid())
            {
                Application.Run(new FormMain());
            }
            else
            {
                MessageBox.Show("Could not find the game file (GunsOfIcarusOnline.exe). \n" +
                    "Please make sure the folder of this program is in the root of the " +
                    "'Guns Of Icarus Online' folder and try again.\n\n" +
                    "Expected Location:\n" +
                    "..\\steamapps\\common\\Guns Of Icarus Online\\GoILogWatchdog\\\n\n" +
                    "Current Location:\n" +
                    App.BaseDirectory,
                    "Could not find game file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            GC.KeepAlive(mutex);
        }
    }
}
