using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}
		private void CheckUserAge(object sender, EventArgs e)
		{
			string sMessage = "";
			if (Convert.ToInt32(userAge.Text) < 16)
			{
				sMessage = "You can't drive yet";
			}
			else
			{
				sMessage = "You have been able to drive legally in wisconsin for a total of " + (Convert.ToInt32(userAge.Text) - 16) + " years!";
			}
			totalYearsMsg.Text = sMessage;
			totalYearsMsg.IsVisible = true;
		}

	}
}

