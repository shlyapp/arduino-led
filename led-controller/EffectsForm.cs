using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LedController.LedStrip;

namespace LedController
{
    public partial class EffectsForm : Form
    {
        public EffectsForm()
        {
           
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Effects_Load(object sender, EventArgs e)
        {
            //effectsBox.Items.AddRange((object[]) Enum.GetValues(typeof(LedStrip.Effects)));
            effectsBox.DataSource = Enum.GetValues(typeof(LedStrip.Effects));
        }

        private void setBtn_Click(object sender, EventArgs e)
        {
            MainForm.led.setEffect((LedStrip.Effects) Enum.Parse(typeof(LedStrip.Effects), effectsBox.Text, true), int.Parse(speedBox.Text));
            this.Close();
        }
    }
}
