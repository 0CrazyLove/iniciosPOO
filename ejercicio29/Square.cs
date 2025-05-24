using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class Square : GeometricFigure
    {
         //atributos propios de la clase derivada
        private double side;
        //propiedad publica de radio
        public Square(string name, string color, double side) : base(name, color)
        {
            Side = side;
        }
        public double Side
        {
            get { return side; }
            set
            {
                if (value <= 0)
                {
                    System.Console.WriteLine("no se permite valores negtivos o nulos");
                }
                else
                {
                    this.side = value;
                }
            }
        }
        override public void CalculateArea()
        {
            double radioFigure = Side * Side;
            System.Console.WriteLine($"el area del {Name} es: {radioFigure}");
            System.Console.WriteLine("----------------------------");
        }
        
        
        


    }
}