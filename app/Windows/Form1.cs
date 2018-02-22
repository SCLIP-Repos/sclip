using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {


        private static Form1UserControls.ItemControl _itemControl = new Form1UserControls.ItemControl();




        public Form1()
        {
            InitializeComponent();

            InitForm1UserControls();
            
        }






        /*REF INTERNAL ASM*/


        internal static void SwitchForm1UserControl(Enum Form1UserControlMode)
        {


            switch(Form1UserControlMode)
            {
                case Mode.Init:
                    _itemControl.Visible = false;
                    break;

                case Mode.ItemControl:
                    SwitchForm1UserControl(Mode.Init);
                    _itemControl.Visible = true;
                    break;
            }
        }




        /*PRIVATE*/
        

        private void InitForm1UserControls()
        {
            UserControlsView_panel.Controls.Add(_itemControl);

            SwitchForm1UserControl(Mode.Init);
        }




        /*EVENT DRIVE*/
        
        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchForm1UserControl(Mode.ItemControl);
        }

        

    }
}
