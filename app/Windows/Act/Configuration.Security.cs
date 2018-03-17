
using $safeprojectname$.Configuration;

namespace $safeprojectname$.Act
{
    partial class Configuration
    {
        //ログインキーやそれに伴ったソルトや初期化ベクトルを保存する
        public class Security
        {

            //書き込み

            public static void SaveOfLoginKey(string s)
            {
                Security_key.Default.Login = s;
                Security_key.Default.Save();
            }

            public static void SaveOfEncryptKey(string s)
            {
                Security_key.Default.Encrypt = s;
                Security_key.Default.Save();
            }

            public static void SaveOfLoginSalt(string s)
            {
                Security_salt.Default.Login = s;
                Security_salt.Default.Save();
            }

            public static void SaveOfEncryptIv(string s)
            {
                Security_iv.Default.Encrypt = s;
                Security_iv.Default.Save();
            }



            //読み込み

            public static string LoadOfLoginKey()
            {
                return Security_key.Default.Login;
            }


            public static string LoadOfEncryptKey()
            {
                return Security_key.Default.Encrypt;
            }

            public static string LoadOfLoginSalt()
            {
                return Security_salt.Default.Login;
            }

            public static string LoadOfEncryptIv()
            {
                return Security_iv.Default.Encrypt;
            }
        }
        
    }
}
