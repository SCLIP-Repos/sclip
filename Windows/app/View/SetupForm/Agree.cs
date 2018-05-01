using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.View.SetupForm
{
    public partial class Agree : UserControl
    {
        public Agree()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if(!Agree_checkBox.Checked )
            {
                MessageBox.Show(Properties.Resources.setup_agree_err);
                return;
            }


            SCLIP.SetupForm.Switch(SCLIP.SetupForm.Channel.Passwd);
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            if(Agree_checkBox.Checked)
            {
                Agree_checkBox.Checked = false;
            }

            SCLIP.SetupForm.Switch(SCLIP.SetupForm.Channel.Welcome);
        }
    }
}
//It can not be used if you can not agree to the license.
