using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.Form1UserControls
{
    public partial class Top : UserControl
    {
        public Top()
        {
            InitializeComponent();
        }






        private void Settings_label_Click(object sender, EventArgs e)
        {
            Sets sets = new Sets();

            sets.ShowDialog();
        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            Form1.SwitchUserControl(Form1.Mode.Login);

            Sys.Configuration.Tmp.Clear();
        }
    }
}
