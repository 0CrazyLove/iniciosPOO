using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio15
{
    class Designer : Employee
    {
        //constructor

        public Designer(string name, int age, decimal salaryBase, int levelCreativity) : base(name, age, salaryBase)
        {
            LevelCreativity = levelCreativity;

        }

        //atrinbuto principal de la clase derivada
        private int levelCreativity;

        //propiedad de levelCreativity

        public int LevelCreativity
        {

            get { return levelCreativity; }
            set
            {
                if (value <= 0 || value > 10)
                {
                    Console.WriteLine($"Error. el numero: {value} no esta entre el 1 al 10");

                }
                else
                {
                    this.levelCreativity = value + 00;


                }

            }

        }

        //sobre escribiendo el metodo CalculateSalary


        public override decimal CalculateSalary()
        {

            return SalaryBase + LevelCreativity;


        }
        //sobre escribiendo DisplayInfo para Designer


        public override void DisplayInfo()
        {
            Console.WriteLine("Diseñador:");
            Console.WriteLine($"nombre del desarrolador: {Name}");
            Console.WriteLine($"edad de {Name}: {Age}");
            Console.WriteLine($"Salario base mas bono: {CalculateSalary()}COP");
            Console.WriteLine($"Nivel de creatividad: {LevelCreativity - 00}");
            Console.WriteLine("---------------------------------------------");

        }

    }

}