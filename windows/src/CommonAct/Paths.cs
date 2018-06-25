using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.CommonAct
{
    class Paths
    {
        internal readonly static string[] DirectoryPaths =
        {
            //0
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\sclip\",

            //1
            DirectoryPaths[0] + @"set\",

            //2
            DirectoryPaths[0] + @"logs\",

            //3
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\sclip\",

            //4
            DirectoryPaths[3] + @"save\",

            //5
            DirectoryPaths[3] + @"trash\"
        };

        internal readonly static string[] FilePaths =
        {
            DirectoryPaths[1] + "sclip.json",

            DirectoryPaths[1] + "authentication.json",

            DirectoryPaths[2] + "setup.log",

            DirectoryPaths[2] + "authentication.log"
        };
    }
}
