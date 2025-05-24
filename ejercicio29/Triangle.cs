using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Triangle : GeometricFigure
    {
        //atributos propios de la clase derivada
        private double Base;
        private double height;
        //propiedad publica de radio
        public Triangle(string name, string color, double Base, double height) : base(name, color)
        {
            ProBase = Base;
            Height = height;
        }
        public double ProBase
        {
            get { return Base; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("no se permite valores negtivos o nulos");
                }
                else
                {
                    this.Base = value;
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("no se permite valores negtivos o nulos");
                }
                else
                {
                    this.height = value;
                }
            }
        }
        override public void CalculateArea()
        {
            double radioFigure = (ProBase * Height) / 2;
            System.Console.WriteLine($"el area del {Name} es: {radioFigure}");
            System.Console.WriteLine("--------------------------------------------");
        }
    }
}