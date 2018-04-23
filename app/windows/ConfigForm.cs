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
    public partial class ConfigForm : Form
    {

        private static View.Config.Setup.Welcome _welcomeView;

         private static View.Config.Setup.Agree _agreeView;

        private static View.Config.Setup.Passwd _passwdView;

        private static View.Config.Setup.Log _logView;

        private static View.Config.Setup.Finish _finishView;

        //psw,exportOFpsw,
        internal static string[] SetupDt = new string[10];
             


        public ConfigForm()
        {
            InitializeComponent();

            RegistrationView();
        }


        internal static void SwichView(Enum @enum)
        {
            switch(@enum)
            {
                case Channel.Init:
                    _welcomeView.Visible = false;

                    _agreeView.Visible = false;

                    _passwdView.Visible = false;

                    _logView.Visible = false;

                    _finishView.Visible = false;
                    break;

                case Channel.Welcome:
                    SwichView(Channel.Init);

                    _welcomeView.Visible = true;
                    break;

                case Channel.Agree:
                    SwichView(Channel.Init);

                    _agreeView.Visible = true;
                    break;

                case Channel.Passwd:
                    SwichView(Channel.Init);

                    _passwdView.Visible = true;
                    break;

                case Channel.Log:
                    SwichView(Channel.Init);

                    _logView.Visible = true;
                    break;

                case Channel.Finish:
                    SwichView(Channel.Init);

                    _finishView.Visible = true;
                    break;
            }
        }


        private void RegistrationView()
        {
            _welcomeView = new View.Config.Setup.Welcome();

            _agreeView = new View.Config.Setup.Agree();

            _passwdView = new View.Config.Setup.Passwd();

            _logView = new View.Config.Setup.Log();

            _finishView = new View.Config.Setup.Finish();


            Base_panel.Controls.Add(_welcomeView);

            Base_panel.Controls.Add(_agreeView);

            Base_panel.Controls.Add(_passwdView);

            Base_panel.Controls.Add(_logView);

            Base_panel.Controls.Add(_finishView);
        }



        private void ConfigForm_Load(object sender, EventArgs e)
        {
            SwichView(Channel.Welcome);
        }
    }
}
