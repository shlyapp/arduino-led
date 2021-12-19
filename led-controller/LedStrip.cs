using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LedController
{
    public class LedStrip
    {
        private SerialPort _serialPort;
        private int[] _rgb;

        public int[] Color
        { 
            get
            {
                return _rgb;
            }
            set
            {
                _serialPort.Write($"r{255 - _rgb[0]}");
                _serialPort.Write($"g{255 - _rgb[1]}");
                _serialPort.Write($"b{255 - _rgb[2]}");
            }
        }

        public LedStrip()
        {
            _rgb = new int[3];
        }

        public bool IsConnected { get; set; }

        public bool ConnectToArduino()
        { 
            try
            {
                _serialPort = new SerialPort(Settings.AppSettings.GetInstance().ConnectPort, 500000);
                _serialPort.Open();
                MessageBox.Show($"Успешно подключено к {_serialPort.PortName}!");

                IsConnected = true;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                IsConnected = false;

                return false;
            }
        }

        public void ChangeColor((int red, int green, int blue) color)
        {
            _serialPort.WriteLine($"{0},{color.red},{color.green},{color.blue}");
            Console.WriteLine($"{0},{255 - color.red},{255 - color.green},{255 - color.blue}");
        }

        public void SaveColorInArduino()
        {
            _serialPort.Write("s1");
        }

    }
}
