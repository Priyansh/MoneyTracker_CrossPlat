using System;

using UIKit;

namespace MoneyTracker_CrossPlat.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            //Button.AccessibilityIdentifier = "myButton";
            //Button.TouchUpInside += delegate {
            //	var title = string.Format ("{0} clicks!", count++);
            //	Button.SetTitle (title, UIControlState.Normal);
            //};
            btnEarned.TouchUpInside += BtnEarned_TouchUpInside;
            btnSpent.TouchUpInside += BtnSpent_TouchUpInside;
		}

        private void BtnSpent_TouchUpInside(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnEarned_TouchUpInside(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

