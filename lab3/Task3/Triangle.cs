using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            renderer.Render("Triangle");
        }
    }
}
