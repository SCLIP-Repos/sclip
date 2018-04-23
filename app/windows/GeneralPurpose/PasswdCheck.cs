using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;

namespace SCLIP.GeneralPurpose
{
    class PasswdCheck
    {
        private string tmp;

        public PasswdCheck(string Str) => tmp = Str;



        public bool Check(string Reg)
        {
            if(Regex.IsMatch(tmp,Reg) )
            {
                return true;
            }

            return false;
        }

        public bool Length(int Len)
        {
            if(tmp.Length >= Len)
            {
                return true;
            }

            return false;
        }

        public bool isChar(char[] c)
        {
     
            for(int i = 0; i < tmp.Length; i++)
            {
                for(int j = 0; j < c.Length; j++)
                {
                    if(tmp[i] == c[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
