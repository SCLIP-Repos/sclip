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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            
            Act.Configuration.Tmp.LoginKey = Passwd_textBox.Text;

            string LoginKeySalt = Act.GeneralPurpose.Cipher.Rdm();

            string LoginKeyIv = Act.GeneralPurpose.Cipher.Rdm();

            string LoginKey = Act.GeneralPurpose.Cipher.HashCompute(Act.Configuration.Tmp.LoginKey, LoginKeySalt);

            string EncKey = Act.GeneralPurpose.Cipher.Encrypt(Act.Configuration.Tmp.LoginKey, LoginKeyIv,Act.Configuration.Tmp.EncryptKey);

            Act.Configuration.Control control = new Act.Configuration.Control();

            control.Save(EncKey, Act.Configuration.Control.TargetChannel.EncryptKey);

            control.Save(LoginKey, Act.Configuration.Control.TargetChannel.LoginKey);

            control.Save(LoginKeySalt, Act.Configuration.Control.TargetChannel.LoginSalt);

            control.Save(LoginKeyIv, Act.Configuration.Control.TargetChannel.LoginIv);

            Application.Restart();
        }
    }
}
