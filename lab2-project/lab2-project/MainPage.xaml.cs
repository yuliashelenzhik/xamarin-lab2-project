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
        public ObservableCollection<PictureWithLikesAndDislikes> pictures = new ObservableCollection<PictureWithLikesAndDislikes>();
        private PictureWithLikesAndDislikes selectedPicture;

        public MainPage()
        {
            InitializeComponent();
            pictureListView.ItemsSource = pictures;
        }

        private void AddPicture(object sender, EventArgs e)
        {
            string imageName = imageNameEntry.Text;
            string imageUrl = imageUrlEntry.Text;

           
            pictures.Add(new PictureWithLikesAndDislikes { Id = pictures.Count + 1, Name = imageName, ImageUrl = imageUrl });

           
            imageNameEntry.Text = imageUrlEntry.Text = string.Empty;


        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            var picture = (PictureWithLikesAndDislikes)radioButton.BindingContext;

            if (e.Value)
            {
             
                selectedPicture = picture;
            }
            else
            {
                selectedPicture = null;
            }

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

            var stackLayout = (StackLayout)sender;
            var picture = (PictureWithLikesAndDislikes)stackLayout.BindingContext;

            await Navigation.PushAsync(new ImageItem
            {
                BindingContext = picture
            });
        }



    }

}