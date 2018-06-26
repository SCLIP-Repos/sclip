using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCLIPFileIO;

namespace SCLIP.Act.Sets
{
    class Setup
    {


        internal enum Target { AuthenticationKey,AuthenticationSalt,EncKey,EncIv}

        internal void Save(string str,Enum Mode)
        {
            switch(Mode)
            {
                case Target.AuthenticationKey:
                    ConfigFiles.Authentication.Default.key = str;
                    AuthenticationSave();
                    break;

                case Target.AuthenticationSalt:
                    ConfigFiles.Authentication.Default.salt = str;
                    AuthenticationSave();
                    break;

                case Target.EncKey:
                    ConfigFiles.ItemSecurity.Default.enckey = str;
                    ItemSecuritySave();
                    break;

                case Target.EncIv:
                    ConfigFiles.ItemSecurity.Default.iv = str;
                    ItemSecuritySave();
                    break;
            }
        }
        
        

        internal string Load(Enum Mode)
        {
            switch(Mode)
            {
                case Target.AuthenticationKey:
                    return ConfigFiles.Authentication.Default.key;

                case Target.AuthenticationSalt:
                    return ConfigFiles.Authentication.Default.salt;

                case Target.EncKey:
                    return ConfigFiles.ItemSecurity.Default.enckey;

                case Target.EncIv:
                    return ConfigFiles.ItemSecurity.Default.iv;

                default:
                    return null; 
            }
        }





        private void AuthenticationSave()
        {
            ConfigFiles.Authentication.Default.Save();
        }

        private void ItemSecuritySave()
        {
            ConfigFiles.ItemSecurity.Default.Save();
        }

    }
}
