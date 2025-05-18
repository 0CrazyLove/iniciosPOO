using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Dog : Animal
    {
        private string race;

        public Dog(string name, int age, string race) : base(name, age)
        {
            Race = race;
        }
        
        public string Race
        {
            get { return race; }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.race = value;
                }
                else
                {
                    Console.WriteLine("Error. Raza no valida.");
                }
            }

        }

        public override void MakeSound()
        {
            Console.WriteLine("Guau Gau!!");
        }







        
    }



}