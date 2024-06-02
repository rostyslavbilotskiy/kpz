using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FileSystemImageLoadingStrategy : IImageLoadingStrategy
    {
        public void LoadImage(string href)
        {
            if (File.Exists(href))
            {
                Console.WriteLine($"Loading image from file system: {href}");
                // Логіка завантаження зображення з файлової системи
            }
            else
            {
                Console.WriteLine($"Image file not found in file system: {href}");
            }
        }
    }
}
