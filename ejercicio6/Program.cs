using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persona1 = new Person("Miguel", 19);
            Console.WriteLine($"Nombre: {persona1.GetName()}");
            Console.WriteLine($"Edad: {persona1.GetAge()}");
            persona1.SetName("Axel");
            persona1.SetAge(20);
            Console.WriteLine($"nuevo nombre: {persona1.GetName()}");
            Console.WriteLine($"nueva edad: {persona1.GetAge()}");
            persona1.SetAge(2); // prueba de la validacion de edad negativa
         
            

        }
    }
}
