using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CipherModule.Fake;

namespace $safeprojectname$
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }



        

        /* イベントドライブ */

        private void Login_button_Click(object sender, EventArgs e)
        {
            Act.Login login = new Act.Login();

            if(login.isPasswd(Passwd_textBox.Text))
            {
                login.NewLogiHash(Passwd_textBox.Text);

                login.NewEncryptData(Passwd_textBox.Text);

                this.Close();
            }
            else
                MessageBox.Show("Password is incorrect.");


        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Act.Login.LoginSt == false)
                Application.Exit();
        }
    }
}
