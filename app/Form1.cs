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

        private static Form1Controls.List _list = new Form1Controls.List();

        private static Form1Controls.Add _add = new Form1Controls.Add();



        public Form1()
        {
            InitializeComponent();

            InitControls();
        }




        /*EVENT DRIVE*/

        private void Form1_Load(object sender, EventArgs e)
        {
            Mode(1);
        }


        private void Add_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            
        }


        //WINDOW MODE
        private void InitControls()
        {
            Base_Panel.Controls.Add(_list);
            Base_Panel.Controls.Add(_add);
        }

        internal static void Mode(short N)
        {
            switch(N)
            {
                case 0:
                    _list.Visible = false;
                    _add.Visible = false;
                    break;

                    //List
                case 1:
                    Mode(0);
                    _list.Visible = true;
                    break;

                    //Add
                case 2:
                    _add.Visible = true;
                    Mode(0);
                    break;

                    //Edit
                case 3:
                    Mode(0);
                    break;
                    
            }
        }

    }
}
