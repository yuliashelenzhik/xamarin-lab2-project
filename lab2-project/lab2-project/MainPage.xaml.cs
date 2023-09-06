using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2project.Models;
using Xamarin.Forms;

namespace lab2_project
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<PictureModel> pictures = new ObservableCollection<PictureModel>();
        private PictureModel selectedPicture;

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
            pictures.Add(new PictureModel { Id = pictures.Count + 1, Name = imageName, ImageUrl = imageUrl });

            // Clear the entry fields
            imageNameEntry.Text = imageUrlEntry.Text = string.Empty;
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            var picture = (PictureModel)radioButton.BindingContext;

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

        //private void DeleteSelected(object sender, EventArgs e)
        //{
        //    if (selectedPicture != null)
        //    {
        //        // Remove the selected picture from the collection
        //        pictures.Remove(selectedPicture);
        //        selectedPicture = null;
        //    }
        //}

        //private void pictureListView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (e.Item is PictureModel selected)
        //    {
        //        selectedPicture = selected;
        //    }
        //}


    }

}

