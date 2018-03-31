/*
 
 #For View, please read 'View/README.txt'.

 Please read the readme stored in each directory.

 */

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
        private static View.Top.TopBase _topBase = new View.Top.TopBase();

        private static View.Login _login = new View.Login();
        
        
        public Form1()
        {
            InitializeComponent();

            Registration();
        }

        

        internal void Registration()
        {
            Base_panel.Controls.Add(_login);

            Base_panel.Controls.Add(_topBase);
        }


        internal static void SwitchView(Enum SelectChannel)
        {
            switch(SelectChannel)
            {
                case Channel.Init:
                    _login.Visible = false;
                    _topBase.Visible = false;
                    break;

                case Channel.Login:
                    SwitchView(Channel.Init);
                    _login.Visible = true;
                    break;

                case Channel.Top:
                    SwitchView(Channel.Init);
                    _topBase.Visible = true;
                    break;
            }
        }



        /*Event Drive*/

        private void Form1_Load(object sender, EventArgs e)
        {
            //SetupCheck

            //SwitchView(Channel.Login);

            //SwitchView(Channel.Top);
            
            
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            /*
            InternalWindow internalWindow = new InternalWindow();

            internalWindow.StartPosition = FormStartPosition.CenterParent;

            internalWindow.ShowDialog (this);
        }*/



    }
}
