using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GoILogWatchdog
{
    public static class App
    {
        public static readonly string BaseDirectory = @"C:\Steam\steamapps\common\Guns of Icarus Online\GoILogWatchdog\";
        //public static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string GoIDirectory = Path.GetFullPath(Path.Combine(BaseDirectory, @"..\"));
        public static readonly string Title = "GoI Log Watchdog";
        public static readonly string Name = "GoILogWatchdog";

        /// <summary>
        /// Returns true if GunsOfIcarusOnline.exe exists.
        /// </summary>
        /// <returns></returns>
        public static bool IsGoIValid()
        {
            if (File.Exists(GoIDirectory + "GunsOfIcarusOnline.exe"))
                return true;
            else
                return false;
        }

        private static void CreateAutosaveFolder()
        {
            if (!Directory.Exists(BaseDirectory + "autosave"))
            {
                Directory.CreateDirectory(BaseDirectory + "autosave");
                Debug.WriteLine("App.CreateAutosaveFolder(): Created autosave folder.");
            }
        }

        public static AutosaveResult AutosaveLog()
        {
            CreateAutosaveFolder();
            string filename = "output_log " + LogLastWrite().ToString().Replace(":", "") + ".txt";
            try
            {
                File.Copy(
                    GoIDirectory + @"GunsOfIcarusOnline_Data\output_log.txt",
                    BaseDirectory + @"autosave\" + filename,
                    true
                );
                Debug.WriteLine("App.AutosaveLog(): Autosaved as " + filename);
                TrimAutosaveFiles();
                return new AutosaveResult { Success = true, Filename = filename };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //TODO: better exception handling.
                return new AutosaveResult { Success = false };
            }
        }

        /// <summary>
        /// Returns a DateTime of the last write date of the game log file.
        /// </summary>
        /// <returns></returns>
        public static DateTime LogLastWrite()
        {
            return File.GetLastWriteTime(GoIDirectory + @"GunsOfIcarusOnline_data\output_log.txt");
        }

        /// <summary>
        /// Deletes old autosave files if the limit is reached.
        /// </summary>
        private static void TrimAutosaveFiles()
        {
            bool parsed = Int32.TryParse(Config.Get("autosave_limit"), out int limit);
            if (parsed)
            {
                var directory = new DirectoryInfo(BaseDirectory + "autosave");
                int filesInDirectory = directory.GetFiles().Length;
                if (filesInDirectory > limit)
                {
                    int deletedCounter = 0;
                    foreach (var file in directory.GetFiles().OrderByDescending(x => x.LastWriteTime)
                        .Skip(limit))
                    {
                        file.Delete();
                        deletedCounter += 1;
                    }
                    Debug.WriteLine(string.Format("App.TrimAutosaveFiles(): Autosave limit reached. " +
                        "Limit: {0}, Count: {1}, Deleted: {2}", limit, filesInDirectory, deletedCounter));
                }
            }
        }
    }
}
