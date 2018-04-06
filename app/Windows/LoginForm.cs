using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Act.Configuration.Control control = new Act.Configuration.Control();

            if (Act.GeneralPurpose.Cipher.HashCompute(Passwd_textBox.Text,control.Load(Act.Configuration.Control.TargetChannel.LoginSalt)) ==control.Load(Act.Configuration.Control.TargetChannel.LoginKey))
            {

                Act.Configuration.Tmp.LoginKey = Passwd_textBox.Text;
                
                Act.Configuration.Tmp.EncryptKey = Act.GeneralPurpose.Cipher.Decrypt(Passwd_textBox.Text, control.Load(Act.Configuration.Control.TargetChannel.LoginIv), control.Load(Act.Configuration.Control.TargetChannel.EncryptKey));

                this.Close();
            }
            else
            {
                MessageBox.Show("Password is incorrect.");
            }
        }

        private void Close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
