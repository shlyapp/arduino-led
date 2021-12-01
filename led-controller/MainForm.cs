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

using led_controller;

namespace arduino_with_pc
{
    public partial class Form1 : Form
    {
        LedStrip led = new LedStrip();
  
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (led.ConnectToArduino()) connectBtn.Enabled = false;
        }
    }
}
