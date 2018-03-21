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

        //変数とクラス(private only)
        private static AES _aes = new AES();

        
        

        public static string Encrypt(string Key,string Iv,string s)
        {
           
            _aes.SET(Key, Iv, 256, "CBC");
            
            _aes.Encyrpt(s);

            if (_aes.Err() != null)
                return "e";


            return _aes.Print();
        }

        public static string Decrypt(string Key, string Iv, string s)
        {
            _aes.SET(Key, Iv, 256, "CBC");

            _aes.Decrypt(s);

            if (_aes.Err() != null)
                return "e";


            return _aes.Print();
        }

        public static string HashCompute(string s,string Salt)
        {
            string tmp = SHA.SHA_256(s + Salt);

            for (int i = 0; i < 3000; i++)
                tmp = SHA.SHA_256(tmp + Salt);

            return tmp;
        }
    }
}
