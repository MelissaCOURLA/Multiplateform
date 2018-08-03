using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotreMultiApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void Image_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image());
        }

        private async void Musique_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MusiqueUnique());
        }

        private async void ListeMusique_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListeMusique());
        }
    }
}
