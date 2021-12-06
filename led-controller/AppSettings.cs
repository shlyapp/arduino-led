using Newtonsoft.Json;
using System;
using System.IO;

namespace LedController.Settings
{
    public class AppSettings
    {
        private static AppSettings instance;

        private AppSettings()
        {
            ConnectPort = "COM1";
            AutoSave = false;
        }

        public string ConnectPort { get; set; }

        public bool AutoSave { get; set; }

        public static AppSettings GetInstance()
        {
            if (instance == null)
                instance = new AppSettings();
            return instance;
        }

        public void SaveToJson() => File.WriteAllText("settings.json", JsonConvert.SerializeObject(this));

        public void LoadFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText("settings.json");
                instance = JsonConvert.DeserializeObject<AppSettings>(jsonData);
            }
            catch (Exception)
            {

            }
        }

    }
}
