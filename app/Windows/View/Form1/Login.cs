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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }


        /*PRIVATE*/



        /*EVENT DRIVE*/

        private void Login_button_Click(object sender, EventArgs e)
        {
            Act.Security.Login login = new Act.Security.Login();

            if (login.Try(Psw_textBox.Text) == true)
            {
                Psw_textBox.Text = null;

                $safeprojectname$.Form1.View_Switch($safeprojectname$.Form1.View_Chanel.Top);
            }
            else
            {
                MessageBox.Show("The password is incorrect.");
                return ;
            }
                

        }
    }
}
