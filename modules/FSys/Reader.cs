using System;
using System.IO;
using System.Text;

namespace FSys
{

    public class Reader
    {
        
        private FileStream _fileStream = null;


        public Reader()
        {
            Excepter.Clear();
        }


        public void Open(string FilePath)
        {
            try
            {
                _fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);    
            }
            catch(Exception ex)
            {
                Excepter.Except = ex.ToString();

                Excepter.Err = "Could not open up the file.";
            }
            finally
            {
                Close();
            }
        }



        public string Read()
        {
            return Read(Encoding.UTF8, 2500);
        }


        public string Read(Encoding encode)
        {
            return Read(encode,2500);
        }

        public string Read(Encoding encode,int BufSize)
        {
            try
            {
                using (StreamReader streamRead = new StreamReader(_fileStream,encode,false,BufSize))
                {
                    return streamRead.ReadToEnd();
                }
            }
            catch(Exception ex)
            {
                Excepter.Except = ex.ToString();

                Excepter.Err = "Failed to read the file.";

                return null;
            }
        }



        public string ReadLine()
        {
            return ReadLine(Encoding.UTF8,2500);
        }

        public string ReadLine(Encoding encode)
        {
            return ReadLine(encode,2500);
        }

        public string ReadLine(Encoding encode,int BufSize)
        {
            try
            {
                using (StreamReader streamRead = new StreamReader(_fileStream, encode, false, BufSize))
                {
                    return streamRead.ReadLine();
                }
            }
            catch
            {
                return null;
            }            
        }



        /*
        public void ReadAsync()
        {
            
        }
        */


        public void Close() => _fileStream.Close();


    }
}
