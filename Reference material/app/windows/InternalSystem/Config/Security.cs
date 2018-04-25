using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSys;

namespace SCLIP.InternalSystem.Config
{
    internal class Security
    {
        


        public class Encrypt
        {

            private FileIO.Stream stream;

            private string tmp;

            
            public  void ChangeIv()
            {
                stream = new FileIO.Stream(InternalSystem.Paths.Files[1]);

                tmp = stream.Read();

                tmp = GeneralPurpose.Cipher.Decrypt(Tmp.LoginKey, tmp.Split(',')[1], tmp.Split(',')[0]);

                stream.Close();

                tmp += ',' + GeneralPurpose.Cipher.Rdm();


                stream = new FileIO.Stream(InternalSystem.Paths.Files[1]);

                stream.Write(GeneralPurpose.Cipher.Encrypt(Tmp.LoginKey,tmp.Split(',')[1],tmp.Split(',')[0]));

                stream.Close();
            }
        }

        public class Login
        {
            private FileIO.Stream stream;

            private string tmp;
            
            public  void ChangeSalt()
            {
                tmp = GeneralPurpose.Cipher.Rdm();
               
                stream = new FileIO.Stream(InternalSystem.Paths.Files[0]);

                stream.Write(GeneralPurpose.Cipher.HashCompute(Tmp.LoginKey, tmp) + ',' + tmp);

                stream.Close();
            }
      
        }

    }
}
