using System;
namespace lab2project.Models
{
    public class PictureWithLikesAndDislikes : PictureModel
    {
        private int likes;
        private int dislikes;
        public string ImageFilePath { get; set; }

        public int Likes
        {
            get { return likes; }
            set
            {
                if (likes != value)
                {
                    likes = value;
                    OnPropertyChanged(nameof(Likes));
                }
            }
        }

        public int Dislikes
        {
            get { return dislikes; }
            set
            {
                if (dislikes != value)
                {
                    dislikes = value;
                    OnPropertyChanged(nameof(Dislikes));
                }
            }
        }

        public PictureWithLikesAndDislikes()
        {
            Likes = 0; 
            Dislikes = 0; 
        }

        

    }
}

