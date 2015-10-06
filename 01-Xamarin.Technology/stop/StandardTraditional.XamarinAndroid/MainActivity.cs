using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace StandardTraditional.XamarinAndroid
{
	[Activity(Label = "StandardTraditional.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public 
		partial						// moljac# - all classes partial
		class MainActivity : Activity
	{
		int count = 1;
		Button button_private_class_level = null;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			Button button = FindViewById<Button>(Resource.Id.MyButton);

			// for non anonymous delegate
			button_private_class_level = button;

			// and attach an event to it
			button.Click += 
					//	01.	initial code
					//		c# anonymous delegates/methods	
					//delegate { button.Text = string.Format("{0} clicks!", count++); }
					//	02.	step 2
					//		c# events
					button_Click
					;


			// Java idiom for Event Handling (Listeners) java-style
			button_public = button;
			button.SetOnClickListener
						(
							// new JavaIdiomClickListener()		// java
							new JavaIdiomClickListener(this)	// c# 
						);

			return;
		}

	}
}

