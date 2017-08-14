using System;
using System.Diagnostics;
using System.IO;

namespace GunsofIcarusLogTool
{
    public static class App
    {
        // Path to exe.
        public static string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        public static string outputLogPath = @"GunsOfIcarusOnline_Data\output_log.txt";
        public static string gameFile = "GunsOfIcarusOnline.exe";
        public static string saveDataPath = @"Data\";
        // Save location for manual saved logs.
        public static string saveLogPath = saveDataPath + @"OutputLogs\";
        // Save location for autosave logs.
        public static string saveLogAutosavePath = saveDataPath + @"OutputLogs_Autosave\";

        /// <summary>
        /// Create folder structure.
        /// </summary>
        public static void CreateFolders()
        {
            string[] listOfFolders = new string[] { "Data", "Data/OutputLogs", "Data/OutputLogs_Autosave" };
            foreach (string folder in listOfFolders)
            {
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                    Debug.WriteLine(string.Format("App.CreateFolders(): Created '{0}'.", folder));
                }
            }
        }

        /// <summary>
        /// Returns true if the gameDir is valid.
        /// </summary>
        /// <returns></returns>
        public static bool GameDirIsValid()
        {
            if (File.Exists(Config.Get("gameDir") + gameFile))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Returns the output_log's last write date.
        /// </summary>
        /// <returns></returns>
        public static DateTime OutputLogLastWriteDate()
        {
            return File.GetLastWriteTime(Config.Get("gameDir") + outputLogPath);
        }

        /// <summary>
        /// Copies output_log.txt to specified location and filename. Returns true if successful.
        /// </summary>
        /// <param name="destPath">Path from baseDir and filename.</param>
        /// <returns></returns>
        public static bool CopyOutputLog(string destPath)
        {
            CreateFolders();
            try
            {
                File.Copy(
                    Config.Get("gameDir") + outputLogPath,
                    baseDir + destPath,
                    true);
                Debug.WriteLine("App.CopyOutputLog(): Copied to " + destPath);
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage("Failed to copy output_log.txt. \n\n" + ex.ToString());
                //TODO: better exception handling.
                return false;
            }
        }
    }
}
