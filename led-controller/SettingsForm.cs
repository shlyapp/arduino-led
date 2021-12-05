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

using arduino_with_pc;

namespace led_controller
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

            Form1.settings.connectPort = portBox.Text;

            var a = JsonConvert.SerializeObject(Form1.settings);
            File.WriteAllText("settings.json", a);

            this.Close();  
        }
    }
}
