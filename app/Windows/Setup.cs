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
    public partial class Setup : Form
    {
        private static SetupUserControls.Welcome _welcome = new SetupUserControls.Welcome();
        


        private static bool Setuped = false;



        public Setup()
        {
            InitializeComponent();

            RegistrationSetupUserControl(); 

            SwitchUserControl(Mode.Welcome);
        }



        /*INTERNAL*/
        internal static void SwitchUserControl(Enum @enum)
        {
            switch(@enum)
            {
                case Mode.Init:
                    _welcome.Visible = false;
                    break;
                case Mode.Welcome:
                    SwitchUserControl(Mode.Init);
                    _welcome.Visible = true;
                    break;

                case Mode.Agree:
                    break;

                case Mode.InitialSetting:
                    break;

                case Mode.Finish:
                    break;
            }
        }


        /*PRIVATE*/

        private void RegistrationSetupUserControl()
        {
            Base_panel.Controls.Add(_welcome);


            SwitchUserControl(Mode.Init);
        }



        /*EVENTDRIVE*/


        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Setuped)
                Application.Exit();
        }
    }
}
