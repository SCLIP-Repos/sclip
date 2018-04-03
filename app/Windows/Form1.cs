<<<<<<< HEAD
﻿using System;
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
            Switch(Channel.TopBase);
        }
    }
}
=======
﻿/*
 
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

namespace SCLIP
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
>>>>>>> 778e97e77ed83c077448bd98246c6db0bc3cd5ef
