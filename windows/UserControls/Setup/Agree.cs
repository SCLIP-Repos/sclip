using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.UserControls.Setup
{
    public partial class Agree : UserControl
    {
        public Agree()
        {
            InitializeComponent();
        }

        private void AgreeBack_button_Click(object sender, EventArgs e)
        {
            SetupForm.Switch(SetupForm.SelectControl.Welcome);


        }

        private void AgreeNext_button_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
                SetupForm.Switch(SetupForm.SelectControl.Psw);
            else
                MessageBox.Show("オープンソースライセンスによって公開されているSCLIPのライセンス内容に同意できない場合は利用することはできません", "" +
                    "", MessageBoxButtons.OK);
        }
    }
}
