using LedController.Settings;
using System;
using System.Linq;
using System.Windows.Forms;


namespace LedController
{
    public partial class MainForm : Form
    {
        static public LedStrip led;
        
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            foreach (VScrollBar bar in this.Controls.OfType<VScrollBar>())
            {
                bar.Minimum = 0;
                bar.Maximum = 255;
                bar.LargeChange = 1;
                bar.Value = 255;
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            if (led.ConnectToArduino()) connectBtn.Enabled = false;
        }

        private void ChangeColor(object sender, ScrollEventArgs e)
        {
            Console.WriteLine($"R={redBar.Value}, G={greenBar.Value}, B={blueBar.Value}");
            led.ChangeColor((redBar.Value, greenBar.Value, blueBar.Value));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AppSettings.GetInstance().LoadFromJson();
            led = new LedStrip();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppSettings.GetInstance().AutoSave)
            {
                led.SaveColorInArduino();
            }
        }
    }
}
