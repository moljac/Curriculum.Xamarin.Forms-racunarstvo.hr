using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace StandardTraditional.XamarinAndroid
{
	public partial class MainActivity 
	{
		private void button_Click(object sender, EventArgs e)
		{
			button_private_class_level.Text = string.Format("{0} clicks!", count++);

			return;
		}

	}
}

