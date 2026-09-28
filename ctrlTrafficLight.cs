using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Properties;
using static TrafficLight.ctrlTrafficLight;

namespace TrafficLight
{
    public enum enTrafficColor { Red = 0, Orange = 1, Green = 2 }

    public partial class ctrlTrafficLight : UserControl
    {
        public event EventHandler<TrafficLight> OnColorSelected;
        private enTrafficColor _CurrentLight;

         public enTrafficColor CurrentLight
        {
            set
            {
                _CurrentLight = value;

                switch(CurrentLight)
                {
                    case enTrafficColor.Red:
                        pbLight.Image = Resources.Red;
                        lblTime.ForeColor = Color.Red;
                        break;
                    case enTrafficColor.Orange:
                        pbLight.Image = Resources.Orange;
                        lblTime.ForeColor = Color.Orange;

                        break;
                    case enTrafficColor.Green:
                        pbLight.Image = Resources.Green;
                        lblTime.ForeColor = Color.Green;

                        break;

                }
            }

            get { return _CurrentLight; } 
        }
         public byte GreenTime { set; get; } = 5;
         public byte RedTime { set; get; } = 10;
         public byte OrangeTime { set; get; } = 3;


        public struct TrafficLight
        {
            public int Time;
            public Color color;
            public Bitmap image;
        }

        private List<TrafficLight> TrafficLights = new List<TrafficLight>();

        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        private void ctrlTrafficLight_Load(object sender, EventArgs e)
        {
            TrafficLight RedLight = new TrafficLight()    { Time = RedTime, color = Color.Red, image = Resources.Red};
            TrafficLight OrangeLight = new TrafficLight() { Time = OrangeTime, color = Color.Orange, image = Resources.Orange };
            TrafficLight GreenLight = new TrafficLight()  { Time = GreenTime, color = Color.Green, image = Resources.Green };


            TrafficLights.Add(RedLight);
            TrafficLights.Add(OrangeLight);
            TrafficLights.Add(GreenLight);
            TrafficLights.Add(OrangeLight);
        }

        public  async Task Start()
        {
            int index = (int)CurrentLight;

            while (true)
            {
                for(int i=index; i < TrafficLights.Count; ++i)
                {
                    await SelectColors(i);
                }

                index = 0;

            }


        }

        private async Task SelectColors(int ColorIndex)
        {

            TrafficLight light = TrafficLights[ColorIndex];

            OnColorSelected?.Invoke(this, light);

            lblTime.ForeColor = light.color;

            pbLight.Image = light.image;

            for (int i = light.Time; i > 0; i--) 
            {
                lblTime.Text = i.ToString();
                await Task.Delay(1000); 
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
