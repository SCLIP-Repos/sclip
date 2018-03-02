using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Sys
{
    partial class ProcessControl
    {
        public void Run(Enum @enum)
        {
            switch (@enum)
            {
                case RunProc.Installer:
                    Process.Start(Paths.SCLIPtools.Installer.ToString());
                    break;

                case RunProc.Updater:
                    Process.Start(Paths.SCLIPtools.UpdaterPath.ToString());
                    break;

                case RunProc.Uninstaller:
                    Process.Start(Paths.SCLIPtools.Uninstaller.ToString());
                    break;

                case RunProc.Cleaner:
                    Process.Start(Paths.SCLIPtools.Cleaner.ToString());
                    break;

                case RunProc.SimpleView:
                    Process.Start(Paths.SCLIPtools.SimpleView.ToString());
                    break;
            }
        }

        public void Close(Enum @enum)
        {
            switch (@enum)
            {
                case RunProc.Installer:
                    break;

                case RunProc.Updater:
                    break;

                case RunProc.Uninstaller:
                    break;

                case RunProc.Cleaner:
                    break;

                case RunProc.SimpleView:
                    break;
            }
        }
    }
}
