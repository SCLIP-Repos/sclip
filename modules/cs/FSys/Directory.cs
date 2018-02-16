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


        public static void Copy(string DirectoryPath)
        {
            
        }


        public static void Move(string DirectoryPath)
        {
            
        }


        public static void Delete(string DirectoryPath)
        {
            
        }


    }

}
