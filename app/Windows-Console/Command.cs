using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP 
{
    class Command
    {
        internal string Cmd()
        {
            return Console.ReadLine();
        }

        internal short YesNo(string c)
        {
            if (c == "y" || c == "Y")
                return 1;
            else if (c == "n" || c == "N")
                return 0;

            return 012;
        }

        internal void Run(string ReadCmd)
        {

        }
    }
}
