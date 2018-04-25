using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.InternalSystem
{
    class Tmp
    {
        internal static string LoginKey, EncryptKey;

        internal static void Clear()
        {
            LoginKey = null;
            EncryptKey = null;
        }
    }
}
