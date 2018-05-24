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
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            Act.InternalSystem.Config.Control control = new Act.InternalSystem.Config.Control();

            string tmp;


            if (Act.GeneralPurpose.Cipher.HashCompute(Passwd_textBox.Text,control.Load(Act.InternalSystem.Config.Control.ConfChannel.LoginSalt)) != control.Load( Act.InternalSystem.Config.Control.ConfChannel.LoginKey))
            {
                MessageBox.Show(SCLIP.Properties.Resources.login_no);
                return;
            }
            


            Act.InternalSystem.Tmp.LoginKey = Passwd_textBox.Text;

            Act.InternalSystem.Tmp.EncKey = control.Load(Act.InternalSystem.Config.Control.ConfChannel.EncKey);


            tmp = Act.GeneralPurpose.Cipher.Rdm();

            //save salt
            control.Save(tmp, Act.InternalSystem.Config.Control.ConfChannel.LoginSalt);



            //save login key
            control.Save(Act.InternalSystem.Tmp.LoginKey, Act.InternalSystem.Config.Control.ConfChannel.LoginKey);

            tmp = null;



            tmp = Act.GeneralPurpose.Cipher.Rdm();

            //save iv
            control.Save(tmp, Act.InternalSystem.Config.Control.ConfChannel.LoginIv);



            tmp = Act.GeneralPurpose.Cipher.Encrypt(Act.InternalSystem.Tmp.LoginKey, tmp, Act.InternalSystem.Tmp.EncKey);

            //save enc key
            control.Save(tmp, Act.InternalSystem.Config.Control.ConfChannel.EncKey);


            tmp = null;

            this.Close();
            
        }
    }
}
