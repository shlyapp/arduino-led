using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LedController
{
    public class LedStrip
    {
        private SerialPort _serialPort;

        public bool IsConnected { get; set; }

        public bool ConnectToArduino()
        { 
            try
            {
                _serialPort = new SerialPort(Settings.AppSettings.GetInstance().ConnectPort, 9600);
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
            _serialPort.Write($"r{255 - color.red}");
            _serialPort.Write($"g{255 - color.green}");
            _serialPort.Write($"b{255 - color.blue}");
        }

        public void SaveColorInArduino()
        {
            _serialPort.Write("s1");
            Console.WriteLine("Успешно сохранено!");
        }

    }
}
