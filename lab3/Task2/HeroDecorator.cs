using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class HeroDecorator : Hero
    {
        protected Hero _hero;

        public HeroDecorator(Hero hero)
        {
            _hero = hero;
        }

        public override void Display()
        {
            _hero.Display();
        }
    }

}
