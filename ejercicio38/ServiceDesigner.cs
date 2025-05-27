using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    class ServiceDesigner : Service
    {
        //constructor
        public ServiceDesigner(string name, string description, decimal priceBase) : base(name, description, priceBase)
        {

        }
        //metodos sobre escritos y propios de la clase ServiceDesigner
        
        public override decimal CalculatePriceFinish()
        {
            decimal bonus = PriceBase * 1.10m;

            return bonus;
        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Nombre del diseñador: {Name}");
            System.Console.WriteLine($"Descripcion del diseñador: {Description}");
            System.Console.WriteLine($"Precio base: {PriceBase}");
            System.Console.WriteLine($"Precio final: {CalculatePriceFinish}");
        }

    }
}
