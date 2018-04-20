using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP
{
    public partial class ReceptionistForm : Form
    {
        private bool bl;

        private InternalSystem.Config.Control control = new InternalSystem.Config.Control();

        public ReceptionistForm()
        {
            InitializeComponent();

        }
        
        private void TmpSave()
        { 
            InternalSystem.Tmp.LoginKey = Passwd_textBox.Text;

                
            try
            {
                InternalSystem.Tmp.EncryptKey =

                    GeneralPurpose.Cipher.Decrypt(

                        Passwd_textBox.Text,

                        control.Load(InternalSystem.Config.Control.Mode.LoginIv),

                        control.Load(InternalSystem.Config.Control.Mode.EncryptKey)
                    );
            }
            catch
            {
                MessageBox.Show(Properties.Resources.login_Failure_SysErr);
                
            }
        }
             

        private void Login_button_Click(object sender, EventArgs e)
        {
            string tmp;
            
            tmp = GeneralPurpose.Cipher.HashCompute(Passwd_textBox.Text, control.Load( InternalSystem.Config.Control.Mode.LoginSalt));
            
            if(tmp == control.Load(InternalSystem.Config.Control.Mode.LoginKey))
            {
                TmpSave();

                bl = true;

                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.login_Failure);
            }
        }

        private void ReceptionistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bl == false)
                Application.Exit();
        }


        
    }
}
