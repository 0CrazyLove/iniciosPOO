using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio14
{
    
class Cat : Animal
{

    //atributo de la clase derivada gato

    protected string color;
    //pripiedad get y set

    public string Color
    {


        get { return color; }
        set
        {


            if (String.IsNullOrEmpty(value))
            {


                Console.WriteLine("Error, el color no es valido.");

            }
            else
            {
                this.color = value;
            }

        }


    }

    //contrusctor
    public Cat(string name, int age, string type, string color) : base(name, age, type)
    {  

        Color = color;

    }

    //metodo para monstrar informacion
    public void DisplayColor()
    {

        Console.WriteLine($"Color del gato: {color}");


    }



}
}