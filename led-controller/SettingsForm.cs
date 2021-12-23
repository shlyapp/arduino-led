using System;
using System.IO.Ports;
using System.Windows.Forms;

using LedController;

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
            if (portBox.Text.Length != 0)
            {
                AppSettings.GetInstance().ConnectPort = portBox.Text;
                Console.WriteLine(AppSettings.GetInstance().ConnectPort);
            }

            AppSettings.GetInstance().AutoSave = autoSaveColorBox.Checked;

            AppSettings.GetInstance().SaveToJson();
            this.Close();  
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            autoSaveColorBox.Checked = AppSettings.GetInstance().AutoSave;
            portBox.Text = AppSettings.GetInstance().ConnectPort;
        }
    }
}
