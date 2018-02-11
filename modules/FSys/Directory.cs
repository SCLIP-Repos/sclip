using System;
using System.IO;

namespace FSys
{
    public class FSysDirectory
    {
        public FSysDirectory() => Excepter.Clear();

        static FSysDirectory() => Excepter.Clear();



        public static void MkDir(string DirectoryPath)
        {
            if (!Directory.Exists(DirectoryPath))
            {
                try
                {
                    Directory.CreateDirectory(DirectoryPath);
                }
                catch (IOException ex)
                {
                    Excepter.Except = ex.ToString();

                }
            }
            else
            {
                Excepter.Err = "Directory already exists.";
            }
        }



    }

}
