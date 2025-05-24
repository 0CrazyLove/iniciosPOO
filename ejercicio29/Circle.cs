using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Circle : GeometricFigure
    {
        //atributos propios de la clase derivada
        private double radio;
        //propiedad publica de radio
        public Circle(string name, string color, double radio) : base(name, color)
        {

            Radio = radio;
        }
        public double Radio
        {
            get { return radio; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("no se permite valores negtivos o nulos");
                }
                else
                {
                    this.radio = value;
                }
            }
        }
        override public void CalculateArea()
        {
            double radioFigure = Math.PI * Math.Pow(Radio, 2);
            System.Console.WriteLine($"el area del {Name} es: {radioFigure}");
            System.Console.WriteLine("----------------------------------");
        }
        
    



    }
}
