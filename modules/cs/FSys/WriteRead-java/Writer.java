import System;
import System.Text;
import System.IO;

public class FSys
{
    public partial class Writer
    {
        private FileStream _fileStream = null;


        public Writer() => Excepter.Clear();



        public void Open(string FilePath)
        {
            Open(FilePath,Mode.Open);
        }

        public void Open(string FilePath,Enum StreamMode)
        {
            try
            {
                switch(StreamMode)
                {
                    case Mode.Open:
                        _fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Write);
                        break;
                    case Mode.Create:
                        _fileStream = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
                        break;
                    case Mode.Append:
                        _fileStream = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
                        break;
                }
            }
            catch (IOException ex)
            {
                Excepter.Except = ex.ToString();

                Excepter.Err = "Creation of the file failed or the file could not be opened.";
            }
        }




        public void Write(string isString)
        {
            Write(isString,Encoding.UTF8);
        }



        public void Write(string isString,Encoding encode)
        {
            try
            {
                using (StreamWriter streamWrite = new StreamWriter(_fileStream, encode))
                {
                    streamWrite.Write(isString);
                }
            }
            catch (IOException ex)
            {
                Excepter.Except = ex.ToString();

                Excepter.Err = "Writing to the file failed.";
            }
        }


        public void WriteLine(string isString)
        {
            WriteLine(isString,Encoding.UTF8);   
        }

        public void WriteLine(string isString,Encoding encode)
        {
            try
            {
                using (StreamWriter streamWrite = new StreamWriter(_fileStream, encode))
                {
                    streamWrite.WriteLine(isString);
                }
            }
            catch (IOException ex)
            {
                Excepter.Except = ex.ToString();

                Excepter.Err = "Writing to the file failed.";
            }
        }



        public virtual void ASyncWrite(string isString)
        {

        }


        public virtual void ASyncWrite(string isString, Encoding encode)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(_fileStream, encode))
                {
                    streamWriter.WriteAsync(isString);
                }
            }
            catch (IOException ex)
            {
                Excepter.Except = ex.ToString();

                Excepter.Err = "Writing to the file failed.";
            }
        }


        public virtual void ASyncWriteLine(string isString)
        {

        }


        public virtual void ASyncWriteLine(string isString, Encoding encode)
        {

        }



        public void Close()
        {
            if (_fileStream == null)
                return;
            
            _fileStream.Dispose();
        }




    }
}
