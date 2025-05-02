using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Animal
    {
        //atributo protegido
        protected string name;

        //constructor
        public Animal(string name)
        {
            this.name = name;
        }
        public void Breathe()
        {
            Console.WriteLine($"{name} esta respirando");
        }
    }

    //clase derivada
    class Perro : Animal
    {
        public Perro(string name) : base(name)
        {
        }
        //metodo exclusivo de la clase hija
        public void Bark()
        {
            Console.WriteLine($"{name} esta ladrando");



        }
    }






}
