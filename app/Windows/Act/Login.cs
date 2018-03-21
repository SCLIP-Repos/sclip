using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CipherModule.Fake;

namespace $safeprojectname$.Act
{
    class Login
    {
        public static bool LoginSt { get; private set; }

      
        public void NewLogiHash(string s)
        {

            string tmp = SimpleRandom.Create();

            //Salt
            Act.Configuration.Security.SaveOfLoginSalt(tmp);

            //key
            Act.Configuration.Security.SaveOfLoginKey(Act.GeneralPurpose.Cipher.HashCompute(s, tmp));
        }

        public void NewEncryptData(string  s)
        {
            string tmp = SimpleRandom.Create();

            //iv
            Act.Configuration.Security.SaveOfEncryptIv(tmp);


            Act.Configuration.Security.SaveOfEncryptKey(Act.GeneralPurpose.Cipher.Encrypt(s, tmp, Act.Configuration.EncryptKey));
        }

        public bool isPasswd(string s)
        {
            if(GeneralPurpose.Cipher.HashCompute(s,Configuration.Security.LoadOfLoginSalt()) == Act.Configuration.Security.LoadOfLoginKey())
            {
                Act.Configuration.LoginKey = s;

                Act.Configuration.EncryptKey = Act.GeneralPurpose.Cipher.Decrypt(s, Act.Configuration.Security.LoadOfEncryptIv(), Act.Configuration.Security.LoadOfEncryptKey());

                LoginSt = true;

                return true;
            }

            LoginSt = false;

            return false;
        }

    }
}
