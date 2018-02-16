using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.Form1Controls
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }


        public static void Mode(short N)
        {
            switch(N)
            {
                case 0:
                    break;

                    //Add
                case 1:
                    Mode(0);
                    break;

                    //Edit
                case 2:
                    Mode(0);
                    break;

            }
        }
    }
}
