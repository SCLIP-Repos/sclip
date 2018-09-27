using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCLIP_CryptoModule;

namespace SCLIP.Act.Sets
{
    internal class Itemlock
    {
        public void Save(string autkey,string str)
        {
            string iv = Guid.NewGuid().ToString("N").Substring(16);

            using (StreamWriter streamWriter = new StreamWriter(Paths.Files[1]))
            {
                AES aes = new AES();

                aes.SET(autkey, iv);
                
                streamWriter.Write(aes.Encryption(str) + "," + iv);
            }
        }

        public string Load(string autkey)
        {
            using (StreamReader streamReader = new StreamReader(Paths.Files[1], Encoding.UTF8))
            {
                string tmp = streamReader.ReadToEnd() ;

                AES aes = new AES();

                aes.SET(autkey,tmp.Split(',')[1]);

                tmp = aes.Decryption(tmp.Split(',')[0]);

                return tmp;
            }
        }

    }
}
