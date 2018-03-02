using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.GeneralVersatilityParts
{
    class Encoder
    {
        public static string Encode(string OriginStr)
        {
            byte[] TmpBytes = Encoding.UTF8.GetBytes(OriginStr);

            string TmpStr = Convert.ToBase64String(TmpBytes);

            return TmpStr;
        }

        public static string Decode(string OriginStr)
        {
            byte[] TmpBytes = Convert.FromBase64String(OriginStr);

            string TmpStr = Encoding.UTF8.GetString(TmpBytes);

            return TmpStr;
        }

    }
}
