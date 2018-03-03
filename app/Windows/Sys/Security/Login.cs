using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSys;
using CipherModule;


namespace $safeprojectname$.Sys.Security
{
    class Login
    {
        public bool TryLogging(string Psw)
        {
            string Tmp,Salt;



            Reader reader = new Reader();


            //Read Psw
            reader.Open(Paths.File[0]);
            
            Tmp = GeneralVersatilityParts.Encoder.Decode(reader.Read());
            
            reader.Close();


            //Read Salt
            reader.Open(Paths.File[2]);

            Salt = GeneralVersatilityParts.Encoder.Decode(reader.Read());

            reader.Close();



            //Hash
            GeneralVersatilityParts.Cipher.HashCompute(Psw, Salt.Split(',')[0]);


            //Check
            if (Tmp.Split(',')[0] == GeneralVersatilityParts.Cipher.Print)
                return true;
            

            return false;
        }


    }
}
