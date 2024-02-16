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
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}


		private void Button_Clicked_1(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new LoginPage());

		}

		private void Button_Clicked_2(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new RegisterPage());
		}
	}
}