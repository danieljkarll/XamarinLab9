using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public class SettingsPageCS : ContentPage
	{
		public SettingsPageCS ()
		{
			
			Title = "Check Age";
			Content = new StackLayout {
				Children = {
					new Label {
						Text = "Settings go here",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
