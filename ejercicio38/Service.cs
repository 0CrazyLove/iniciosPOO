using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    abstract class Service : IService
    {
        //atributos privados de la clase
        private string name = String.Empty;
        private string description = String.Empty;
        private decimal priceBase;
        

        //constructor
        public Service(string name, string description, decimal priceBase)
        {
            Name = name;
            Description = description;
            PriceBase = priceBase;
        }

        //pripiedad publica para name
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("No se permite valores nulos o vacios en el nombre.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        //pripiedad publica para description
        public string Description
        {
            get { return description; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("No se permite valores nulos o vacios en la descripcion.");
                }
                else
                {
                    this.description = value;
                }
            }
        }

        //pripiedad publica para description
        public decimal PriceBase
        {
            get { return priceBase; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("No se permite valores negativos o nulos.");
                }
                else
                {
                    this.priceBase = value;
                }
            }
        }
        //metodos abstracto
        abstract public decimal CalculatePriceFinish();
        abstract public void DisplayInfo();
        

    }
}
