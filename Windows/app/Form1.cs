using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSys;

namespace SCLIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Group.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\SCLIP"))
            {
                SetupForm setupForm = new SetupForm();

                setupForm.ShowDialog();

                Application.Restart();
            }



            ReceptionistForm receptionistForm = new ReceptionistForm();

            receptionistForm.ShowDialog();
            
        }
    }
}
