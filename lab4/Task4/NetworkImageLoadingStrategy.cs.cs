using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class NetworkImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            try
            {
                Console.WriteLine($"Loading image from network: {href}");
                using (WebClient client = new WebClient())
                {
                    // Логіка завантаження зображення з мережі
                    byte[] imageData = client.DownloadData(href);
                    Console.WriteLine("Image loaded successfully from network.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load image from network: {ex.Message}");
            }
        }
    }
}
