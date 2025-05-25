using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlying duck = new Duck();
            duck.Fly();
            ISwimmer duckSwim = new Duck();
            duckSwim.Swim();
            IAge duckAge = new Duck();
            duckAge.Age(12);


        }
    }
}