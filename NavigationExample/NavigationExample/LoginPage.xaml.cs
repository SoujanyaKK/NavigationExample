using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationExample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			string un = username.Text;
			string pw=password.Text;

			if(un == "admin" && pw == "admin")
			{
				Navigation.PushModalAsync(new WelcomePage());
			}
			else
			{
				DisplayAlert("Login failed", "Try Again!", "OK");
			}
		}

		async private void Button_Clicked_1(object sender, EventArgs e)
		{
			await Navigation.PopModalAsync();
		}
	}
}