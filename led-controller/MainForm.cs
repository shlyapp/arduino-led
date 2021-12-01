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
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm sd = new SettingsForm();
            sd.ShowDialog();
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
