using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD:app/Windows/View/Setup/Welcome.cs
namespace SCLIP.View.Setup
=======
namespace $safeprojectname$.View.Setup
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b:app/Windows/View/Setup/Welcome.cs
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            SetupForm.Switch(SetupForm.Channel.Agree);
        }
    }
}
