using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCLIP_CryptoModule;

namespace SCLIP.Act.Sets
{
    internal class Authentication
    {
        public void Save(string plainstr,string salt)
        {
            string tmp = SHA.SHA256(plainstr, salt);

            using(StreamWriter streamWriter = new StreamWriter(Paths.Files[0],false,Encoding.UTF8))
                streamWriter.Write(tmp +"," +salt);
            
        }

        public bool Match(string plainstr)
        {
            string tmp;

            using (StreamReader streamReader = new StreamReader(Paths.Files[0], Encoding.UTF8))
            {
                tmp = streamReader.ReadToEnd();
            }

            if(tmp.Split(',')[0] == SHA.SHA256(plainstr,tmp.Split(',')[1]))
                return true;
            

            return false;
        }
    }
}
