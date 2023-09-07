using System;
using System.Collections.Generic;
using lab2project;
using lab2project.Models;
using Xamarin.Forms;

namespace lab2project
{	
	public partial class ImageItem : ContentPage
	{	
		public ImageItem ()
		{
			InitializeComponent ();
		}

        private void Liked(object sender, EventArgs e)
        {
            var picture = (PictureWithLikesAndDislikes)((Button)sender).BindingContext;
            picture.Likes++; // Increment the likes count
        }

        private void Disliked(object sender, EventArgs e)
        {
            var picture = (PictureWithLikesAndDislikes)((Button)sender).BindingContext;
            picture.Dislikes++; // Increment the dislikes count
        }
    }
}

