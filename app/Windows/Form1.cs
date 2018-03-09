using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FSys;

namespace $safeprojectname$
{
    public partial class Form1 : Form 
    {

        private static Form1UserControls.ItemControl _itemControl = new Form1UserControls.ItemControl();

        private static Form1UserControls.Login _login = new Form1UserControls.Login();

        private static Form1UserControls.Top _top = new Form1UserControls.Top();



        public Form1()
        {
            InitializeComponent();



            RegistrationForm1UserControl();



            ItemDirectory_listView.ContextMenuStrip = null;
            Item_listView.ContextMenuStrip = null;
        }



        /*INTERNAL*/

        internal static void SwitchUserControl(Enum @enum)
        {
            switch(@enum)
            {
                case Mode.Init:
                    _itemControl.Visible = false;
                    _login.Visible = false;
                    break;

                case Mode.Login:
                    SwitchUserControl(Mode.Init);
                    _login.Visible = true;
                    break;

                case Mode.ItemControl:
                    SwitchUserControl(Mode.Init);
                    _itemControl.Visible = true;
                    break;

                case Mode.Top:
                    SwitchUserControl(Mode.Init);
                    _top.Visible = true;
                    break;
            }
        }


        /*PRIVATE*/

        private void RegistrationForm1UserControl()
        {
            UserControlBase_panel.Controls.Add(_itemControl);

            UserControlBase_panel.Controls.Add(_login);

            UserControlBase_panel.Controls.Add(_top);

            SwitchUserControl(Mode.Init);
        }



        /*EVENT DRIVE*/

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!FSysDirectory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\$safeprojectname$"))
            {
                Setup setup = new Setup();

                setup.ShowDialog();
            }
            

             SwitchUserControl(Mode.Login);
            
            
        }

        private void ItemDirectory_listView_MouseDown(object sender, MouseEventArgs e)
        {
            //ItemDirectory_listView.ContextMenuStrip = this.contextMenuStrip1;

            //Item_listView.ContextMenuStrip = this.contextMenuStrip2;

        }

        private void Item_listView_MouseDown(object sender, MouseEventArgs e)
        {
            
           
        }
    }
}


/*
        private const int WM_CONTEXTMENU = 0x7B;

            protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_CONTEXTMENU:
                    break;
            }
            base.WndProc(ref m);
        }



    private void ItemDirectory_listView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if ( false)
                    ItemDirectory_listView.ContextMenu = new ContextMenu();
        }



*/
