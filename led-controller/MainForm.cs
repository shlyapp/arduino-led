using LedController.Settings;
using System;
using System.Drawing;
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

            colorDialog.FullOpen = true;

            foreach (VScrollBar bar in this.Controls.OfType<VScrollBar>())
            {
                bar.Minimum = 0;
                bar.Maximum = 255;
                bar.LargeChange = 1;
                bar.Value = 255;
                bar.Enabled = false;
            }
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {

            led.ConnectToArduino();

            if (led.IsConnected)
            {
                connectBtn.Enabled = false;
                foreach (VScrollBar bar in this.Controls.OfType<VScrollBar>())
                {
                    bar.Enabled = true;
                }
            }
        }

        private void ChangeColor(object sender, ScrollEventArgs e)
        {
            //Console.WriteLine($"R={redBar.Value}, G={greenBar.Value}, B={blueBar.Value}");
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

        private void changeColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Console.WriteLine($"{colorDialog.Color.R}, {colorDialog.Color.G}, {colorDialog.Color.B}");
            led.ChangeColor((colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
        }
    }
}
