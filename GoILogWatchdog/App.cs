using Microsoft.Win32;
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
        public static readonly string OutputLogPath = @"GunsOfIcarusOnline_data\output_log.txt";
        public static readonly string Title = "GoI Log Watchdog";
        public static readonly string Name = "GoILogWatchdog";
        public static readonly string ConfigFile = "config.ini";
        public static readonly string GoIProcessName = "GunsOfIcarusOnline";

        /// <summary>
        /// Returns true if GunsOfIcarusOnline.exe exists.
        /// </summary>
        /// <returns></returns>
        public static bool IsGoIValid()
        {
            return File.Exists(GoIDirectory + "GunsOfIcarusOnline.exe");
        }

        /// <summary>
        /// Creates the folder structure for the log files.
        /// </summary>
        public static void CreateFolders()
        {
            string[] list = new string[] { "autosave", "bug", "crash" };
            foreach (string folder in list)
            {
                if (!Directory.Exists(BaseDirectory + folder))
                {
                    Directory.CreateDirectory(BaseDirectory + folder);
                    Debug.WriteLine(string.Format("App.CreateFolders(): Created folder {0}.", folder));
                }
            }
        }

        public static FileSaveResult AutosaveLog()
        {
            CreateFolders();
            string filename = "output_log " + GetLogLastWrite().ToString().Replace(":", "") + ".txt";
            try
            {
                File.Copy(
                    GoIDirectory + OutputLogPath,
                    BaseDirectory + @"autosave\" + filename,
                    true
                );
                Debug.WriteLine("App.AutosaveLog(): Autosaved as " + filename);
                TrimAutosaveFiles();
                return new FileSaveResult { Success = true, Filename = filename };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //TODO: better exception handling.
                return new FileSaveResult { Success = false };
            }
        }

        /// <summary>
        /// Returns a DateTime of the last write date of the game log file.
        /// </summary>
        /// <returns></returns>
        public static DateTime GetLogLastWrite()
        {
            return File.GetLastWriteTime(GoIDirectory + OutputLogPath);
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
                    foreach (var file in directory.GetFiles().OrderByDescending(f => f.LastWriteTime)
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

        /// <summary>
        /// Copies the last saved log in autosave to the bug or crash folder.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static FileSaveResult MarkLastLogAs(string type)
        {
            CreateFolders();
            FileInfo lastLog = GetLastLog() ?? throw new FileNotFoundException("There are no logs in autosave.");
            string destPath = BaseDirectory;
            switch (type)
            {
                case "bug":
                    destPath += type;
                    break;
                case "crash":
                    destPath += type;
                    break;
                default:
                    return new FileSaveResult { Success = false, Message = "Invalid type to mark as." };
            }
            destPath += "\\";
            try
            {
                File.Copy(
                    lastLog.FullName,
                    destPath + lastLog.Name,
                    true);
                Debug.WriteLine(string.Format("App.MarkLastLogAs(): Marked \"{0}\" as {1}.", lastLog.Name, type));
                return new FileSaveResult
                {
                    Success = true,
                    Filename = lastLog.Name,
                    Type = type,
                    Message = string.Format("Marked '{0}' as {1}.", lastLog.Name, type)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //TODO: better exception handling.
                return new FileSaveResult { Success = false, Message = string.Format("Failed to mark as {0}.", type) };
            }
        }

        /// <summary>
        /// Returns the last log in autosave. Returns null if not found.
        /// </summary>
        /// <returns></returns>
        private static FileInfo GetLastLog()
        {
            var directory = new DirectoryInfo(BaseDirectory + "autosave");
            if (directory.GetFiles().Length == 0)
            {
                return null;
            }
            var file = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First();
            return file;
        }

        /// <summary>
        /// Creates or removes autorun entry in registry.
        /// </summary>
        /// <param name="enabled"></param>
        public static void SetStartOnLogin(bool enabled)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (enabled)
            {
                key.SetValue(Name, string.Format("\"{0}{1}.exe\"", BaseDirectory, Name));
            }
            else
            {
                key.DeleteValue(Name, false);
            }
        }

        /// <summary>
        /// Checks if the program is in the current user's run registry key.
        /// </summary>
        /// <returns></returns>
        public static bool CheckStartOnLogin()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (key.GetValue(Name) == null)
                return false;
            else
                return true;
        }
    }
}
