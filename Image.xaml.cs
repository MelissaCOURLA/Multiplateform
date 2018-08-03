using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotreMultiApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Image : ContentPage
	{
		public Image ()
		{
			InitializeComponent ();
            /*var ImageDistance = new Image();
            ImageDistance.Resources = "https://xamarin.com/content/images/pages/forms/example-app.png";
            ImageDistance.Source = new UriImageSource
            {
                    Uri = new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"),
                    CachingEnabled = false,
                    CacheValidity = new TimeSpan(0, 0, 0, 0)
            };*/
        }

        private async void MenuPrincipal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}