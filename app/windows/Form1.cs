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

namespace SCLIP
{
    public partial class Form1 : Form
    {
        //static View.View view;

        public Form1()
        {
            InitializeComponent();

            /*
            view = new View.View(this);

            Base_panel.Controls.Add(view);

            view.Visible = true;
w
            */

            if(!Group.Exists(InternalSystem.Paths.Directorys[0]))
            {
                ConfigForm configForm = new ConfigForm();

                configForm.ShowDialog();

            }


            ReceptionistForm receptionistForm = new ReceptionistForm();

            receptionistForm.ShowDialog();
            
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

        private void Config_button_Click(object sender, EventArgs e)
        {

        }

        private void Logout_button_Click(object sender, EventArgs e)
        {

        }
    }
}
