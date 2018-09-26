namespace SCLIP.Structure
{
    internal partial struct Configurations
    {
        internal struct Sync
        {
            public static bool Enable { get; internal set; }
            

            public static void Clear()
            {
                Enable = false;
                
            }
        }
    }
}