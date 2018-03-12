using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CipherModule;
using CipherModule.Fake;


namespace $safeprojectname$.GeneralVersatilityParts
{
    class Cipher
    {
        

        public static string Encrypt(string s,string Key,string Iv)
        {
            string tmp;


            AES aes = new AES();

            aes.SET(Key,Iv, 256, "CBC");

            aes.Encyrpt(s);

            tmp = aes.Print();

            aes.Close();

            return tmp;
        }

        public static string Decrypt(string s, string Key, string Iv)
        {
            string tmp;


            AES aes = new AES();

            aes.SET(Key, Iv, 256, "CBC");

            aes.Decrypt(s);

            tmp = aes.Print();

            aes.Close();

            return tmp;
        }

        public static string Random()
        {
            return SimpleRandom.Create(12);
        }

        public static string HashCompute(string s,string Salt)
        {
            string tmp = SHA.SHA_256(s + Salt);
            

            for(int i = 0; i < 3000; i++)
            {
                tmp = SHA.SHA_256(tmp + Salt);
            }
            
            return tmp;
        }
    }
}
