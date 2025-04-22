using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Person
    {
        public string name;
        public int age;

        public void greet() //greet es saludar
        {

            Console.WriteLine($"hola mi nombre es {name} y tengo {age} años");
        }           


    }
}
