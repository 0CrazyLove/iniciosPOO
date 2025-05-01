using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su numero de cuenta: ");
            //input numero de cuenta
            string numberAccount = Console.ReadLine();
            //input del titular
            Console.Write("Ingrese el nombre del titular de la cuenta banacaria: ");
            string titler = Console.ReadLine();
            //input del salario
            double salary = 0;
            string input;
            do
            {
                Console.Write("Por favor ingrese su salario: ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out salary));

            CuentaBancaria usuario1 = new CuentaBancaria(numberAccount, titler, salary);
            usuario1.DisplayInformation();
            Console.WriteLine("\n 1)¿Quieres depositar dinero? \n 2)¿Quiere hacer un retiro?");
            int answer = 0;
            try
            {
                answer = int.Parse(Console.ReadLine());

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error. Formato no valido {ex.Message}");

            }

            if (answer == 1)
            {
                Console.Write("Cantidad del deposito->");
                double depositMoney = 0;
                try
                {
                    depositMoney = double.Parse(Console.ReadLine());

                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error. Formato no valido {ex.Message}");

                }
                usuario1.Deposit(depositMoney);
                usuario1.DisplayInformation();

            }
            else if (answer == 2)
            {
                Console.Write("Cantidad del retiro->");
                double removeMoney = 0;
                try
                {
                    removeMoney = double.Parse(Console.ReadLine());

                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error. Formato no valido {ex.Message}");

                }
                usuario1.Remove(removeMoney);
                usuario1.DisplayInformation();


            }






        }
    }
}

