using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.Form1UserControls
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }





        /*EVENT DIRVE*/

        private void Login_button_Click(object sender, EventArgs e)
        {
            string loginKey = Sys.Configuration.Security.Key.Default.LoginKey;

            string inputKey = 
                GeneralVersatilityParts.Cipher.HashCompute( 
                    Psw_textBox.Text, 
                    Sys.Configuration.Security.Salt.Default.LoginSalt);


            if(loginKey == inputKey)
            {
                Sys.Configuration.Tmp.LoginKey = Psw_textBox.Text;

                //Decrypt (enckey)
                Sys.Configuration.Tmp.EncryptKey = 
                    GeneralVersatilityParts.Cipher.Decrypt(
                        Sys.Configuration.Security.Key.Default.EncryptKey,
                        Psw_textBox.Text,
                        Sys.Configuration.Security.Iv.Default.LoginIv);




                //New salt
                string newSalt = GeneralVersatilityParts.Cipher.Random();
                


                //New hash code
                string newLoginHash = GeneralVersatilityParts.Cipher.HashCompute(Psw_textBox.Text,newSalt);



                //New iv
                string newIv = GeneralVersatilityParts.Cipher.Random();


                //new enckey encrypt
                string newEncryptKeyEncrypt =
                    GeneralVersatilityParts.Cipher.Encrypt(Sys.Configuration.Tmp.EncryptKey,
                    Psw_textBox.Text,
                    newIv);


                //save
                Sys.Configuration.Security.Salt.Default.LoginSalt = newSalt;

                Sys.Configuration.Security.Salt.Default.Save();


                Sys.Configuration.Security.Key.Default.LoginKey = newLoginHash;

                Sys.Configuration.Security.Key.Default.Save();


                Sys.Configuration.Security.Iv.Default.LoginIv = newIv;

                Sys.Configuration.Security.Iv.Default.Save();


                Sys.Configuration.Security.Key.Default.EncryptKey = newEncryptKeyEncrypt;

                Sys.Configuration.Security.Key.Default.Save();


                Form1.SwitchUserControl(Form1.Mode.Top);
            }
            else
            {
                MessageBox.Show("! Password is incorrect !");
            }
        }



        
  
    }
}
