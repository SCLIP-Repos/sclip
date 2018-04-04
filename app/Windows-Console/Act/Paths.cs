using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FSys;
using FSys.Group;


namespace SCLIP.Act
{
    class Paths
    {
        internal static readonly string[] Direcotyrs =
        {
            Get + @"\Save\",
            
            Get + @"\Logs\",

            Get + @"\Backup\"
        };



        internal static string AppDataLocal = @"C:\Users\" +Environment.UserName + @"\AppData\Local\SCLIP\";


        private static string Get
        {
            get
            {
                string FullPath, AssmPath;

                FullPath = Assembly.GetEntryAssembly().Location;

                AssmPath = Path.GetFileName(FullPath);


                return FullPath.Remove(FullPath.Length - AssmPath.Length);
            }
        }
    }
}
