using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    abstract class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.name = value;

                }
                else
                {
                    Console.WriteLine("Error. nombre no valido");
                }

            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (!(value <= 0))
                {
                    this.age = value;

                }
                else
                {
                    Console.WriteLine("Error. no se permite numeros negativos");
                }

            }
        }

        abstract public void MakeSound();
        public void DisplayInfo()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Edad: {Age}");
        }


    }

}

