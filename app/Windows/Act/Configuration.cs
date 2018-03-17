using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSys;

namespace $safeprojectname$.Act
{
    /*
     * ここに書かれているクラスとメソッドを用いて設定を保存する場合は、
     * メソッドの引数に代入する前に、前処理をしてから代入してください。
     */


    /*
    *ここに書かれているクラスとメソッドを用いて設定を読み込む場合は、
    * 読み込んだ後に後処理をしてください。
    * (書き込み手順と逆の流れです。)
    */




    //パーシャルを用いてセキュリティ設定とユーザー設定のクラスを分割しています。
    partial class Configuration
    {
        //ログインに成功した際に収める生のキー
        private static string s_loginKey;

        //Encrypt key
        private static string s_encryptKey;



        

        //設定ファイルがあるかどうかを確かめる。
        public static bool isProfile()
        {
            if (FSysDirectory.Exists(@"C:\Users\" + Environment.UserName + @"\AppData\Local\$safeprojectname$"))
                return true;

            return false;
        }

        //s_loginKey用のプロパティ
        public static string LoginKey { get => s_loginKey; internal set => s_loginKey = value; }

        //s_encryptKey用のプロパティ
        public static string EncryptKey { get => s_encryptKey; internal set => s_encryptKey = value; }
    }
}
