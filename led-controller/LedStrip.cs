using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LedController
{
    public class LedStrip
    {
        private SerialPort _serialPort;
        private bool _isConnected;

        public bool IsConnected
        {
            get
            {
                return !(_serialPort is null);
            }
            set
            {
                _isConnected = value;
            }
        }

        public void ConnectToArduino()
        { 
            try
            {
                _serialPort = new SerialPort(Settings.AppSettings.GetInstance().ConnectPort, 500000);
                _serialPort.Open();
                MessageBox.Show($"Успешно подключено к {_serialPort.PortName}!");

                IsConnected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                IsConnected = false;
            }
        }

        public void ChangeColor((int red, int green, int blue) color)
        {
            _serialPort.WriteLine($"{0},{color.red},{color.green},{color.blue}");
        }

        public void SaveColorInArduino()
        {
            _serialPort?.Write("s1");
        }

    }
}
