﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace $safeprojectname$.Sys.Configuration.Security {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class Iv : global::System.Configuration.ApplicationSettingsBase {
        
        private static Iv defaultInstance = ((Iv)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Iv())));
        
        public static Iv Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LoginIv {
            get {
                return ((string)(this["LoginIv"]));
            }
            set {
                this["LoginIv"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EncryptIv {
            get {
                return ((string)(this["EncryptIv"]));
            }
            set {
                this["EncryptIv"] = value;
            }
        }
    }
}
