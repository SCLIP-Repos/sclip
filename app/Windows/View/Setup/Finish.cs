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

<<<<<<< HEAD
namespace SCLIP.View.Setup
=======
namespace $safeprojectname$.View.Setup
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
{
    public partial class Finish : UserControl
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            

            

            string LoginKeySalt = Act.GeneralPurpose.Cipher.Rdm();

            string LoginKeyIv = Act.GeneralPurpose.Cipher.Rdm();

            string LoginKey = Act.GeneralPurpose.Cipher.HashCompute(Act.Configuration.Tmp.LoginKey, LoginKeySalt);


            string EncKey = Act.GeneralPurpose.Cipher.Encrypt(Act.Configuration.Tmp.LoginKey, LoginKeyIv, Act.GeneralPurpose.Cipher.Rdm());


            Act.Configuration.Control control = new Act.Configuration.Control();



            control.Save(EncKey,Act.Configuration.Control.TargetChannel.EncryptKey);

            control.Save(LoginKey, Act.Configuration.Control.TargetChannel.LoginKey);

            control.Save(LoginKeySalt, Act.Configuration.Control.TargetChannel.LoginSalt);

            control.Save(LoginKeyIv, Act.Configuration.Control.TargetChannel.LoginIv);

            SetupForm.Setuped = true;


            Group.Create(Act.Configuration.Control.Path.SavePath);
            
            Application.Restart();
        }
    }
}
