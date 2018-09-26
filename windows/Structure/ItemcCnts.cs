using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.Structure
{
    internal struct ItemcCnts
    {
       public static string ServiceName { get; internal set; }

        public static string URL { get; internal set; }

        public static string ID { get; internal set; }

        public static string Mail { get; internal set; }

        public static string Psw { get; internal set; }

        public static string Memo { get; internal set; }


        public static void Clear()
        {
            ServiceName = null;

            URL = null;

            ID = null;

            Mail = null;

            Psw = null;

            Memo = null;
        }


    }
}
