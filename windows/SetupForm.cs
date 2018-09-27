using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP
{
    public partial class SetupForm : Form
    {
        private static UserControls.Setup.Welcome welcomeControl;

        private static UserControls.Setup.Agree agreeControl;

        private static UserControls.Setup.Psw pswControl;

        public SetupForm()
        {
            InitializeComponent();

            Registration();

            Switch(SelectControl.Welcome);
        }


        public static void Switch(Enum @enum)
        {
            switch(@enum)
            {
                case SelectControl.Init:
                    welcomeControl.Visible = false;
                    agreeControl.Visible = false;
                    pswControl.Visible = false;
                    break;

                case SelectControl.Welcome:
                    Switch(SelectControl.Init);
                    welcomeControl.Visible = true;
                    break;

                case SelectControl.Agree:
                    Switch(SelectControl.Init);
                    agreeControl.Visible =true;
                    break;

                case SelectControl.Psw:
                    Switch(SelectControl.Init);
                    pswControl.Visible =true;
                    break;
            }
        }

        internal enum SelectControl
        {
            Init,
            Welcome,
            Agree,
            Psw
        }

        private void Registration()
        {
            welcomeControl = new UserControls.Setup.Welcome();

            agreeControl = new UserControls.Setup.Agree();

            pswControl = new UserControls.Setup.Psw();

            Base_panel.Controls.Add(welcomeControl);

            Base_panel.Controls.Add(agreeControl);

            Base_panel.Controls.Add(pswControl);
        }

    }
}
