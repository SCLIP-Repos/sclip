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
        private static View.Login _loginView = new View.Login();

        private static View.TopBase _topBaseView = new View.TopBase();


        public Form1()
        {
            InitializeComponent();
            Registration();
        }



        internal static void Switch(Enum SelectChannel)
        {
            switch(SelectChannel)
            {
                case Channel.Init:
                    _topBaseView.Visible = false;
                    _loginView.Visible = false;
                    break;

                case Channel.Login:
                    Switch(Channel.Init);
                    _loginView.Visible = true;
                    break;

                case Channel.TopBase:
                    Switch(Channel.Init);
                    _topBaseView.Visible = true;
                    break;

            }
        }


        private void Registration()
        {
            Base_panel.Controls.Add(_loginView);

            Base_panel.Controls.Add(_topBaseView);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Switch(Channel.TopBase);

            /*
            SubWindow subWindow = new SubWindow();

            subWindow.StartPosition = FormStartPosition.CenterParent;

            subWindow.ShowDialog();*/
        }
    }
}
