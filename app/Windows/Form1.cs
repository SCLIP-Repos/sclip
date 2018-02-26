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

        private static Form1UserControls.ItemControl _itemControl = new Form1UserControls.ItemControl();

        private static Form1UserControls.Login _login = new Form1UserControls.Login();


        public Form1()
        {
            InitializeComponent();

            InitForm1UserControl();

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
            }
        }


        /*PRIVATE*/

        private void InitForm1UserControl()
        {
            UserControlBase_panel.Controls.Add(_itemControl);

            UserControlBase_panel.Controls.Add(_login);

            SwitchUserControl(Mode.Init);
        }



        /*EVENT DRIVE*/

        private void Form1_Load(object sender, EventArgs e)
        {
            SwitchUserControl(Mode.Login);
            //ItemDirectory_listView.ContextMenuStrip = this.contextMenuStrip1;
            //ItemDirectory_listView.ContextMenuStrip = null;


        }

        private void ItemDirectory_listView_MouseDown(object sender, MouseEventArgs e)
        {
   
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
