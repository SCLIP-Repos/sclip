using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Act.Security
{
    class Login
    {

        public bool Try(string s)
        {
            string load = GeneralVersatilityParts.Cipher.HashCompute(s,Configuration.Salt.Default.LoginSalt);
            
            if (load == GeneralVersatilityParts.Cipher.HashCompute(s,Configuration.Salt.Default.LoginSalt))
            {

                //Decrypt (encryptkey)
                LoginInfo.EncryptKey =
                    GeneralVersatilityParts.Cipher.Decrypt(Configuration.Key.Default.EncryptKey, s, Configuration.Iv.Default.EncryptIv);

                Configuration.Iv.Default.EncryptIv = GeneralVersatilityParts.Cipher.Random();

                Configuration.Iv.Default.Save();




                //LoginKey processing
                LoginInfo.LoginKey = s;

                Configuration.Salt.Default.LoginSalt = GeneralVersatilityParts.Cipher.Random();

                Configuration.Salt.Default.Save();
                

                Configuration.Key.Default.LoginKey = GeneralVersatilityParts.Cipher.HashCompute(s, Configuration.Salt.Default.LoginSalt);

                Configuration.Key.Default.Save();


                Form1.View_Switch(Form1.View_Chanel.Top);

                return LoginInfo.LoginSt = true;
            }


            

            return LoginInfo.LoginSt = false;
        }


        //Structure of login information
        internal struct LoginInfo
        {
            //Login result
            internal static bool LoginSt { get; set; }

            //Login raw key
            internal static string LoginKey { get; set; }

            //item etc encrypt raw key
            internal static string EncryptKey { get; set; }


            internal static void Clear()
            {
                LoginSt = false;

                LoginKey = null;

                EncryptKey = null;
            }
        }
        
    }
}
