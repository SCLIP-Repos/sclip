using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.Act.InternalSystem
{
    class Tmp
    {
        internal static string LoginKey;

        internal static string EncKey;

        internal static void Clear()
        {
            LoginKey = null;

            EncKey = null;
        }
    }
}
