namespace SCLIP.CommonAct
{
    partial class TemporaryStorage
    {
        internal struct Security
        {
            internal static string AuthenticationPsw {  get;  set; }

            internal static string EncryptionPsw { get; set; }
        }

        internal void Clear()
        {
            Security.AuthenticationPsw = null;

            Security.EncryptionPsw = null;
        }
    }
}
