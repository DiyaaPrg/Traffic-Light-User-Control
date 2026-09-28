using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void  Form1_Load(object sender, EventArgs e)
        {

            ctrlTrafficLight1.OnColorSelected += (PrintColorName);

            ctrlTrafficLight1.Start();

            ctrlTrafficLight3.OnColorSelected += PrintColorName;
            ctrlTrafficLight3.Start();
        }

        private void PrintColorName(object sender, ctrlTrafficLight.TrafficLight trafficLight)
        {
            MessageBox.Show($"Color: {trafficLight.color.Name}");
        }

        private void ctrlTrafficLight2_Load(object sender, EventArgs e)
        {

        }
    }
}
