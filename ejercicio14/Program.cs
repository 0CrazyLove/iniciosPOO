using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando de clases derivadas de las clase base(Cat)
            Cat cat = new Cat("Miguel", 19, "Domestico", "Blanco");
            cat.DisplayInfo();
            cat.DisplayColor();
            Console.WriteLine("-------------------");
            //instanciando de clases derivadas de las clase base(Dog)

            Dog dog = new Dog("Axel", 16, "Salvaje", "Labrador");
            dog.DisplayInfo();
            dog.DisplayRace();

            
        }
    }
}
