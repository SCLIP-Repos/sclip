using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.InternalSystem
{
    class Paths
    {
        internal static string Save = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SCLIP\Save\";

        internal static string Log = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SCLIP\Log\";
    }
} 
