using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio14
{

    class Animal
    {
        public int num = 1;

        public Animal(int num)
        {
            this.num = num;

        }
        public void Display()
        {
            Console.WriteLine($"NUMERO: {num}");
        }


    }


}