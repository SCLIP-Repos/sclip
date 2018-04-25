using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherModule;
using CipherModule.Fake;

namespace SCLIP.InternalSystem.Config
{
    partial class Control
    {
        internal void Save(string Dt, Enum @enum)
        {

            switch (@enum)
            {
                case Mode.LoginKey:
                    string tmp;

                    tmp = GeneralPurpose.Cipher.Rdm();

                    Security.Default.LoginKey = GeneralPurpose.Cipher.HashCompute(Dt, tmp);
                    Security.Default.Save();

                    Save(tmp, Mode.LoginSalt);
                    break;

                case Mode.LoginIv:
                    Security.Default.LoginIv = Dt;
                    Security.Default.Save();
                    break;

                case Mode.LoginSalt:
                    Security.Default.LoginSalt = Dt;
                    Security.Default.Save();
                    break;

                case Mode.EncryptKey:
                    Security.Default.EncryptKey = Dt;
                    Security.Default.Save();
                    break;

                case Mode.Log:
                    User.Default.Log = Convert.ToBoolean(Dt);
                    User.Default.Save();
                    break;
            }
        }


        internal string Load(Enum @enum)
        {
            switch (@enum)
            {
                case Mode.LoginKey:
                    return Security.Default.LoginKey;

                case Mode.LoginIv:
                    return Security.Default.LoginIv;

                case Mode.LoginSalt:
                    return Security.Default.LoginSalt;

                case Mode.EncryptKey:
                    return Security.Default.EncryptKey;

                case Mode.Log:
                    return User.Default.Log.ToString();

                default:
                    return null;
            }
        }

    }
}
