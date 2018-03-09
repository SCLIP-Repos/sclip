using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Sys.Configuration
{
    partial class ConfigurationControl
    {
        public partial class Security
        {

            public void Save(string s,Enum @enum)
            {
                switch(@enum)
                {
                    case Type.LoginKey:
                        break;

                    case Type.MainKey:
                        break;

                    case Type.BackupKey:
                        break;

                    case Type.LoginKeySalt:
                        break;
                }

                Sys.Configuration.Security.Default.Save();
            }
        }

        public partial class User
        {
            public void Save(bool b, Enum @enum)
            {
                switch (@enum)
                {
                    case Type.AutoUpddateCheck:
                        break;

                    case Type.AutoCleanup:
                        break;

                    case Type.SimpleView:
                        break;
                }

                Sys.Configuration.User.Default.Save();
            }
        }

        public class Cloud
        {

        }


        internal class Tmp
        {
            public static string Row_LoginKey;

            public static string Row_MainKey;

            public static string Row_BackupKey;



            public static void Clean()
            {
                Row_LoginKey = null;

                Row_MainKey = null;

                Row_BackupKey = null;
            }
        }
    }
}
