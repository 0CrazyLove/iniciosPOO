using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio37
{
    class Cat : Animal, ISound
    {
        public Cat()
        {
            name = "gatico";
        }
        public void MakeSound()
        {
            System.Console.WriteLine("SOY UN GATOOOOO");

        }

        public override void DisplayType()
        {
            System.Console.WriteLine($"el tipo de animal es: {name}");

        }


    }
}