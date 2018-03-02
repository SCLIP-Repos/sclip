using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Sys
{
    class Paths
    {
        internal static readonly string[] Directory =
         {
            UserDocuments + @"$safeprojectname$\Save\",

            UserDocuments + @"$safeprojectname$\Logs",

            UserDocuments + @"$safeprojectname$\TMP"
        };

        internal static readonly string[] File =
        {
            //Key , BackupKey
            ThisLocation() + "0",

            //Sys Key , 
            ThisLocation() + "1",

            //User sets
            ThisLocation() + "User"
        };



            internal static class SCLIPtools
        {
            internal static readonly string UpdaterPath = ThisLocation() + "Updater.exe";

            internal static readonly string Installer = ThisLocation() + "Installer.exe";

            internal static readonly string Uninstaller = ThisLocation() + "Uninstaller.exe";

            internal static readonly string Cleaner = ThisLocation() + "Cleaner.exe";

            internal static readonly string SimpleView = ThisLocation() + "SimpleView.exe";
        }




        private static string UserDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";

        private static string ThisLocation()
        {
            string FullPath = Assembly.GetEntryAssembly().Location;

            return FullPath.Remove(FullPath.Length - Path.GetFileName(FullPath).Length);
        }
    }
}
