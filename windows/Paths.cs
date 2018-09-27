using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP
{
    internal class Paths
    {
        public static  string[] Dirs =
        {
            appdata + @"save\",

            appdata + @"conf\"
        };

        public static  string[] Files =
        {
            //psw(authentication),itemlock,backupcode,
            Dirs[1] + "aut",
            Dirs[1] + "il",
            Dirs[1] + "bc",
            Dirs[1] + "log.txt"
        };

        public static readonly string appdata = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SCLIP\";

        
    }
}
