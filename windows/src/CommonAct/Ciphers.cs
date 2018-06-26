using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherModule.Rijndael;
using CipherModule.Hash;


namespace SCLIP.CommonAct
{
    class Ciphers
    {
        private AES _aes  = new AES();

        internal string AesEncrypt(string key,string iv,string str)
        {
            _aes.SET(key, iv, 256);
            

            return _aes.Encrypt(str, AES.Mode.CBC);
        }

        internal string AesDecrypt(string key, string iv, string str)
        {
            _aes.SET(key, iv, 256);

            
            return _aes.Decrypt(str,AES.Mode.CBC);
        }

        internal string HashCode(string str,string salt) => SHA.SecureSHA.SHA256(str, salt, 4000);


    }
}
