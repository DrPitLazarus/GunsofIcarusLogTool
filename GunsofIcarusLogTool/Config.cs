using IniParser;
using IniParser.Model;
using System;
using System.Diagnostics;
using System.IO;

namespace GunsofIcarusLogTool
{
    public static class Config
    {
        private static readonly string file = "config.ini";
        private static readonly string section = "GOILogTool";

        static Config()
        {
            InitConfig();
        }

        /// <summary>
        /// Creates config file and set default values.
        /// </summary>
        public static void InitConfig()
        {
            if (!File.Exists(file))
            {
                var parser = new FileIniDataParser();
                IniData newData = new IniData();
                KeyDataCollection kdc = newData[section];

                kdc["autosave"] = "disabled";
                kdc["gameDir"] = @"C:\Program Files (x86)\Steam\steamapps\common\Guns of Icarus Online\";
                kdc["minimizeToTray"] = "false";

                parser.WriteFile(file, newData);
                Debug.WriteLine("Config.InitConfig(): New config with default values.");
            }
        }

        /// <summary>
        /// Returns the config data.
        /// </summary>
        /// <returns></returns>
        public static IniData GetConfigData()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(file);
            return data;
        }

        /// <summary>
        /// Deletes the config file.
        /// </summary>
        public static void DeleteConfig()
        {
            // Delete the config file if it exists.
            if (File.Exists(file))
            {
                try
                {
                    File.Delete(file);
                    Debug.WriteLine("Config.DeleteConfig(): Deleted config file.");
                }
                catch (Exception ex)
                {
                    ErrorMessage.ShowErrorMessage("Failed to delete " + file + ". \n\n" + ex.ToString());
                }

            }
        }

        /// <summary>
        /// Gets the value for requested key.
        /// </summary>
        /// <param name="key">Name of key.</param>
        /// <returns></returns>
        public static string Get(string key)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(file);
            Debug.WriteLine(string.Format("Config.Get(): '{0}' = '{1}'", key, data[section][key]));
            return data[section][key];
        }

        /// <summary>
        /// Sets/creates key to a value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set(string key, string value)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(file);
            data[section][key] = value;
            Debug.WriteLine(string.Format("Config.Set(): '{0}' = '{1}'", key, value));
            parser.WriteFile(file, data);
        }
    }
}
