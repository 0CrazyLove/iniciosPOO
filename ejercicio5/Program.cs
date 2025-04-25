using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escoje que articulo quieres comprar: \n 1)shampo: 12,000 \n 2)crema: 18.300 \n 3)escala: 14.200");
            Console.WriteLine("cual es tu salario?");
            double SalaryInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Salary salaryUsuario = new Salary(SalaryInput);
            Console.WriteLine($"su salario es: {salaryUsuario.SalaryUsuario.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.Write("Seleccione su articulo: ");
            string select = Console.ReadLine();
            Seleccionar selectArticle = new Seleccionar(select , salaryUsuario);
            selectArticle.SelectArticle();


            //no terminado.

        }
    }
}
