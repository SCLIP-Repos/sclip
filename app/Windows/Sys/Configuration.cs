using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSys;

namespace $safeprojectname$.Sys
{
    partial class Configuration
    {
        public void Create()
        {
            Create(Type.SecurityConf);

            Create(Type.UserConf);
        }

        public void Create(Enum @enum)
        {
            switch(@enum)
            {
                case Type.SecurityConf:
                    break;

                case Type.UserConf:
                    break;
            }
        }

        public string Load(Enum @enum)
        {
            Reader reader = new Reader();

            switch (@enum)
            {
                case Type.SecurityConf:
                    //reader.Open();
                    //reader.Read();
                    return "";

                case Type.UserConf:
                    //reader.Open();
                    //reader.Read();
                    return "";

                default:
                    reader.Close();
                    return null;
            }
        }

    }
}
/*
 読み込んで
 書き換えて　保存する

    Read
    Tmp
    Tmp[0] = aaaa
    Save
     */