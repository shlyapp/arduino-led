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

namespace arduino_with_pc
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            serialPort = new SerialPort("COM3", 9600);
            try
            {
                serialPort.Open();
                consoleText.Text = "Arduino connected";
                connectBtn.Enabled = false;

                ledBtn.Enabled = true;
                redLed.Enabled = true;
                greenLed.Enabled = true;
                blueLed.Enabled = true;
                speedLed.Enabled = true;
            }
            catch (Exception ex)
            {
                consoleText.Text = ex.Message;
            }
        }

        private void ledBtn_Click(object sender, EventArgs e)
        {
            if (ledBtn.Text == "Turn on the LED")
            {
                serialPort.Write("k0");
                Thread.Sleep(200);
                ledBtn.Text = "Turn off the LED";
            }
            else
            {
                serialPort.WriteLine("0");
                Thread.Sleep(200);
                ledBtn.Text = "Turn on the LED";
            }
            
        }

        private void redLed_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort.Write("r" + Led.ConvertValueToPWM(redLed.Value).ToString());
        }

        private void greenLed_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort.Write("g" + Led.ConvertValueToPWM(greenLed.Value).ToString());
        }

        private void blueLed_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort.Write("b" + Led.ConvertValueToPWM(blueLed.Value).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ledBtn.Enabled = false;
            redLed.Enabled = false;
            greenLed.Enabled = false;
            blueLed.Enabled = false;
            speedLed.Enabled = false;
        }

        private void speedLed_Scroll(object sender, ScrollEventArgs e)
        {
            serialPort.Write("e" + Led.ConvertValueToPWM(speedLed.Value).ToString());
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
