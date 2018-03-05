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

        private static SetupUserControls.Agree _agree = new SetupUserControls.Agree();

        private static SetupUserControls.InitialSetting _initialSetting = new SetupUserControls.InitialSetting();



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
                    _agree.Visible = false;
                    _initialSetting.Visible = false;
                    break;
                case Mode.Welcome:
                    SwitchUserControl(Mode.Init);
                    _welcome.Visible = true;
                    break;

                case Mode.Agree:
                    SwitchUserControl(Mode.Init);
                    _agree.Visible = true;
                    break;

                case Mode.InitialSetting:
                    SwitchUserControl(Mode.Init);
                    _initialSetting.Visible = true;
                    break;

                case Mode.Finish:
                    break;
            }
        }


        /*PRIVATE*/

        private void RegistrationSetupUserControl()
        {
            Base_panel.Controls.Add(_welcome);

            Base_panel.Controls.Add(_agree);

            Base_panel.Controls.Add(_initialSetting);

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
