using System;
using System.Collections.Generic;
using lab2project;
using Xamarin.Forms;

namespace lab2project
{
    public partial class MenuView : StackLayout
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private async void Goto_Rating(object sender, EventArgs e)
        {
            // Navigate to the RatingPage when the "Rating" button is clicked
            await Navigation.PushAsync(new ImageRating());
        }

        private async void Goto_Admin(object sender, EventArgs e)
        {
            // Navigate to the RatingPage when the "Rating" button is clicked
            await Navigation.PopAsync();
        }
    }
}