using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SCLIP.View.SetupForm
{
    public partial class Passwd : UserControl
    {
        public Passwd()
        {
            InitializeComponent();
        }

        private void Psw_textBox_TextChanged(object sender, EventArgs e)
        {

            if (Psw_textBox.Text == RePsw_textBox.Text)

                RePsw_textBox.BackColor = Color.White;
            
            else
            
                RePsw_textBox.BackColor = Color.Red;
            
        }

        private void RePsw_textBox_TextChanged(object sender, EventArgs e)
        {
            if(Psw_textBox.Text == RePsw_textBox.Text)
                RePsw_textBox.BackColor = Color.White;
            else
                RePsw_textBox.BackColor = Color.Red;
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if(Psw_textBox.Text.Length < 5)
            {
                MessageBox.Show(Properties.Resources.setup_length_err);
                return;
            }

            if(Psw_textBox.Text != RePsw_textBox.Text)
            {
                MessageBox.Show(Properties.Resources.setup_confirmationinput_err);

                return;
            }





            Act.InternalSystem.Tmp.LoginKey = Psw_textBox.Text;

            Act.InternalSystem.Tmp.EncKey = Act.GeneralPurpose.Cipher.Rdm();





            SCLIP.SetupForm.Switch(SCLIP.SetupForm.Channel.Settings);
            
        }

        private void Back_button_Click(object sender, EventArgs e)
        {

            Psw_textBox.Text = null;

            RePsw_textBox.Text = null;

            SCLIP.SetupForm.Switch(SCLIP.SetupForm.Channel.Agree);
            
        }

      
    }
}
