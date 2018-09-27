using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCLIP_CryptoModule;

namespace SCLIP.Act.Sets
{
    public class Backupcode
    {
        public void Save(string rawAuthekey,string backupcode)
        {
            string iv = Guid.NewGuid().ToString("N").Substring(16);

            AES aes = new AES();

            aes.SET(backupcode, iv);

            backupcode = aes.Encryption(rawAuthekey);


            using (StreamWriter streamWriter = new StreamWriter(Paths.Files[2], false, Encoding.UTF8))
                streamWriter.Write(backupcode + "," + iv);
            
        }

        public string Load(string backupcode)
        {
            using (StreamReader streamReader = new StreamReader(Paths.Files[2],Encoding.UTF8))
            {
                string tmp = streamReader.ReadToEnd();

                AES aes = new AES();

                aes.SET(backupcode, tmp.Split(',')[1]);
                
                tmp = aes.Decryption(tmp.Split(',')[0]);

                return tmp;
            }
        }
        
    }
}
