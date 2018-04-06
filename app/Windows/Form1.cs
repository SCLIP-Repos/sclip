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
        public Form1()
        {
            InitializeComponent();
            
        }


        internal void LoadItem()
        {
            /*
            string[] tmp = FileIO.GetAllFiles(Act.Configuration.Control.Path.SavePath);


            for (int i = 0; i < tmp.Length; i++)
                Item_listBox.Items.Add( System.IO.Path.GetFileNameWithoutExtension(tmp[i]) );*/
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(!Group.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\$safeprojectname$"))
            {
                SetupForm setupForm = new SetupForm();

                SetupForm.Switch(SetupForm.Channel.Welcome);

                setupForm.ShowDialog();
            }


            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();


            //Load item
            LoadItem();
        }


        private void New_button_Click(object sender, EventArgs e)
        {

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {

        }

        private void Delete_button_Click(object sender, EventArgs e)
        {

        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

  
    }
}
