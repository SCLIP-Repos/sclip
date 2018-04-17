using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSys
{
   public class Group
    {
        public static void Create(string DirPath)
        {
            try
            {
                Directory.CreateDirectory(DirPath);
            }
            catch(Exception e)
            {
                Excepter.Clear();

                Excepter.Ex = e.ToString();

            }
        }

        public static bool Exists(string DirPath)
        {

            try
            {

                if (Directory.Exists(DirPath))
                    return true;

                return false;
            }
            catch (Exception e)
            {
                Excepter.Clear();

                Excepter.Ex = e.ToString();
                
                return false;
            }
        }

    }
}
