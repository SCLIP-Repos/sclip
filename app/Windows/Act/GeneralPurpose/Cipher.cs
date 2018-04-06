using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherModule;
using CipherModule.Fake;


namespace $safeprojectname$.Act.GeneralPurpose
{
    class Cipher
    {

        private static AES aes;


        internal static string Encrypt(string Key,string Iv,string Str)
        {
            string tmp;


            aes = new AES();


            aes.SET(Key,Iv,256,"CBC");


            aes.Encyrpt(Str);

            tmp = aes.Print();

            aes.Close();

            return tmp;
        }

        internal static string Decrypt(string Key, string Iv, string Str)
        {
            string tmp;


            aes = new AES();


            aes.SET(Key, Iv, 256, "CBC");


            aes.Decrypt(Str);


            tmp = aes.Print();

            aes.Close();

            return aes.Print();
        }


        internal static string HashCompute(string Str,string Salt)
        {
            string tmp = String.Empty;

            tmp = SHA.SHA_256(Str+Salt);

            for(int i = 0; i < 5000; i++)
            {
                tmp = SHA.SHA_256(tmp + Salt);
            }

            return tmp;
        }


        internal static string Rdm()
        {
            return SimpleRandom.Create(15);
        }
        
    }
}
