using System;
using System.Diagnostics;
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
        

        
        public static void Move(string DirectoryPath,string DestPath)
        {
            /*
             
             X:\a (move)-> Y:\a  
             If you want to do like this, do this.
             X:\a (move)-> Y:\
             
             */



            if (DirectoryPath == DestPath)
            {
                Excepter.Err = "It is not possible to specify the same path as the source and destination.";
                return;
            }



            DirectoryInfo directoryInfo = new DirectoryInfo(DirectoryPath);

            string Tmp = DestPath + @"\" + directoryInfo.Name;

            if (Exists(Tmp))
            {
                Excepter.Err = "Destination is already exists.";

                return;
            }


            Directory.Move(DirectoryPath, Tmp);

        }


        public static void Delete(string DirectoryPath)
        {
            if (Directory.Exists(DirectoryPath))
            {
                try
                {
                    Directory.Delete(DirectoryPath);
                }
                catch(Exception ex)
                {
                    Excepter.Except = ex.ToString();
                }
            }
            else
            {
                Excepter.Err = "Directory don't exists.";

            }
        }

        public static bool Exists(string DirectoryPath)
        {
            return Directory.Exists(DirectoryPath);
        }


    }

}
