using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

namespace SCLIP.Act.Item
{
    class QR
    {
        internal static string GetCode(string str)
        {
            string tmp = HttpUtility.UrlEncode("Hello");


            string getQR = Convert.ToString("https://chart.googleapis.com/chart?cht=qr&chl=" + tmp + "&chs=300x300&chld=H|1");

            return Encrytion( getQR );
        }

        internal static string Encrytion(string str)
        {
            return "";
        }

        internal static string Decryption(string str)
        {
            return "";
        }
    }
}
