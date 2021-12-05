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
using System.Threading;

using LedController.Settings;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;


namespace LedController
{
    public partial class MainForm : Form
    {
        LedStrip led = new LedStrip();
        public static Settings.Settings settings = new Settings.Settings();
        
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (VScrollBar bar in this.Controls.OfType<VScrollBar>())
            {
                bar.Minimum = 0;
                bar.Maximum = 255;
                bar.LargeChange = 1;
                bar.Value = 255;
                bar.Enabled = false;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (led.ConnectToArduino())
            {
                connectBtn.Enabled = false;
                foreach (VScrollBar bar in this.Controls.OfType<VScrollBar>())
                {
                    bar.Enabled = true;
                }
            }
        }

        private void ChangeColor(object sender, ScrollEventArgs e)
        {
            Console.WriteLine($"R={redBar.Value}, G={greenBar.Value}, B={blueBar.Value}");
            led.ChangeColor((redBar.Value, greenBar.Value, blueBar.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string jsonData = File.ReadAllText("settings.json");
            settings = JsonConvert.DeserializeObject<Settings.Settings>(jsonData);
        }
    }
}
