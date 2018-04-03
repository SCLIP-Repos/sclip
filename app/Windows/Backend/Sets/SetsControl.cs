using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.Backend.Sets
{
    partial class SetsControl
    {
        private Actual _actualFunc = new Actual();


        internal void Save(string Dt,Enum SetTag)
        {
            switch(SetTag)
            {
                case SetTags.LoginKey:
                    break;

                case SetTags.EncryptKey:
                    break;

                case SetTags.LoginSalt:
                    break;
            }
        }

        internal string Load(Enum SetTag)
        {
            switch (SetTag)
            {
                case SetTags.LoginKey:
                    break;

                case SetTags.EncryptKey:
                    break;

                case SetTags.LoginSalt:
                    break;
            }
            return null;
        }



        private class Actual
        {

        }

    }
}
