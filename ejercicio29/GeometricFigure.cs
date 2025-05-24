using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{

    abstract class GeometricFigure
    {
        //atributos protected de la clase
        protected string name = String.Empty;
        protected string color = String.Empty;
        //constructor
        public GeometricFigure(string name, string color)
        {
            Name = name;
            Color = color;
        }

        //propiedad publica de name
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("no se permite valores nulos.");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        //propiedad publica de color
        public string Color
        {
            get { return color; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("no se permite valores nulos en colores.");
                }
                else
                {
                    this.color = value;
                }
            }
        }
        //metodo abstracto
        abstract public void CalculateArea();
        //metodo virual
        public virtual void DisplayInfo()
        {
            System.Console.WriteLine($"Nombre: {Name}");
            System.Console.WriteLine($"Color de la figura {Name}: {Color}");
            System.Console.WriteLine("----------------------------------------");
        }

        

    }
}



