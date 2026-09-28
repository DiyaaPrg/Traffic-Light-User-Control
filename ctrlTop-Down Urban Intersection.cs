using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLight.Properties;

namespace TrafficLight
{
    public partial class ctrlTop_Down_Urban_Intersection : UserControl
    {
        public enum enTrafficColor { Red = 0, Orange = 1, Green = 2 }

        public event EventHandler<TrafficLight> OnColorSelected;

        private const byte GreenTime = 20;
        private const byte RedTime  = 26;
        private const byte OrangeTime = 6;

        public struct TrafficLight
        {
            public int Time;
            public Color color;
            public Bitmap image;
        }

        private List<TrafficLight> TrafficLightsGrp1 = new List<TrafficLight>();
        private List<TrafficLight> TrafficLightsGrp2 = new List<TrafficLight>();


        public ctrlTop_Down_Urban_Intersection()
        {
            InitializeComponent();
        }

        private void ctrlTop_Down_Urban_Intersection_Load(object sender, EventArgs e)
        {
            TrafficLight RedLight = new TrafficLight() { Time = RedTime, color = Color.Red, image = Resources.Red2 };
            TrafficLight OrangeLight = new TrafficLight() { Time = OrangeTime, color = Color.Orange, image = Resources.Orange2_black_ };
            TrafficLight GreenLight = new TrafficLight() { Time = GreenTime, color = Color.Green, image = Resources.Green2_black_ };


            TrafficLightsGrp1.Add(RedLight);
            TrafficLightsGrp1.Add(OrangeLight);
            TrafficLightsGrp1.Add(GreenLight);
            TrafficLightsGrp1.Add(OrangeLight);


            TrafficLightsGrp2.Add(GreenLight);
            TrafficLightsGrp2.Add(OrangeLight);
            TrafficLightsGrp2.Add(RedLight);
            TrafficLightsGrp2.Add(OrangeLight);


        }

        public async Task Start()
        {

            while (true)
            {
                Task TaskHightToBottom = Task.Run(() => SwitchColors(TrafficLightsGrp1, pbHighToBottom));
                Task TaskLeftToRight = Task.Run(() => SwitchColors(TrafficLightsGrp2, pbLeftToRight));
                Task TaskRightToLeft = Task.Run(() => SwitchColors(TrafficLightsGrp2, pbRightToLeft));
                Task TaskBottomToHight = Task.Run(() => SwitchColors(TrafficLightsGrp1, pbBottomToHigh));


                await Task.WhenAll(TaskBottomToHight, TaskHightToBottom, TaskLeftToRight, TaskRightToLeft);
            }


        }

        private async Task SwitchColors(List<TrafficLight> TrafficLightsGrp, PictureBox pbImage)
        {

            for (int i = 0; i < TrafficLightsGrp.Count; ++i)
            {
                TrafficLight light = TrafficLightsGrp[i];

                pbImage.Image = light.image;

                for (int z = light.Time; z > 0; z--)
                {
                    await Task.Delay(1000);
                }
            }
        }


    }
}
