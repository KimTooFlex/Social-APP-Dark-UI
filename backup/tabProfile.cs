using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO
{
    public partial class tabProfile : UserControl
    {
        public tabProfile()
        {
            if(Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            bunifuSeparator1.Visible = false;
            bunifuSeparator1.Left = ((Control)sender).Left;
            bunifuSeparator1.Width = ((Control)sender).Width;
            bunifuTransition1.ShowSync(bunifuSeparator1);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            tabProfileInfo1.BringToFront();
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            tabPrivacySetting1.BringToFront();
        }
    }
}
