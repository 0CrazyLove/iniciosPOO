using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio14
{
    class Animal
    {
        private string name;
        private int age;
        private string type;

        public Animal(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }

        //metodo get y set de name
        public string Name
        {
            //pripiedad exponer (get)

            get { return name; }

            //propieda de remplazar/cambiar datos (set)
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    Console.WriteLine("Error: No valido o nulo");

                }
                else
                {
                    name = value;

                }

            }

        }
        //mdrodo get y set de age
        public int Age
        {
            get { return age; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Error. no se permiten numeros negativos");
                }
                else
                {

                    age = value;
                }

            }

        }

        //mdtodo get y set de type
        public string Type
        {

            get { return type; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error. Vuleva a introducir su tipo");
                }
                else
                {

                    type = value;
                }

            }

        }


        //metodo para monstrar informacion
        public void DisplayInfo()
        {
            Console.WriteLine($"Nombre del animal: {Name}");
            Console.WriteLine($"edad de {Name}: {Age}");
            Console.WriteLine($"tipo de animal: {Type}");

        }

    }


}