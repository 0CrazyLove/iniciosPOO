using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Valentina", 14, "negro"));
            animals.Add(new Dog("Salazar", 18, "moreno"));
            animals.Add(new Cat("alejandro", 16, "blanco"));
            animals.Add(new Cat("Sandy", 17, "blanco"));

            Console.WriteLine("Lista de perros:");

            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    animal.DisplayInfo();
                    animal.MakeSound();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Lista de catos:");

             foreach (Animal animal in animals)
             {
                if (animal is Cat)
                {
                 animal.DisplayInfo();
                 animal.MakeSound();
                }
             }
 



        }
    }
}