using System;
using System.Diagnostics;
using System.Threading;

namespace GunsofIcarusLogTool
{
    public class GameStatus
    {
        public bool isRunning = false;
        private Timer timer;
        private string processName = "GunsOfIcarusOnline";


        public GameStatus()
        {
            // Start timer
            timer = new Timer(TimerEvent, null, 0, 3000);
            GC.KeepAlive(timer);
        }

        private void TimerEvent(Object o)
        {
            CheckProcess();
            Debug.WriteLine("timer event");
            Debug.WriteLineIf(isRunning, "timer, running");
            Debug.WriteLineIf(!isRunning, "timer, not running");
        }

        /// <summary>
        /// Checks the process if it's running and set isRunning to true.
        /// </summary>
        private void CheckProcess()
        {
            // Don't need to check if it's still running. We use Game_Exited for that.
            if (isRunning) return;
            // Get array of processes with processName and return if not running.
            Process[] process = Process.GetProcessesByName(processName);
            if (process.Length == 0) return;
            // Set exited event handler and set isRunning.
            process[0].EnableRaisingEvents = true;
            process[0].Exited += new EventHandler(Process_Exited);
            isRunning = true;
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            isRunning = false;
            Debug.WriteLine("timer, exited");
            // Do something if autosave is prompt or automatic.
            switch (Config.Get("autosave"))
            {
                case "prompt":
                    FormSaveLog saveDialog = new FormSaveLog(true);
                    saveDialog.ShowDialog();
                    break;
                case "automatic":
                    string lastWriteDate = App.OutputLogLastWriteDate().ToString().Replace(':', '-');
                    App.CopyOutputLog(string.Format("{0}output_log_{1}.txt", App.saveLogAutosavePath, lastWriteDate));
                    break;
            }

        }
    }
}
