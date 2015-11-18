using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android;

[assembly: UsesPermission(Manifest.Permission.AccessFineLocation)]
[assembly: UsesPermission(Manifest.Permission.AccessCoarseLocation)]

namespace StandardTraditional.XamarinAndroid
{

	public partial class MainActivity
	{
		/// <summary>
		/// 
		/// </summary>
		/// <see cref="http://developer.android.com/reference/android/widget/Button.html"/>
		internal partial class JavaIdiomClickListener 
				:
				Java.Lang.Object,			// Xamarin - must have
				View.IOnClickListener
		{
			/*
			'StandardTraditional.XamarinAndroid.MainActivity.JavaIdiomClickListener' 
			does not implement interface member 'System.IDisposable.Dispose()'	
				01-Xamarin.Technology\stop\StandardTraditional.XamarinAndroid\MainActivity.Java.Listener.cs

			'StandardTraditional.XamarinAndroid.MainActivity.JavaIdiomClickListener' 
			 does not implement interface member 'Android.Runtime.IJavaObject.Handle'
			 01-Xamarin.Technology\stop\StandardTraditional.XamarinAndroid\MainActivity.Java.Listener.cs
			*/

			//public void onClick(View v)	//	java camel casing
			public void OnClick(View v)		//	c# pascal casing
			{
				// Perform action on click

				// c# style
				// button.Text = string.Format("{0} clicks!", count++);
				// java style
				outer.button_public.Text = string.Format("{0} clicks!", outer.count_public++);

				return;
			}


			/*
			Internal classes in C# work different than they do in Java.

			In Java an internal class has access to its outer class: 
			during the construction, each instance stores a reference to 
			its parent that constructed the instance.

			In C#, internal classes are a simple way to define classes that 
			have access to an instance private members. In other words when 
			you receive or store a reference to a mainForm you can read/write/modify 
			private fields and call private methods. There is no such thing as a 
			outer-relation.

			*/
			/*
			FIXUP
				reference to outer/enclosing object	
			*/
			private readonly MainActivity outer;

			public JavaIdiomClickListener(MainActivity outer)
			{
				this.outer = outer;
				
			}
		}

		/*
			FIXUP
			all private fields/variables must be public, so that inner class can access those
		*/
		public int count_public = 0;
		public Button button_public = null;

	}
}

