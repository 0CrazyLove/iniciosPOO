using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    public class Auto
    {
        public string Brand; // "brand" significa "marca"
        public string Model; // "model" significa "modelo"
        public int Year; // "year" significa "año"

        public Auto(string brand , string model , int year)
        {
            Brand = brand;
            Model = model;
            Year = year;

        }

        public void displayInformation()
        {
            Console.WriteLine($"la marca del auto es: {Brand} , modelo: {Model} y su año de lanzamiento: {Year}");
        }

    }
}
