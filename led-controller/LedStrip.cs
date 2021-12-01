using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

using led_controller;

namespace led_controller
{
    class LedStrip
    {
        private SerialPort _serialPort;

        public LedStrip()
        {
            
        }

        public bool ConnectToArduino()
        { 
            try
            {
                _serialPort = new SerialPort(Settings.connectPort, 9600);
                _serialPort.Open();
                MessageBox.Show($"Успешно подключено к {_serialPort.PortName}!");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }
    }
}
