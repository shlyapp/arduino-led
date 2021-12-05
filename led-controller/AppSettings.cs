using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedController.Settings
{
    public class AppSettings
    {
        private static AppSettings instance;

        private AppSettings()
        {
            ConnectPort = "COM1";
        }

        public string ConnectPort { get; set; }

        public static AppSettings getInstance()
        {
            if (instance == null)
                instance = new AppSettings();
            return instance;
        }

        public void SaveToJson()
        {
            var a = JsonConvert.SerializeObject(this);
            File.WriteAllText("settings.json", a);
        }

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
