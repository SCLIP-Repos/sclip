
using $safeprojectname$.Configuration;

namespace $safeprojectname$.Act
{
    
    partial class Configuration
    {
        //ユーザーレベルでの設定が分類される
        //例えばログの記録をするか？自動アップデートをするか？など。
        public class User
        {

            //書き込み

            public static void SaveOfLog(bool e)
            {
                UserConf.Default.Log = e;
                UserConf.Default.Save();
            }


            //読み込み


            public static bool LoadOfLog()
            {
                return UserConf.Default.Log;
            }
        }
        
    }
}
