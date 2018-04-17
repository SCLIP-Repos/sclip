using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.InternalSystem.Config
{
    partial class Control
    {
        internal void Save(string Dt, Enum @enum)
        {
            switch(@enum)
            {
                case Mode.LoginKey:
                    break;

                case Mode.LoginIv:
                    break;

                case Mode.LoginSalt:
                    break;

                case Mode.EncryptKey:
                    break;

                case Mode.Log:
                    break;
            }
        }


        internal void Load(Enum @enum)
        {
            switch (@enum)
            {
                case Mode.LoginKey:
                    break;

                case Mode.LoginIv:
                    break;

                case Mode.LoginSalt:
                    break;

                case Mode.EncryptKey:
                    break;

                case Mode.Log:
                    break;
            }
        }
    }
}
