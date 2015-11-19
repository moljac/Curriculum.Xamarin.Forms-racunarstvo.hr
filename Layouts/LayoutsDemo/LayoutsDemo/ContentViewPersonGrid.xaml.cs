using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LayoutsDemo
{
	public partial class ContentViewPersonGrid : ContentView
	{
		public ContentViewPersonGrid ()
		{
			InitializeComponent ();

			datePickerToday.Date = DateTime.Now;

			datePickerToday.DateSelected += DatePcikerToday_DateSelected;
			datePcikerDateOfBirth.DateSelected += DatePcikerDateOfBirth_DateSelected;
		}


		void DatePcikerDateOfBirth_DateSelected (object sender, DateChangedEventArgs e)
		{
			DateTime dt_now = datePickerToday.Date;
			DateTime dt_dob = datePcikerDateOfBirth.Date;

			TimeSpan ts = dt_now.Subtract(dt_dob);

			labelAge.Text = ts.Days.ToString();

			return;
		}

		void DatePcikerToday_DateSelected (object sender, DateChangedEventArgs e)
		{
			DateTime dt_now = datePickerToday.Date;
			DateTime dt_dob = datePcikerDateOfBirth.Date;

			TimeSpan ts = dt_now.Subtract(dt_dob);

			labelAge.Text = ts.Days.ToString();

			return;
		}
	}
}

