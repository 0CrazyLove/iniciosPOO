using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    class ServiceDeveloper : Service
    {
        //atributo protegido de la clase
        protected int hours;

        //constructor
        public ServiceDeveloper(string name, string description, decimal priceBase, int hours) : base(name, description, priceBase)
        {
            Hours = hours;

        }
        //propiedad publica de hours
        public int Hours
        {
            get { return hours; }
            set
            {
                if (value <= 0 || value > 24)
                {
                    throw new Exception("No se permites horas invalidas.");
                }
                else
                {
                    this.hours = value;
                }
            }
        }

        //metodos sobre escritos y propios de la clase ServiceDeveloper
        public override decimal CalculatePriceFinish()
        {
            decimal bonus = PriceBase * Hours;
            return bonus;
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"ID del servicio: {_ID}");
            System.Console.WriteLine($"Nombre del Programador: {Name}");
            System.Console.WriteLine($"Descripcion del Programador: {Description}");
            System.Console.WriteLine($"cantidad de horas: {Hours}");
            System.Console.WriteLine($"Precio base: {PriceBase}");
            System.Console.WriteLine($"Precio final: {CalculatePriceFinish()}");
            System.Console.WriteLine("--------------------------------");
        }
    }
}