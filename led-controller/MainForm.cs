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
        static SerialPort serialPort;
  
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
            try
            {
                serialPort = new SerialPort(Settings.connectPort, 9600);
                serialPort.Open();
                MessageBox.Show($"Успешно подключено к {serialPort.PortName}!");

                connectBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Led
    {
        static float step = 255.0f / 91.0f;

        public static int ConvertValueToPWM(float value)
        {
            value = value * step;
            return (int) value;
        }
    }
}
