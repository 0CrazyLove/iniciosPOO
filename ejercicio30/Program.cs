using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAniaml aniaml1 = new Dog();
            IAniaml aniaml2 = new Cat();
            aniaml1.makeSound();
            aniaml2.makeSound();
        }
    }
}