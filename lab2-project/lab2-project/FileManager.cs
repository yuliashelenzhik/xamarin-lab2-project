using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace lab2project
{
	public class FileManager
	{
        public async Task SaveFileAsync(string data)
        {
            try
            {
                string fileName = "file.txt";
                string filePath = Path.Combine(FileSystem.AppDataDirectory, fileName);

                using (StreamWriter writer = File.CreateText(filePath))
                {
                    await writer.WriteAsync(data);
                }
               
                await DisplayAlert("File Saved", "The file has been saved successfully.", "OK");
            }
            catch (Exception ex)
            {            
                await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
            }
        }

        private async Task DisplayAlert(string title, string message, string buttonText)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, buttonText);
        }
    }
}

