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
    public partial class SetupForm : Form
    {
        internal static bool Setuped = false;


        private static View.Setup.Welcome _welcomeView;

        private static View.Setup.Agree _agreeView;

        private static View.Setup.Passwd _passwdView;

        private static View.Setup.Finish _finishView;




        public SetupForm()
        {
            InitializeComponent();

            Registration();
        }




        internal static void Switch(Enum SelectChannel)
        {
            switch(SelectChannel)
            {
                case Channel.Init:
                    _welcomeView.Visible = false;
                    _agreeView.Visible = false;
                    _passwdView.Visible = false;
                    _finishView.Visible = false;
                    break;

                case Channel.Welcome:
                    Switch(Channel.Init);
                    _welcomeView.Visible = true;
                    break;

                case Channel.Agree:
                    Switch(Channel.Init);
                    _agreeView.Visible = true;
                    break;

                case Channel.Passwd:
                    Switch(Channel.Init);
                    _passwdView.Visible = true;
                    break;

                case Channel.Finish:
                    Switch(Channel.Init);
                    _finishView.Visible = true;
                    break;
            }
        }



        private void Registration()
        {
            _welcomeView = new View.Setup.Welcome();

            _agreeView = new View.Setup.Agree();

            _passwdView = new View.Setup.Passwd();

            _finishView = new View.Setup.Finish();

            Base_panel.Controls.Add(_welcomeView);

            Base_panel.Controls.Add(_agreeView);

            Base_panel.Controls.Add(_passwdView);

            Base_panel.Controls.Add(_finishView);
        }


        private void SetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Setuped)
                Application.Exit();
        }
    }
}

//720, 385