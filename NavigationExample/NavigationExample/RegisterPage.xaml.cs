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
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage()
		{
			InitializeComponent();
		}

		async private void Button_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopModalAsync();
        }
    }
}