using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CipherModule;
using FSys;

namespace $safeprojectname$
{
    public class LogSys
    {
        private AES _aes = new AES();

        private Writer _writer = new Writer();

        public void Save()
        {
            if (!FileSt.Exists(""))
                _writer.Open("", Writer.Mode.Create);



        }

        public void Load()
        {

        }

        public void Close()
        {
            _aes.Close();

            _writer.Close();
        }

        public struct LogContents
        {
            internal string Title;

            internal string Date;

            internal bool St;

            internal string StComment;

            internal string Comment;
        }
    }
}
