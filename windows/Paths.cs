using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP
{
    internal class Paths
    {
        public static readonly string[] Dirs =
        {
            appdata + @"save\",

            appdata + @"conf\"
        };

        public static readonly string[] Files =
        {
            //psw(authentication),itemlock,backupcode,
            Dirs[1] + "sclip",
            Dirs[1] + "log.txt"
        };

        private static readonly string appdata = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SCLIP\";
    }
}
