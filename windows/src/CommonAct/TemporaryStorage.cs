using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCLIP.CommonAct
{
    partial class TemporaryStorage
    {

        internal void Clear()
        {
            Item.ServiceName = null;

            Item.URL = null;

            Item.Nicname = null;

            Item.Id = null;

            Item.Password = null;

            Item.Memo = null;

            Security.AuthenticationPsw = null;

            Security.EncryptionPsw = null;
        }
    }
}
