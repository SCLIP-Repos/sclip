using System;

using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.CommonAct
{
    class Encoder
    {
        internal string StrBaseEncodeing(string txt)
        {
            byte[] tmpBytes = Encoding.UTF8.GetBytes(txt);

            txt = Convert.ToBase64String(tmpBytes);

            return txt;
        }

        internal string StrBaseDecoding(string txt)
        {
            byte[] tmpBytes = Convert.FromBase64String(txt);

            txt = Encoding.UTF8.GetString(tmpBytes);
            
            return txt;
        }
        
    }
}
