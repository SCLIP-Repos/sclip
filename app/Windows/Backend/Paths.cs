using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.Backend
{
    class Paths
    {
        internal static readonly string[] DirectoryPath =
        {
            GeneralPurpose.ThisLocationAssembly.Get + @"\Save\",
        
            GeneralPurpose.ThisLocationAssembly.Get + @"\Backup\",

            DirectoryPath[1] + @"AppDataLocalSCLIP\"
        };
       
        internal void Check(out string DoesNotExistPath)
        {
            DoesNotExistPath = null;

            

        }
    }
}