using System;
using System.Text;
using System.IO;


namespace FSys
{
    public class Reader
    {
        public string Err { get; private set; }


        private FileStream _fileStream;

        private StreamReader _streamReader;


        public Reader()
        {
            if(_fileStream != null)
            {
                Err = "FIleStream is not closed.";
                return;
            }
        }

        public void Open(string FilePath)
        {
            try
            {
                _fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                Err = "Could not open file.";
            }
        }


        public string Read()
        {
            using(_streamReader = new StreamReader(_fileStream,Encoding.UTF8))
            {
                try
                {
                    return _streamReader.ReadToEnd();
                }
                catch
                {
                    return null;
                }
            }
        }

        public string ReadLine()
        {
            using(_streamReader = new StreamReader(_fileStream,Encoding.UTF8))
            {
                try
                {
                    return _streamReader.ReadLine();   
                }
                catch
                {
                    return null;
                }
            }
        }

        public byte[] ReadBytes()
        {
            string Tmp = Read();

            if(Tmp == null)
                return null;
            

            return Encoding.UTF8.GetBytes(Tmp);
        }


        public void Close() => _fileStream.Dispose();


    }
}
