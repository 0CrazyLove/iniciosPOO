using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio12
{
    class Vehicle
    {
        protected string brand; //"brand" significa vehiculo en ingles


        public Vehicle(string brand)
        {
            this.brand = brand;
        }

        public void DisplayInformation()
        {
            Console.WriteLine($"este vehiculo es de la marca {brand}");
        }

    }

    class Car : Vehicle
    {
        public Car(string brand) : base(brand)
        {

        }

        public void Iformation() {
            Console.WriteLine($"este vehiculo de la marca: {brand} enciende");
        


        }
    
    
    }


}
