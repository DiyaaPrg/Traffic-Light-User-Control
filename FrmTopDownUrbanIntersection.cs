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
    public partial class FrmTopDownUrbanIntersection : Form
    {
        public FrmTopDownUrbanIntersection()
        {
            InitializeComponent();
        }

        private void FrmTopDownUrbanIntersection_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            ctrlTop_Down_Urban_Intersection1.Start();
        }
    }
}
