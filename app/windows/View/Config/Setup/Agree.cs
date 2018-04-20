using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.View.Config.Setup
{
    public partial class Agree : UserControl
    {
        public Agree()
        {
            InitializeComponent();
        }

        private void NEXT_button_Click(object sender, EventArgs e)
        {
            if(Agree_checkBox1.Checked == false)
            {
                MessageBox.Show(Properties.Resources.agree_Alert);
                return;
            }
        }
    }
}
