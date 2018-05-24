using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSys;

namespace SCLIP.View.SetupForm
{
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            Act.InternalSystem.Config.Control control = new Act.InternalSystem.Config.Control();

            string tmp;


            

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



            Group.Create(@"C:\Users\" + Environment.UserName + @"\Documents\SCLIP");

            SCLIP.SetupForm.Switch(SCLIP.SetupForm.Channel.Finish);


        }
    }
}
