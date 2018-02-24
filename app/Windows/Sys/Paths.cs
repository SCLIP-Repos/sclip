using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Sys
{
    class Paths
    {

        internal class ProcLocation
        {
            internal readonly string UpdaterPath = ThisLocation() + "Updater.exe";

            internal readonly string Installer = ThisLocation() + "Installer.exe";

            internal readonly string Uninstaller = ThisLocation() + "Uninstaller.exe";

            internal readonly string Cleaner = ThisLocation() + "Cleaner.exe";

        }

        private static string ThisLocation()
        {
            string FullPath = Assembly.GetEntryAssembly().Location;
            
            return FullPath.Remove(FullPath.Length - Path.GetFileName(FullPath).Length);
        }
    }
}
