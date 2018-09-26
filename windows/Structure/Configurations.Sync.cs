namespace SCLIP.Structure
{

    internal partial struct Configurations
    {
        internal struct Sync
        {
            public static bool Enable { get; internal set; }

            public static string DropBox_LoginKey { get; internal set; }

            public static string DropBox_MAddress { get; internal set; }

            public static void Clear()
            {
                Enable = false;

                DropBox_LoginKey = null;

                DropBox_MAddress = null;
            }
        }
    }
}
