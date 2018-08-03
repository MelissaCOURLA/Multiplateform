using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Enums;
using Plugin.MediaManager.Abstractions.EventArguments;
using Plugin.MediaManager.Abstractions.Implementations;
using Plugin.MediaManager;
using System.Diagnostics;

namespace NotreMultiApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MusiqueUnique : ContentPage
	{
		public MusiqueUnique ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossMediaManager.Current.StatusChanged += Current_StatusChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CrossMediaManager.Current.StatusChanged -= Current_StatusChanged;

        }

        private void Current_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            Debug.WriteLine($"MediaManager Status: {e.Status}");
        }

        private async void MenuPrincipal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Play_Clicked(object sender, EventArgs e)
        {
            var musique = new MediaFile
            {
                Type = MediaFileType.Audio,
                Availability = ResourceAvailability.Remote,
                Url = "https://audioboom.com/posts/5766044-follow-up-305.mp3",
                MetadataExtracted = true

            };
            await CrossMediaManager.Current.Play(musique);
        }

        private async void Pause_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Pause();
        }

        private async void Stop_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.Stop();
        }
    }
}