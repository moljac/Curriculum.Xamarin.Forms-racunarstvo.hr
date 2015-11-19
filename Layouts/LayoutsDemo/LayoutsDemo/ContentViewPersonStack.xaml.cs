using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LayoutsDemo
{
	public partial class ContentViewPersonStack : ContentView
	{
		public ContentViewPersonStack ()
		{
			InitializeComponent ();

			datePcikerToday.Date = DateTime.Now;

			datePcikerToday.DateSelected += DatePcikerToday_DateSelected;
			datePcikerDateOfBirth.DateSelected += DatePcikerDateOfBirth_DateSelected;
		}

		void DatePcikerDateOfBirth_DateSelected (object sender, DateChangedEventArgs e)
		{
			DateTime dt_now = datePcikerToday.Date;
			DateTime dt_dob = datePcikerDateOfBirth.Date;

			TimeSpan ts = dt_now.Subtract(dt_dob);

			labelAge.Text = ts.Days.ToString();

			return;
		}

		void DatePcikerToday_DateSelected (object sender, DateChangedEventArgs e)
		{
			DateTime dt_now = datePcikerToday.Date;
			DateTime dt_dob = datePcikerDateOfBirth.Date;

			TimeSpan ts = dt_now.Subtract(dt_dob);

			labelAge.Text = ts.Days.ToString();

			return;
		}

		public void Dispose ()
		{
			datePcikerToday.DateSelected -= DatePcikerToday_DateSelected;
		}

	}
}

