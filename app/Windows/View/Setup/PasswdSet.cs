using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.View.Setup
{
    public partial class PasswdSet : UserControl
    {
        public PasswdSet()
        {
            InitializeComponent();
        }

        /*PRIVATE*/

        
        /*EVENT DRIVE*/
        private void Next_button_Click(object sender, EventArgs e)
        {
            if(Password_textBox.Text.Length < 5)
            {
                MessageBox.Show("Password must be 5 digits or more.");
                return;
            }

            if(Password_textBox.Text != ReEnter_textBox.Text)
            {
                MessageBox.Show("The password does not match the confirmation input.");
                return;
            }



            //SETUP
            Act.Setup setup = new Act.Setup();

            setup.Save(Password_textBox.Text);

            MessageBox.Show("I have exported my password to the desktop." + Environment.NewLine + "Please print and keep it in a safe place.");

            Application.Restart();

        }




        private void View_label_MouseHover(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = '\0';
            ReEnter_textBox.PasswordChar = '\0'; 
        }

        private void View_label_MouseLeave(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = '●';
            ReEnter_textBox.PasswordChar = '●'; ;
        }
    }
}
