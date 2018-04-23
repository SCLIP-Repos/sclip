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
    public partial class ReceptionistForm : Form
    {
        private bool bl;

        private FileIO.Stream stream;


        public ReceptionistForm()
        {
            InitializeComponent();

        }
         

        private void Login_button_Click(object sender, EventArgs e)
        {
            /*
            string tmp;

            try
            {
                stream = new FileIO.Stream(InternalSystem.Paths.Files[0]);

                tmp = stream.Read();


                if (tmp.Split(',')[0] != GeneralPurpose.Cipher.HashCompute(Passwd_textBox.Text, tmp.Split(',')[1]))
                {
                    MessageBox.Show(Properties.Resources.login_Failure);

                    return;
                }

            }
            catch
            {
                MessageBox.Show(Properties.Resources.login_Failure_SysErr);

                return;
            }

            bl = true;
            */

            this.Close();
        }

        private void ReceptionistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bl == false)
                Application.Exit();
        }


        
    }
}
