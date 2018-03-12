using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.View.Setup
{
    public partial class Agree : UserControl
    {
        public Agree()
        {
            InitializeComponent();
        }

        /*PRIVATE*/


        /*EVENT DRIVE*/

        private void Next_button_Click(object sender, EventArgs e)
        {
            if(Agree_checkBox.Checked == false)
            {
                MessageBox.Show("You can not use it if you do not agree with the license.");
                return;
            }

            $safeprojectname$.Setup.View_Switch($safeprojectname$.Setup.View_Chanel.PasswdSet);
        }
    }
}
