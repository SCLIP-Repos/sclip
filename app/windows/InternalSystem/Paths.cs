using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.InternalSystem
{
    class Paths
    {

        internal static string[] Directorys =
        {
            AsmLocation + @"user\",
            AsmLocation + @"save\"
        };


        internal static string[] Files =
        {
            //LoginKey,Salt
            Directorys[0] + "0",

            // "EncKey,Iv"
            Directorys[0] + "1"
        };

        private static string AsmLocation
        {
            get
            {
                string tmp = Assembly.GetEntryAssembly().Location;

                return tmp.Remove(tmp.Length - Path.GetFileName(tmp).Length);
            }
        }
    }
} 