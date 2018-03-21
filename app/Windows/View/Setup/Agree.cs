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

        private void Next_button_Click(object sender, EventArgs e)
        {
            if (Agree_checkBox.Checked == true)
                $safeprojectname$.Setup.SwitchView(3);
            else
                MessageBox.Show("If you can not agree, you can not use it.");
            
        }
    }
}
