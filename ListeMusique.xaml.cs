using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Enums;
using Plugin.MediaManager.Abstractions.EventArguments;
using Plugin.MediaManager.Abstractions.Implementations;

namespace NotreMultiApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListeMusique : ContentPage
	{
		public ListeMusique ()
		{
			InitializeComponent ();
		}

        private async void MenuPrincipal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Play_Clicked(object sender, EventArgs e)
        {
            var Liste = new List<MediaFile>
            {
                new MediaFile
                {
                    Url = "https://audioboom.com/posts/5766044-follow-up-305.mp3?source=rss&amp;stitched=1",
                    Type = MediaFileType.Audio,
                    Metadata = new MediaFileMetadata
                    {
                        Title = "Numéro 1"
                    }
                },

                new MediaFile
                {
                    Url = "https://media.acast.com/mydadwroteaporno/s3e1-london-thursday15.55localtime/media.mp3",
                    Type = MediaFileType.Audio,
                    Metadata = new MediaFileMetadata
                    {
                        Title = "Numéro 2"
                    }
                },

                new MediaFile
                {
                     Url = "https://audioboom.com/posts/5766044-follow-up-305.mp3",
                    Type = MediaFileType.Audio,
                    Metadata = new MediaFileMetadata
                    {
                        Title = "Numéro 3"
                    }
                }
            };
            await CrossMediaManager.Current.Play(Liste) ;
        }
        
        private async void Pause_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.PlaybackController.PlayPause();
        }

        private async void Stop_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.PlaybackController.Stop();
        }

        private async void Previous_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.PlaybackController.PlayPrevious();
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.PlaybackController.PlayNext();
        }
    }
}