using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        //Crear una clase que represente un perro, con propiedades básicas y un método que imprima una descripción
        //del perro.
        static void Main(string[] args)
        {
            Perro dog = new Perro();
            dog.name = "miguel";
            dog.race = "labrador";
            dog.age= 19;
            dog.displayInformation();

            Perro dog2 = new Perro();
            dog2.name = "nike";
            dog2.race = "negro";
            dog2.age = 15;
            dog2.displayInformation();



        }
    }
}
