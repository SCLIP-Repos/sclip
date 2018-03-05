using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.SetupUserControls
{
    public partial class Agree : UserControl
    {
        public Agree()
        {
            InitializeComponent();
        }

        private void Next1_button_Click(object sender, EventArgs e)
        {
            if(Agree_checkBox.Checked == true)
            {
                Setup.SwitchUserControl(Setup.Mode.InitialSetting);
            }
            else
            {
                MessageBox.Show("You can not use without agreeing to the license.");
            }
        }
    }
}
