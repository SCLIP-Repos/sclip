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
            InitItemControl();
        }



        /*REF INTERNAL ASM*/
        internal static void SwitchItemControlMode(Enum ItemControlMode)
        {
            switch(ItemControlMode)
            {
                case Mode.Init:
                    break;

                case Mode.Add:
                    break;

                case Mode.Edit:
                    break;

                case Mode.View:
                    break;
            }
        }


        /*PRIVATE*/
        private void InitItemControl()
        {
            SwitchItemControlMode(Mode.Init);
        }
            

            
        /*EVENT DRIVE*/


        private void Save_button_Click(object sender, EventArgs e)
        {
            if(ServiceName_textBox.Text == null || ServiceName_textBox.Text == String.Empty)
            {
                ServiceName_textBox.BackColor = Color.OrangeRed;
                MessageBox.Show("You must enter a service name.");
                return;
            }

            InitItemControl();
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            InitItemControl();
        }





        private void ServiceName_textBox_Click(object sender, EventArgs e)
        {
            if(ServiceName_textBox.BackColor == Color.OrangeRed)
            {
                ServiceName_textBox.BackColor = Color.White;
            }
        }

    }
}
