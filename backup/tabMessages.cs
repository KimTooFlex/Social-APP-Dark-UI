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
    public partial class tabMessages : UserControl
    {
        public tabMessages()
        {
            if(Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }

        private void btnEditPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnMailItem1_Click(object sender, EventArgs e)
        {
            resetIndicator();

            bunifuTransition1.HideSync(pnlMsgContainer);

            btnMailItem item = ((btnMailItem)sender);
            item.Active = true;
            lblFirstName.Text = item.FirstName;
            lblEmail.Text = item.Email;
            lblSubject.Text = item.Subject;
            lblBody.Text = item.Body + "\n\n" + item.FirstName +"\n"+item.Email;
            bunifuTransition1.ShowSync(pnlMsgContainer);

        }

        void resetIndicator()
        {  

            foreach (Control item in panel1.Controls)
            {
                btnMailItem curitem = ((btnMailItem)item);
                curitem.Active = false;
            }

        }

        private void tabMessages_Load(object sender, EventArgs e)
        {

        }
    }
}
