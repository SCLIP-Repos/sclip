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

        private static View.SetupForm.Welcome _welcomeView;

        private static View.SetupForm.Agree _agreeView;

        private static View.SetupForm.Passwd _passwdView;

        private static View.SetupForm.Setting _settingView;

        private static View.SetupForm.Finish _finishView;



        public SetupForm()
        {
            InitializeComponent();

            Registration();
        }

        internal static void Switch(Enum @enum)
        {
            switch(@enum)
            {
                case Channel.Init:
                    _welcomeView.Visible = false;
                    _agreeView.Visible = false;
                    _passwdView.Visible = false;
                    _settingView.Visible = false;
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

                case Channel.Settings:
                    Switch(Channel.Init);
                    _settingView.Visible = true;
                    break;

                case Channel.Finish:
                    Switch(Channel.Init);
                    _finishView.Visible = true;
                    break;
            }
        }

        private  void Registration()
        {
            _welcomeView = new View.SetupForm.Welcome();

            _agreeView = new View.SetupForm.Agree();

            _passwdView = new View.SetupForm.Passwd();

            _settingView = new View.SetupForm.Setting();

            _finishView = new View.SetupForm.Finish();

            Base_panel.Controls.Add(_welcomeView);

            Base_panel.Controls.Add(_agreeView);

            Base_panel.Controls.Add(_passwdView);

            Base_panel.Controls.Add(_settingView);

            Base_panel.Controls.Add(_finishView);
        }


        private void SetupForm_Load(object sender, EventArgs e)
        {
            Switch(Channel.Welcome);
        }
    }
}
