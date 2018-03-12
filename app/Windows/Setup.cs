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
        private static View.Setup.Welcome _welcomeView = new View.Setup.Welcome();

        private static View.Setup.Agree _agreeView = new View.Setup.Agree();

        private static View.Setup.PasswdSet _passwdSetView = new View.Setup.PasswdSet();



        public Setup()
        {
            InitializeComponent();

            View_Registration();

            View_Switch(View_Chanel.Welcome);
        }



        public static void View_Switch(Enum @enum)
        {
            switch(@enum)
            {
                case View_Chanel.Init:
                    _welcomeView.Visible = false;
                    _agreeView.Visible = false ;
                    _passwdSetView.Visible = false;
                    break;

                case View_Chanel.Welcome:
                    View_Switch(View_Chanel.Init);

                    _welcomeView.Visible = true;
                    break;

                case View_Chanel.Agree:
                    View_Switch(View_Chanel.Init);

                    _agreeView.Visible = true;
                    break;

                case View_Chanel.PasswdSet:
                    View_Switch(View_Chanel.Init);

                    _passwdSetView.Visible = true;
                    break;
                    
            }
        }

        /*PRIVATE*/
        private void View_Registration()
        {
            Base_panel.Controls.Add(_welcomeView);
            Base_panel.Controls.Add(_agreeView);
            Base_panel.Controls.Add(_passwdSetView);
        }
    }
}
