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

            }

            public string Read()
            {
                return null;
            }

            public void Close()
            {

            }

        }
    }
}
