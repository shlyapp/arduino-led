using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

using LedController;

namespace LedController.Settings
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            portBox.Items.AddRange(SerialPort.GetPortNames());  
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            MainForm.settings.connectPort = portBox.Text;

            var a = JsonConvert.SerializeObject(MainForm.settings);
            File.WriteAllText("settings.json", a);

            this.Close();  
        }
    }
}
