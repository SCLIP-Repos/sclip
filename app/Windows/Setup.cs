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
        /*変数とクラス*/
        private static View.Setup.Welcome _welcomeView = new View.Setup.Welcome();

        private static View.Setup.Agree _agreeView = new View.Setup.Agree();

        private static View.Setup.Passwd _passwdView = new View.Setup.Passwd();

        private static View.Setup.Finish _finishView = new View.Setup.Finish();

        internal static bool Setuped = false;


        /* コンストラクタ */
        public Setup()
        {
            InitializeComponent();

            RegistrationView();
        }


        /* インターナル */


        //コントロールの切り替え
        internal static void SwitchView(short ViewNumber)
        {
            switch(ViewNumber)
            {
                case 0:
                    _welcomeView.Visible = false;
                    _agreeView.Visible = false;
                    _passwdView.Visible = false;
                    _finishView.Visible = false;
                    break;

                case 1:
                    SwitchView(0);
                    _welcomeView.Visible = true;
                    break;

                case 2:
                    SwitchView(0);
                    _agreeView.Visible = true;
                    break;

                case 3:
                    SwitchView(0);
                    _passwdView.Visible = true;
                    break;

                case 4:
                    SwitchView(0);
                    _finishView.Visible = true;
                    break;
            }
        }


        /*プライベート*/



        //コントロールの登録をします。
        private void RegistrationView()
        {
            Base_panel.Controls.Add(_welcomeView);

            Base_panel.Controls.Add(_agreeView);

            Base_panel.Controls.Add(_passwdView);

            Base_panel.Controls.Add(_finishView);
        }

        private void Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Setuped == false)
                Application.Exit();
        }
    }
}
