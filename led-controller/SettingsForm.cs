using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace LedController.Settings
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            portBox.Items.AddRange(SerialPort.GetPortNames());  
        }

        private void saveBtn_Click(object sender, EventArgs e)
        { 
            AppSettings.GetInstance().ConnectPort = portBox.Text;

            AppSettings.GetInstance().SaveToJson();

            this.Close();  
        }
    }
}
