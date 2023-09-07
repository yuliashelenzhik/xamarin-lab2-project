using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2project.Models;
using Xamarin.Forms;
using lab2project;

namespace lab2_project
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<PictureWithLikesAndDislikes> pictures = new ObservableCollection<PictureWithLikesAndDislikes>();
        private PictureWithLikesAndDislikes selectedPicture;

        public MainPage()
        {
            InitializeComponent();
            pictureListView.ItemsSource = pictures;
        }

        private void AddPicture(object sender, EventArgs e)
        {
            // Get values from the entry fields
            string imageName = imageNameEntry.Text;
            string imageUrl = imageUrlEntry.Text;

            // Create a new PictureModel and add it to the collection
            pictures.Add(new PictureWithLikesAndDislikes { Id = pictures.Count + 1, Name = imageName, ImageUrl = imageUrl });

            // Clear the entry fields
            imageNameEntry.Text = imageUrlEntry.Text = string.Empty;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            var picture = (PictureWithLikesAndDislikes)radioButton.BindingContext;

            if (e.Value)
            {
                // Picture is selected
                selectedPicture = picture;
            }
            else
            {
                // Picture is deselected
                selectedPicture = null;
            }

            // Uncheck other radio buttons
            foreach (var item in pictures)
            {
                if (item != picture)
                {
                    item.IsSelected = false;
                }
            }
        }

        private void DeleteSelected(object sender, EventArgs e)
        {
            if (selectedPicture != null)
            {
                pictures.Remove(selectedPicture);
                selectedPicture = null;
            }
        }

        private async void Image_Tapped(object sender, EventArgs e)
        {
            // Handle the StackLayout click event here
            var stackLayout = (StackLayout)sender;
            var picture = (PictureWithLikesAndDislikes)stackLayout.BindingContext;

            // Perform the desired action, e.g., navigate to a new page with picture details
            await Navigation.PushAsync(new ImageItem
            {
                BindingContext = picture
            });
        }



    }

}

