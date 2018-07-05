using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Bunifu.DataViz.WinForms;
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
        }

        private void chartDelay_Tick(object sender, EventArgs e)
        {
            //delay for our charts to render.
            chartDelay.Stop();
            renderCharts();
        }

        private void renderCharts()
        {
            ////lets get a canvas to paint graphs on
            //Canvas Charts = new Canvas();

            ////graph 1 dataPoint
            //DataPoint graph1 = new DataPoint(BunifuDataViz._type.Bunifu_area);

            ////graph 2 datapoint
            //DataPoint graph2 = new DataPoint(BunifuDataViz._type.Bunifu_area);

            ////sample data for datapoint 1
            //graph1.addLabely("SUN", 1500);
            //graph1.addLabely("MON", 1700);
            //graph1.addLabely("TUE", 2300);
            //graph1.addLabely("WED", 1700);
            //graph1.addLabely("THU", 1900);
            //graph1.addLabely("FRI", 1600);
            //graph1.addLabely("SAT", 1800);

            ////sample data for datapoint 2
            //graph2.addLabely("SUN", 150);
            //graph2.addLabely("MON", 170);
            //graph2.addLabely("TUE", 230);
            //graph2.addLabely("WED", 170);
            //graph2.addLabely("THU", 190);
            //graph2.addLabely("FRI", 160);
            //graph2.addLabely("SAT", 180);

            ////add datapoints to one canvas
            //Charts.addData(graph1);
            //Charts.addData(graph2);

            ////render canvas through bunifu dataviz component.
            //bunifuDataViz1.Render(Charts);

        }
    }
}
