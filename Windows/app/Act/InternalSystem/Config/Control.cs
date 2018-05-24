using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherModule;


namespace SCLIP.Act.InternalSystem.Config
{
    partial class Control
    {
        
        
        public void Save(string str,Enum Conf)
        {

            switch(Conf)
            {
                case ConfChannel.EncKey:
                    Config.Security.Default.EncryptKey =  GeneralPurpose.Cipher.Encrypt(Tmp.LoginKey, Load(ConfChannel.LoginIv), Tmp.EncKey);
                    Config.Security.Default.Save();
                    break;

                case ConfChannel.LoginKey:
                    Config.Security.Default.LoginKey = GeneralPurpose.Cipher.HashCompute(str, Load(ConfChannel.LoginSalt));
                    Config.Security.Default.Save();
                    break;

                case ConfChannel.LoginSalt:
                    Config.Security.Default.LoginSalt = str;
                    Config.Security.Default.Save();
                    break;

                case ConfChannel.LoginIv:
                    Config.Security.Default.LoginIv = str;
                    Config.Security.Default.Save();
                    break;
            }
            
        }

        public string Load(Enum Conf)
        {
            switch (Conf)
            {
                case ConfChannel.EncKey:
                    
                    return GeneralPurpose.Cipher.Decrypt(Tmp.LoginKey, Load(ConfChannel.LoginIv), Config.Security.Default.EncryptKey); ;

                case ConfChannel.LoginKey:
                    return Config.Security.Default.LoginKey;

                case ConfChannel.LoginSalt:
                    return Config.Security.Default.LoginSalt;

                case ConfChannel.LoginIv:
                    return Config.Security.Default.LoginIv;

                default:
                    return null;
            }
        }
        
    }
    
}
