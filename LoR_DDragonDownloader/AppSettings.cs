using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace LoR_DDragonDownloader
{
    public class AppSettings
    {
        public static string settingsFilePath = Environment.CurrentDirectory + "/settings.json";

        public static void CreateSettingsFile()
        {
            JObject defaultSettings = new JObject();
            defaultSettings["language"] = "en";
            SaveNewSettings(defaultSettings);
        }

        public static JObject GetCurrentSettings()
        {
            if (!File.Exists(settingsFilePath))
            {
                CreateSettingsFile();
            }

            string settingsFileContent = File.ReadAllText(settingsFilePath);
            JObject parsedSettings = JObject.Parse(settingsFileContent);
            return parsedSettings;
        }

        public static void ChangeAppLanguage(string newLanguage)
        {
            JObject settings = GetCurrentSettings();
            settings["language"] = newLanguage;
            SaveNewSettings(settings);
        }

        public static void SaveNewSettings(JObject settings)
        {
            File.WriteAllText(Environment.CurrentDirectory + "/settings.json", settings.ToString());
        }
    }
}
