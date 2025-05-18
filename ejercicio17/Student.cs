using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Student
    {
        public string name;
        public int age;

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
                    Console.WriteLine("Error. no se permite valores negativos");
                }
            }
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nombre: {Name} \n edad: {Age}");
        }

        




    }
    
        
}