using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Security
{
    public class Login
    {
        public static string LoginKey;


        private class InternalEncrypt
        {
            public static string InternalKey { get; private set; }



            private string Key, Iv;

            public InternalEncrypt()
            {
                InternalKey = null;


            }
        }
    }
}
