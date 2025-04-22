using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    public class Perro
    {

        public string name;
        public string race;
        public int age;

        public void displayInformation()
        {
            Console.WriteLine($"Su nombre es {name} ,su raza es {race} y tiene {age} el perro ");
        }



    }
}
