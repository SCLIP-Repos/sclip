import System;
import System.IO;

public class FSys
{
    public class FileSt
    {
        public FileSt()
        {
        }


        public static bool Exists(string FilePath)
        {
            if (File.Exists(FilePath))
                return true;

            return false;
        }
    }
}
