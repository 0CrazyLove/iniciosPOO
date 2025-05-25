using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio32
{
    class Duck : IFlying, ISwimmer, IAge
    {
        public void Fly()
        {
            System.Console.WriteLine("el pato esta cuelando <3");
        }
        public void Swim()
        {
            System.Console.WriteLine("el pato esta nadando alrevez");
        }
        public void Age(int age)
        {
            System.Console.WriteLine($"la edad del pato es:{age} ");
        }


    }


}