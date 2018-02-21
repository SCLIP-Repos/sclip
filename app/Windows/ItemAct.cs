using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CipherModule;
using FSys;


namespace $safeprojectname$
{
    class ItemAct
    {
        public void Load()
        {
            
        }


        public void Write()
        {
            
        }

        public struct Property
        {
            public string Name { get; internal set; }    

            public string Url { get; internal set; }

            public string Username { get; internal set; }

            public string Id { get; internal set; }

            public string Psw { get; internal set; }

            public string TEL { get; internal set; }

            public string Mail { get; internal set; }

            public string Memo { get; internal set; }

            public void Clear()
            {
                Name = null;

                Url = null;

                Username = null;

                Id = null;

                Psw = null;

                TEL = null;

                Mail = null;

                Memo = null;
            }
        }


        public class ItemDirectory
        {
            public void Create(string ItemDirectoryName)
            {

            }

            public void Delete(string ItemDirectoryName)
            {

            }

            public bool Exists(string ItemDirectoryName)
            {
                return false;
            }
        }
    }
}
