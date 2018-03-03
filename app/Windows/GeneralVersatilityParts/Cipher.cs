using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CipherModule;

namespace $safeprojectname$.GeneralVersatilityParts
{
    class Cipher
    {
        public static string Print { get; private set; }


        public static void Encrypt(string Origin)
        {

        }

        public static void Decrypt(string Origin)
        {

        }

        private static int Count = 0;
        public static void HashCompute(string Origin,string Salt)
        {
            Count++;

            if (Count == 3000)
                return;

            Print = SHA.SHA_256(Origin);

            HashCompute(Origin, Salt);
        }

    }
}
