using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.SetupUserControls
{
    public partial class InitialSetting : UserControl
    {
        public InitialSetting()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (Psw_textBox.Text != RePsw_textBox.Text)
            {
                MessageBox.Show("! Passwords do not match !");
                return;
            }

            if (Psw_textBox.Text.Length < 5)
            {
                MessageBox.Show("! Password must be 5 digits or more. !");
                return;
            }
            
           
            

        }
    }
}