using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.Act
{
    class Edit
    {
        internal bool EditMode = false;


        internal void Save()
        {

        }
     
        internal void Load()
        {
            EditMode = true;




            EditMode = false;
        }

        internal void Delete()
        {

        }

        private class JsonPerser
        {
            private string _itempath;

            public JsonPerser(string path)
            {
                
            }


            public void Close() => _itempath = null;
            
        }

    }
}
