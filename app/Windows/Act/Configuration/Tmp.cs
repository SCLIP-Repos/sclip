using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Act.Configuration
{
    class Tmp
    {
        internal static string LoginKey;

        internal static string EncryptKey;

        internal static void Clear()
        {
            LoginKey = null;

            EncryptKey = null;
        }
    }
}
