using Microsoft.Maui.Controls;
using System;

namespace NewHome
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnPageTapped(object sender, EventArgs e)


        {
            // Navigate to a new EmptyPage with the same background color
            await Navigation.PushAsync(new Search() { BackgroundColor = BackgroundColor });
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            // Navigate to a new EmptyPage with the same background color
            await Navigation.PushAsync(new Search() { BackgroundColor = BackgroundColor });
        }
    }
}

