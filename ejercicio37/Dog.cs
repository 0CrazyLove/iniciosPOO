using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio37
{
    class Dog : Animal, ISound
    {
        public Dog()
        {
            name = "perrito";
        }
        public void MakeSound()
        {
            System.Console.WriteLine("esto es UN PERROOO");
        }
        public override void DisplayType()
        {
            System.Console.WriteLine($"el tipo de animal es:{name}");
        }


    }
}