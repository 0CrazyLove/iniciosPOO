using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorFigure gestorFigure = new GestorFigure();
            Circle circle = new Circle("circulo", "azul", 12);
            Square square = new Square("cuadrado", "amarillo", 10);
            Triangle triangle = new Triangle("triangulo", "rojo", 10, 10);
            gestorFigure.AddFigure(circle);
            gestorFigure.AddFigure(square);
            gestorFigure.AddFigure(triangle);
            gestorFigure.DisplayFigures();
            gestorFigure.AreaTotales();
        }
    }
}