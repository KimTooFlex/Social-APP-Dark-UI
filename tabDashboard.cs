using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.DataViz.WinForms;
namespace SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO
{
    public partial class tabDashboard : UserControl
    {
        public tabDashboard()
        {
            if(Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();

            //theme the charts (Collor pallete)
            bunifuDataViz1.colorSet.Add(Color.FromArgb(219, 58, 108));
            bunifuDataViz1.colorSet.Add(Color.FromArgb(97, 49, 137));
        }

        private void chartDelay_Tick(object sender, EventArgs e)
        {
            //delay for our charts to render.
            chartDelay.Stop();
            renderCharts();
        }

        private void renderCharts()
        {
            //lets get a canvas to paint graphs on
            Canvas Charts = new Canvas();

            //graph 1 dataPoint
            DataPoint graph1 = new DataPoint(BunifuDataViz._type.Bunifu_spline);

            //graph 2 datapoint
            DataPoint graph2 = new DataPoint(BunifuDataViz._type.Bunifu_column);

            //sample data for datapoint 1
            graph1.addLabely("SUN", 1500);
            graph1.addLabely("MON", 1700);
            graph1.addLabely("TUE", 2300);
            graph1.addLabely("WED", 1700);
            graph1.addLabely("THU", 1900);
            graph1.addLabely("FRI", 1600);
            graph1.addLabely("SAT", 1800);

            //sample data for datapoint 2
            graph2.addLabely("SUN", 1000);
            graph2.addLabely("MON", 1200);
            graph2.addLabely("TUE", 2000);
            graph2.addLabely("WED", 1400);
            graph2.addLabely("THU", 1500);
            graph2.addLabely("FRI", 1100);
            graph2.addLabely("SAT", 1200);

            //add datapoints to one canvas
            Charts.addData(graph1);
            Charts.addData(graph2);

            //render canvas through bunifu dataviz component.
            bunifuDataViz1.Render(Charts);

        }

        private void progressBarUpdate_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            bunifuProgressBar1.Value = r.Next(0, 100);
            bunifuProgressBar2.Value = r.Next(bunifuProgressBar1.Value, 100);
            bunifuCircleProgressbar1.Value = bunifuProgressBar1.Value;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
