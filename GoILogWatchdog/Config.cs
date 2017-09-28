﻿using IniParser;
using IniParser.Model;
using System.Diagnostics;
using System.IO;

namespace GoILogWatchdog
{
    public static class Config
    {
        private static readonly string filename = App.BaseDirectory + App.ConfigFile;
        private static readonly string section = App.Name;

        static Config()
        {
            InitConfig();
        }

        private static void InitConfig()
        {
            if (!File.Exists(filename))
            {
                var parser = new FileIniDataParser();
                IniData newData = new IniData();
                KeyDataCollection kdc = newData[section];
                
                kdc["start_in_tray"] = "true";
                kdc["notify_startup"] = "true";
                kdc["notify_autosave"] = "true";
                kdc["autosave_limit"] = "40";

                parser.WriteFile(filename, newData);
                Debug.WriteLine("Config.InitConfig(): New config with default values.");
            }
        }

        /// <summary>
        /// Returns the value of key as string.
        /// </summary>
        /// <param name="key">Name of key.</param>
        /// <returns></returns>
        public static string Get(string key)
        {
            InitConfig();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filename);
            Debug.WriteLine(string.Format("Config.Get(): [{0}] = {1}", key, data[section][key]));
            return data[section][key];
        }

        /// <summary>
        /// Returns the value of key as bool. Returns false if invalid.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool GetBool(string key)
        {
            InitConfig();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filename);
            bool parsed = bool.TryParse(data[section][key].ToLower(), out bool result);
            if (parsed)
            {
                Debug.WriteLine(string.Format("Config.GetBool(): [{0}] = {1}", key, result));
                return result;
            }
            else
            {
                Debug.WriteLine(string.Format("Config.GetBool(): Failed to parse as bool [{0}], returning false.", key));
                return false;
            }
        }

        /// <summary>
        /// Sets or creates key to a value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set(string key, string value)
        {
            InitConfig();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(filename);
            data[section][key] = value;
            Debug.WriteLine(string.Format("Config.Set(): [{0}] = {1}", key, value));
            parser.WriteFile(filename, data);
        }
    }
}
