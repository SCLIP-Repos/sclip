using System;
using System.IO;
using System.Text;

namespace FSys
{
    public class Writer
    {
        public string Err { get; private set; }


        private FileStream _fileStream;

        private StreamWriter _streamWriter;


        public Writer()
        {
            if (_fileStream != null)
            {
                Err = "FIleStream is not closed.";
                return;
            }
        }

        public void Open(string FilePath)
        {
            try
            {
                _fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Write);
            }
            catch
            {
                Err = "Could not open file.";
            }
        }


        public void Write(string isStr)
        {
            using(_streamWriter = new StreamWriter(_fileStream,Encoding.UTF8))
            {
                _streamWriter.Write(isStr);
            }
        }

        public void WriteLine(string isStr)
        {
            using (_streamWriter = new StreamWriter(_fileStream, Encoding.UTF8))
            {
                _streamWriter.WriteLine(isStr);
            }
        }


        public void Write(string isStr,bool Overwrite)
        {
            using (_streamWriter = new StreamWriter(_fileStream, Encoding.UTF8))
            {
                _streamWriter.Write(isStr);
            }
        }

        public void WriteLine(string isStr,bool Overwrite)
        {
            using (_streamWriter = new StreamWriter(_fileStream, Encoding.UTF8))
            {
                _streamWriter.WriteLine(isStr);
            }
        }



        public byte[] ReadBytes()
        {
            return Encoding.UTF8.GetBytes("");
        }


        public void Close() => _fileStream.Dispose();


    }
}
