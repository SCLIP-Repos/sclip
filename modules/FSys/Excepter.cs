using System;
namespace FSys
{
    public class Excepter
    {
        public static string Err { get; internal set; }

        public static string Except { get; internal set; }



        internal static void Clear()
        {
            Err = null;

            Except = null;
        }
    }
}
