using System;
using Task4;

class Program
{
    static void Main(string[] args)
    {
        Image fileSystemImage = new Image(new FileSystemImageLoadingStrategy());
        fileSystemImage.Load(@"C:\Users\Ростислав\Desktop\test.png");

        fileSystemImage.SetLoadingStrategy(new NetworkImageLoadingStrategy());
        fileSystemImage.Load("https://example.com/image.jpg");
    }
}
