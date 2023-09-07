using System;
using System.Collections.Generic;
using Xamarin.Forms;
using lab2project.Models;
using lab2project;
using lab2_project;
using System.Collections.ObjectModel;
using System.Linq;

namespace lab2project
{
    public partial class ImageRating : ContentPage
    {


        public ImageRating()
        {
            InitializeComponent();

            var mainPage = ((App.Current.MainPage as NavigationPage)?.CurrentPage as MainPage);
            if (mainPage != null)
            {
                ObservableCollection<PictureWithLikesAndDislikes> pictures = mainPage.pictures;
                var sortedPictures = pictures.OrderByDescending(p => p.Likes - p.Dislikes).ToList();

                ratingCollectionView.ItemsSource = sortedPictures;
            }
            

            

     



        }
    }
}