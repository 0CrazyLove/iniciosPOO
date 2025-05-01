using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    public class CuentaBancaria
    {

        private string numberAccount;
        private string titler;
        private double salary;



        //constructor
        public CuentaBancaria(string NumberAccount, string Titiler, double Salary)
        {
            numberAccount = NumberAccount;
            titler = Titiler;
            salary = Salary;
        }


        //metodo para acceder"numberAccount"

        public string NumberAccount
        {
            get { return numberAccount; }

        }
        //metodo para acceder "titler"

        public string Titiler
        {
            get { return titler; }

        }
        //metodo para acceder y añadir "salary"
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("No se permite valores negativos.");

                }
                else
                {
                    salary = value;
                }
            }

        }
        //metodo para depositar dinero
        public void Deposit(double money) {
            if (money <= 0)
            {
                Console.WriteLine("No se permite valores negativos.");
            }
            else
            {
                Console.WriteLine("!Dinero recibido correctamente¡");
                Salary += money;
            }



        }
        //metodo para retirar dinero
        public void Remove(double removeMoney)
        {
            if(Salary > removeMoney)
            {
                Salary -= removeMoney;
            }
            else if(Salary < removeMoney)
            {
                Console.WriteLine("Error. Saldo insuficiente");
            }
            else if(removeMoney <=0)
            {
                Console.WriteLine("No se permite valores negativos.");

            }

        }
        //metodo para mostrar la informacion del cuenta
        public void DisplayInformation()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("                           informacion de la cuenta:");
            Console.WriteLine($"numero cuenta: {numberAccount}");
            Console.WriteLine($"titular: {titler}");
            Console.WriteLine($"salario total: {salary.ToString("f3")}");
            Console.WriteLine("-----------------------------------------------------------------------------");
        }





    }
}
