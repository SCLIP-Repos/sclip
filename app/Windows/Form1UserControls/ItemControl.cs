using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.Form1UserControls
{
    public partial class ItemControl : UserControl
    {
        public ItemControl()
        {
            InitializeComponent();
        }



        /*EVENT DRIVE*/

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(Service_textBox.Text == String.Empty)
            {
                Service_textBox.BackColor = Color.Red;
                return;
            }

            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1.SwitchUserControl(Form1.Mode.Init);
        }

        private void Service_textBox_Click(object sender, EventArgs e)
        {
            if (Service_textBox.BackColor == Color.Red)
            {
                Service_textBox.BackColor = Color.White;
            }
        }
    }
}
