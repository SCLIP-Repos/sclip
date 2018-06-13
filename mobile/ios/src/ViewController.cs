using System;

using UIKit;

namespace SCLIP.iOS
{
    public partial class ViewController : UIViewController
    {

        /*
        partial void UIButton204_TouchUpInside(UIButton sender)
        {
            var a = new UIAlertView("Title", "Hello", null, "OK", "CANCEL");


            a.Show();
        }

        */


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Code to start the Xamarin Test Cloud Agent
#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
#endif




        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}
