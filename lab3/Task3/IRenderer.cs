using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public interface IRenderer
    {
        void Render(string shape);
    }
    public class VectorRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as vectors.");
        }
    }
    public class RasterRenderer : IRenderer
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Drawing {shape} as pixels.");
        }
    }
}
