namespace $safeprojectname$.Act
{
    partial class Setup
    {
        //すべて生の状態
        internal static class Tmp
        {
            public static string LoginKey;

            internal static string EncryptKey;

            internal static string EncryptIv;

            internal static string LoginSalt;

            internal static void Clear()
            {
                LoginKey = null;

                EncryptIv = null;

                EncryptIv = null;

                LoginSalt = null;
            }
        }
    }
}
