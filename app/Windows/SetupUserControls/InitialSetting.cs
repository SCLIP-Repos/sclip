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

namespace $safeprojectname$.SetupUserControls
{
    public partial class InitialSetting : UserControl
    {
        public InitialSetting()
        {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            if (Psw_textBox.Text != RePsw_textBox.Text)
            {
                MessageBox.Show("! Passwords do not match !");
                return;
            }

            if (Psw_textBox.Text.Length < 5)
            {
                MessageBox.Show("! Password must be 5 digits or more. !");
                return;
            }


            //Key Ecport
            MessageBox.Show("! $safeprojectname$ exported the password to the desktop. Please keep it securely by another storage method such as printing. Also, please do not lose it !");

            Writer writer = new Writer();

            writer.Open(Sys.Paths.UserDesktop + "LoginKey.txt",Writer.Mode.Create);

            writer.Write(Psw_textBox.Text);

            writer.Close();






            //Iv 
            Sys.Configuration.Security.Iv.Default.LoginIv = GeneralVersatilityParts.Cipher.Random();

            Sys.Configuration.Security.Iv.Default.Save();

            //Salt
            Sys.Configuration.Security.Salt.Default.LoginSalt = GeneralVersatilityParts.Cipher.Random();

            Sys.Configuration.Security.Salt.Default.Save();


            //Key
            string encryptKey = GeneralVersatilityParts.Cipher.Random();

            encryptKey = 
                GeneralVersatilityParts.Cipher.Encrypt(encryptKey,Psw_textBox.Text,Sys.Configuration.Security.Iv.Default.LoginIv);


            Sys.Configuration.Security.Key.Default.EncryptKey = encryptKey;

            Sys.Configuration.Security.Key.Default.LoginKey = 
                GeneralVersatilityParts.Cipher.HashCompute(Psw_textBox.Text,Sys.Configuration.Security.Salt.Default.LoginSalt);
            

            Sys.Configuration.Security.Key.Default.Save();

            Application.Restart();
        }
    }
}