using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CipherModule;
using CipherModule.Fake;

using FSys;

namespace $safeprojectname$.Act
{
    partial class Setup
    {

        //Tmpはパーシャルを用いて分割しています。

        public void FastSetup()
        {
            //ログインキー + Salt
            $safeprojectname$.Act.Configuration.Security.SaveOfLoginKey
            (
                Act.GeneralPurpose.Cipher.HashCompute
                (
                    Tmp.LoginKey, Tmp.LoginSalt
                )
            );



            //loginSalt
            $safeprojectname$.Act.Configuration.Security.SaveOfLoginSalt
            (
                 Tmp.LoginSalt
            );



            //EncryptKey
            $safeprojectname$.Act.Configuration.Security.SaveOfEncryptKey
            (
                Act.GeneralPurpose.Cipher.Encrypt
                (
                    Tmp.LoginKey,
                    Tmp.EncryptIv,
                    Tmp.EncryptKey
                )
            );


            //EncryptIV
            $safeprojectname$.Act.Configuration.Security.SaveOfEncryptIv
            (
                Tmp.EncryptIv
            );



            
            Act.Configuration.User.SaveOfLog(false);
            
            for(int i = 0; i < Paths.Directory.Length; i++)
                FSysDirectory.MkDir(Paths.Directory[i]);
            

        }


        public void ExportKey(string psw,bool Encode)
        {
            Writer writer = new Writer();

            writer.Open(@"C:\Users\" + Environment.UserName + @"\Desktop\$safeprojectname$.txt",Writer.Mode.Create);

            if(Encode)
                writer.Write(Convert.ToBase64String(Encoding.UTF8.GetBytes(psw)));
            else
                writer.Write(psw);


            writer.Close();

        }
        
        
    }
}
