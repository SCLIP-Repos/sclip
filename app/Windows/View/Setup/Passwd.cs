using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSys;

namespace SCLIP.View.Setup
{
    public partial class Passwd : UserControl
    {
        public Passwd()
        {
            InitializeComponent();
        }


        private void Next_button_Click(object sender, EventArgs e)
        {
            if(Passwd_textBox.Text.Length < 5)
            {
                MessageBox.Show("Please make it more than 5 digests.");
                return;
            }

            if(Passwd_textBox.Text != ReEnter_textBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if(EP_checkBox.Checked == true)
            {
                MessageBox.Show("Export the password to the desktop. Please keep it secure.");
                
                string tmp = @"C:\Users\" + Environment.UserName + @"\Desktop\SCLIP Password.txt";

                FileIO.Create(tmp);
                

                FileIO.Stream stream = new FileIO.Stream(tmp,FileIO.Stream.FileMode.Write);

                stream.Write(Passwd_textBox.Text);
                
            }


            //Tmp Save
            Act.Configuration.Tmp.LoginKey = Passwd_textBox.Text;

            
            SetupForm.Switch(SetupForm.Channel.Finish);

        }
    }
}
