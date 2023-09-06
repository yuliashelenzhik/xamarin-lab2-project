using System;
using Xamarin.Forms;

namespace lab2project.Models
{
    public class PictureModel : BindableObject
    {
        private bool isSelected;

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}







