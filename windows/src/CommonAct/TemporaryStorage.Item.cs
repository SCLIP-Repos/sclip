namespace SCLIP.CommonAct
{
    partial class TemporaryStorage
    {
        internal struct Item
        {
            internal static string ServiceName { get; set; }

            internal static string URL { get; set; }

            internal static string Nicname { get; set; }

            internal static string Id { get; set; }

            internal static string Password { get; set; }

            internal static string Memo { get; set; }
        }

        internal static void Clear()
        {
            Item.ServiceName = null;

            Item.URL = null;

            Item.Nicname = null;

            Item.Id = null;

            Item.Password = null;

            Item.Memo = null;
        }
    }
}
