using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Sys
{
    partial class Processor
    {
        public void Run(Enum @enum)
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
