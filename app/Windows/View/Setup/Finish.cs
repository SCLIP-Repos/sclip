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
    public partial class Finish : UserControl
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            $safeprojectname$.Setup.Setuped = true;

            Act.Setup setup = new Act.Setup();

            setup.FastSetup();
        
            Application.Restart();
        }
    }
}
