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


        private static Form1Controls.Add _add = new Form1Controls.Add();

        private static Form1Controls.View _view = new Form1Controls.View();


        public Form1()
        {
            InitializeComponent();

            InitControls();
        }




        /*EVENT DRIVE*/

        private void Form1_Load(object sender, EventArgs e)
        {
            Mode(2);

            DirectoryList_listView.Items.Add("Ryuji");
            ItemList_listView.Items.Add("AMAZON");
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
            Base_Panel.Controls.Add(_add);
            Base_Panel.Controls.Add(_view);

        }

        internal static void Mode(short N)
        {
            switch(N)
            {
                case 0:
                    
                    _add.Visible = false;
                    break;
                   
                    //Add
                case 1:
                    Mode(0);
                    _add.Visible = true;
                    break;

                    //Edit
                case 2:
                    Mode(0);
                    _view.Visible = true;
                    break;
                    
            }
        }

    }
}
