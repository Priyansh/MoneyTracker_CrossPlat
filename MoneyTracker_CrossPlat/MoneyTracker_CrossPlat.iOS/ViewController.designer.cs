// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MoneyTracker_CrossPlat.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnEarned { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSpent { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnEarned != null) {
                btnEarned.Dispose ();
                btnEarned = null;
            }

            if (btnSpent != null) {
                btnSpent.Dispose ();
                btnSpent = null;
            }
        }
    }
}