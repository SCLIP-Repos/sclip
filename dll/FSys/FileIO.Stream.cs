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
        public class Stream
        {
            private FileStream _fileStream;

            public Stream(string FilePath)
            {
                try
                {
                    _fileStream = new FileStream(FilePath, FileMode.Open);
                }
                catch(Exception e)
                {

                    Excepter.Clear();

                    Excepter.Ex = e.ToString();
                }
                
            }


            public void Write(string  Str)
            {

                try
                {

                    using (StreamWriter sw = new StreamWriter(_fileStream, Encoding.UTF8))
                    {
                        sw.Write(Str);
                    }
                }
                catch(Exception e)
                {

                    Excepter.Clear();

                    Excepter.Ex = e.ToString();
                }
                
            }

            public string Read()
            {
                try
                {
                    using (StreamReader sr = new StreamReader(_fileStream, Encoding.UTF8))
                    {
                        return sr.ReadToEnd();
                    }
                }
                catch(Exception e)
                {

                    Excepter.Clear();

                    Excepter.Ex = e.ToString();

                    return null;
                }
                
            }

            public void Close() => _fileStream.Close();

        }
    }
}
