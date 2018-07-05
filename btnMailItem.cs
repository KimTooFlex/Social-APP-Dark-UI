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
    public partial class btnMailItem : UserControl
    {
        public btnMailItem()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get
            {
                return lblFirstName.Text;
            }

            set
            {
                lblFirstName.Text = value;
            }
        }
        public string Email
        {
            get
            {
                return lblEmail.Text;
            }

            set
            {
                lblEmail.Text = value;
 
            }
        }


        public bool Active
        {
            get
            {
                return bunifuSeparator1.Visible;
            }
            set
            {
               bunifuSeparator1.Visible= value;
            }
        }

        public string Subject { get;   set; }

        //
        // Summary:
        //     Gets or sets the text associated with this control.
        //
        // Returns:
        //     The text associated with this control.
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        [SettingsBindable(true)]
        public string Body { get;   set; }

        private void lblFirstName_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
