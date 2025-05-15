using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio14
{
    class Dog : Animal
    {
        //atributo de la clase derivada
    protected string race;



    public string Race
    {
        get { return race; }

        set
        {

            if (String.IsNullOrEmpty(value))
            {


                Console.WriteLine("Error, el color no es valido.");

            }
            else
            {
                this.race = value;
            }

        }



    }
    //constructor

    public Dog(string name, int age, string type, string race) : base(name, age, type)
    {
        Race = race;

    }


    //metodo para monstrar la raza

    public void DisplayRace()
    {
        Console.WriteLine($"Raza del perro: {race}");

    }
        



    }
}
