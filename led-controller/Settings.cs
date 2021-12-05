using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedController.Settings
{
    public class Settings
    {
        public string connectPort = "COM1";

        public void SaveToJson()
        {
            var a = JsonConvert.SerializeObject(MainForm.settings);
            File.WriteAllText("settings.json", a);
        }

        public void LoadFromJson()
        {
            try
            {
                string jsonData = File.ReadAllText("settings.json");
                MainForm.settings = JsonConvert.DeserializeObject<Settings>(jsonData);
            }
            catch (Exception)
            {

            }
        }

    }
}
