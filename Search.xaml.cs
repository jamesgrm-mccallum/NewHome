using Microsoft.Maui.Controls;
using System;

namespace NewHome
{
    public partial class Search : ContentPage
    {
        public Search()
        {
            InitializeComponent();

        }

        private void OnSearchClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Listings() { BackgroundColor = BackgroundColor });
        }

    }
}
