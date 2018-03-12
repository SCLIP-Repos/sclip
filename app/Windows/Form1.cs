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
        private static View.Form1.Top _topView = new View.Form1.Top();

        private static View.Form1.ItemView _itemviewView = new View.Form1.ItemView();

        private static View.Form1.Login _loginView = new View.Form1.Login();



        public Form1()
        {
            InitializeComponent();

            View_Registration();

            View_Switch(View_Chanel.Init);
        }





        public static void View_Switch(Enum @enum)
        {
            switch(@enum)
            {
                case View_Chanel.Init:
                    _topView.Visible = false;

                    _itemviewView.Visible = false;

                    _loginView.Visible = false;

                    break;

                case View_Chanel.Top:
                    if (Act.Security.Login.LoginInfo.LoginSt == true)
                    {
                        View_Switch(View_Chanel.Init);
                        _topView.Visible = true;
                    }
                    else
                        MessageBox.Show("An unknown error occurred.");

                    break;

                case View_Chanel.ItemView:
                    View_Switch(View_Chanel.Init);

                    _itemviewView.Visible = true;

                    break;

                case View_Chanel.Login:
                    if (Act.Security.Login.LoginInfo.LoginSt == false)
                    {

                        View_Switch(View_Chanel.Init);

                        _loginView.Visible = true;
                    }
                    else
                        MessageBox.Show("An unknown error occurred.");


                    break;
                    

            }
        }




        /*PRIVATE*/
        private void View_Registration()
        {
            Base_panel.Controls.Add(_topView);

            Base_panel.Controls.Add(_itemviewView);

            Base_panel.Controls.Add(_loginView);
        }
        


        private bool isSelectDirectoryList()
        {
            if (Directory_listView.SelectedItems.Count != 0)
                return true;

            MessageBox.Show("Item is not selected.");
            return false;
        }


        private bool isSelectItemList()
        {
            if (Item_listView.SelectedItems.Count != 0)
                return true;

            MessageBox.Show("Item is not selected.");
            return false;
        }


        /*EVENT DRIVE*/

        private void Form1_Load(object sender, EventArgs e)
        {
        }





        //Directory operation
 
        private void NewDirectory_toolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void EditDirectory_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isSelectDirectoryList() == false)
                return;


        }

        private void DeleteDirectory_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelectDirectoryList() == false)
                return;


        }



        //Item operation
        private void NewItem_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void EditItem_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelectItemList() == false)
                return;
        }


        private void DeleteItem_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelectItemList() == false)
                return;
        }


    }
}
