using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSys;

namespace $safeprojectname$.Act
{
    class Setup
    {
        public void Save(string s)
        {

            //Salt
            Act.Security.Configuration.Salt.Default.LoginSalt = GeneralVersatilityParts.Cipher.Random();

            Act.Security.Configuration.Salt.Default.Save();


            //LoginKey save
            Act.Security.Configuration.Key.Default.LoginKey = GeneralVersatilityParts.Cipher.HashCompute(s, Act.Security.Configuration.Salt.Default.LoginSalt);

            Act.Security.Configuration.Key.Default.Save();



            //EncryptKey
            string Key = GeneralVersatilityParts.Cipher.Random() + GeneralVersatilityParts.Cipher.Random();

            string Iv = GeneralVersatilityParts.Cipher.Random() + GeneralVersatilityParts.Cipher.Random();

            Act.Security.Configuration.Key.Default.EncryptKey =
                GeneralVersatilityParts.Cipher.Encrypt(Key, s, Iv);

            Act.Security.Configuration.Key.Default.Save();



            Act.Security.Configuration.Iv.Default.EncryptIv = Iv;

            Act.Security.Configuration.Iv.Default.Save();




            //Export
            Writer writer = new Writer();

            writer.Open(@"C:\Users\" + Environment.UserName + @"\Desktop\LoginKey.txt",Writer.Mode.Create);

            writer.Write(s);

            writer.Close();

        }

    }
}
