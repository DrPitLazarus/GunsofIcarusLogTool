using System;
using System.Diagnostics;
using System.Timers;

namespace GoILogWatchdog
{
    public class GameState
    {
        public bool isRunning = false;
        public Timer timer;
        private readonly string processName = App.GoIProcessName;
        private FormMain theForm;

        public GameState(FormMain theForm)
        {
            this.theForm = theForm;
            timer = new Timer()
            {
                Enabled = true,
                Interval = 2000
            };
            timer.Elapsed += Timer_Elapsed;
            GC.KeepAlive(timer);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            CheckProcess();
            Debug.WriteLine("GameState.Timer_Elapsed(): isRunning = " + isRunning);
        }

        private void CheckProcess()
        {
            // Don't need to check if it's still running. We use Process_Exited for that.
            if (isRunning) return;
            // Get array of processes with processName and return if not running.
            Process[] process = Process.GetProcessesByName(processName);
            if (process.Length == 0) return;
            // Set exited event handler and set isRunning.
            process[0].EnableRaisingEvents = true;
            process[0].Exited += new EventHandler(Process_Exited);
            isRunning = true;
            timer.Enabled = false;
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            isRunning = false;
            Debug.WriteLine("GameState.Process_Exited()");
            FileSaveResult result = App.AutosaveLog();
            if (result.Success && Config.GetBool("notify_autosave"))
            {
                this.theForm.ShowNotification(string.Format("Autosaved log as '{0}'", result.Filename));
            }
            timer.Enabled = true;
        }
    }
}
