using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FSys
{
    public partial class FileIO
    {
        public static void Create(string FilePath)
        {
            try
            {
                using (var f = File.Create(FilePath)) { f.Close(); }

            }
            catch(Exception e)
            {
                Excepter.Clear();

                Excepter.Ex = e.ToString();
            }

        }


        public static void Delete(string FilePath)
        {
            try
            {
                File.Delete(FilePath);

            }
            catch(Exception e)
            {

                Excepter.Clear();

                Excepter.Ex = e.ToString();
            }
        }

        public static bool Exists(string FilePath)
        {
            try
            {
                if (File.Exists(FilePath))
                    return true;

                return false;
            }
            catch(Exception e)
            {

                Excepter.Clear();

                Excepter.Ex = e.ToString();

                return false;
            }

        }

        public static void Rename(string FilePath,string New)
        {
            try
            {
                File.Move(FilePath, New);
            }
            catch(Exception e)
            {
                Excepter.Clear();

                Excepter.Ex = e.ToString();
            }
        }
    }
}
