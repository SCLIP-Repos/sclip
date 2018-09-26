namespace SCLIP.Structure
{
    internal partial struct Configurations
    {
        internal struct Keys
        {
            public static string AuthenticationKey { get; internal set; }

            public static string ItemKey { get; internal set; }

            public static string Backupcode { get; internal set; }

            public static string Tmp { get; set; }

            public static void Clear()
            {
                AuthenticationKey = null;

                ItemKey = null;

                Backupcode = null;

                Tmp = null;
            }

        }
    }
}
