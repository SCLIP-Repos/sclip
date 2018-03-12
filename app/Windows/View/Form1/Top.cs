using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.View.Form1
{
    public partial class Top : UserControl
    {
        public Top()
        {
            InitializeComponent();
        }




        /*PRIVATE*/



        /*EVENT DRIVE*/
        private void Sets_label_Click(object sender, EventArgs e)
        {

        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            $safeprojectname$.Form1.View_Switch($safeprojectname$.Form1.View_Chanel.Login);

            Act.Security.Login.LoginInfo.Clear();

            
        }
    }
}
