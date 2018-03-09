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
        public static string Encrypt(string Origin,string Key,string Iv)
        {
            AES aes = new AES();

            aes.SET(Key,Iv,256,"CBC");

            aes.Encyrpt(Origin);


            return aes.Print();
        }

        public static string Decrypt(string Origin, string Key, string Iv)
        {
            AES aes = new AES();

            aes.SET(Key, Iv, 256, "CBC");

            aes.Decrypt(Origin);

            return aes.Print();
        }


        public static string HashCompute(string Origin,string Salt)
        {
            string Tmp;

            Tmp = SHA.SHA_256(Origin + Salt);

            for (int i = 0; i < 3000; i++)
                Tmp = SHA.SHA_256(Tmp + (Origin + Salt));

            return Tmp;
        }

        public static string Random()
        {
            return SimpleRandom.Create(12);
        }
    }
}
