using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace SCLIP.View.Setup
=======
namespace $safeprojectname$.View.Setup
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
{
    public partial class Agree : UserControl
    {
        public Agree()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            if (Agree_checkBox.Checked == false)
                MessageBox.Show("If you do not agree it can not be used.");
            else
                SetupForm.Switch(SetupForm.Channel.Passwd);
        }
    }
}
