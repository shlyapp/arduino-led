using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LedController
{
    public class LedStrip
    {
        private SerialPort _serialPort;
        private bool _isConnected;

        private enum ProtocolCommands
        {
            SmoothChangeColor,
            ChangeColor,
            OffLed,
            SetSpeed,
            SaveData,
            SetEffect
        }

        public enum Effects
        {
            Transfusion = 5,
            Rainbow
        }

        public bool IsConnected
        {
            get => _isConnected;
            private set => _isConnected = value;
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
            _serialPort?.WriteLine($"{ProtocolCommands.ChangeColor},{color.red},{color.green},{color.blue}");
        }

        public void SaveColorInArduino()
        {
            _serialPort?.Write($"{ProtocolCommands.SaveData}");
        }

        public void setEffect(Effects effect, int speed)
        {
            _serialPort?.Write($"{((int)effect)},{speed}");
        }

    }
}
