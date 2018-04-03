using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.View
{
    public partial class TopBase : UserControl
    {
        public TopBase()
        {
            InitializeComponent();
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

        private void Sets_button_Click(object sender, EventArgs e)
        {

        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            Form1.Switch(Form1.Channel.Login);
        }
    }
}
