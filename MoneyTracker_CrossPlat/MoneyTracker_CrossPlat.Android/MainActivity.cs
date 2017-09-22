using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MoneyTracker_CrossPlat.Droid
{
	[Activity (Label = "MoneyTracker.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        Button btnEarned, btnSpent;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			btnEarned = FindViewById<Button> (Resource.Id.btnEarned);
            btnSpent = FindViewById<Button>(Resource.Id.btnSpent);

            btnEarned.Click += BtnEarned_Click;
            btnSpent.Click += BtnSpent_Click;
		}

        private void BtnSpent_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnEarned_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}


