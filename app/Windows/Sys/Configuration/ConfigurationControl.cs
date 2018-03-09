using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Sys.Configuration
{
    class ConfigurationControl
    {
        public class Security
        {

        }

        public class User
        {

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
