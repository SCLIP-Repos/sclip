using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSys.Group;

namespace SCLIP
{
    class Program
    {
        

        static void Main(string[] args)
        {
            FastLoad();
            

            Console.ReadKey();
        }


        static void FastLoad()
        {
            Console.WriteLine("SCLIP");
            Console.WriteLine("Copyright : SCLIP Project https://sclipproject.com");


            Act.Configuration.Control control = new Act.Configuration.Control();

            control.Setup();

            Act.Security security = new Act.Security();

            security.Login();
        }


    }
}
