using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Artifact : HeroDecorator
    {
        public Artifact(Hero hero) : base(hero)
        {
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Carrying artifact.");
        }
    }

}
