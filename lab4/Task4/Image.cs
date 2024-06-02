using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Image
    {
        private IImageLoadingStrategy _loadingStrategy;

        public Image(IImageLoadingStrategy loadingStrategy)
        {
            _loadingStrategy = loadingStrategy;
        }

        public void SetLoadingStrategy(IImageLoadingStrategy loadingStrategy)
        {
            _loadingStrategy = loadingStrategy;
        }

        public void Load(string href)
        {
            _loadingStrategy.LoadImage(href);
        }
    }
}
