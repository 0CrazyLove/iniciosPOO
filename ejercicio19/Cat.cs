using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Cat : Animal
    {
        private string color;

        public Cat(string name, int age, string color) : base(name, age)
        {
            Color = color;
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.color = value;
                }
                else
                {
                    Console.WriteLine("Error. Color no valido del gato");

                }
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meaw Meaw soy un gato MEAWWWWA");
        }


    } 

}