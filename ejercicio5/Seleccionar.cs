using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    public class Seleccionar
    {
        public string Select;
        public Salary SalaryUsuario;
        Precios priceArticle = new Precios();

        public Seleccionar(string select , Salary salaryUsuario)
        {
            Select = select;
            SalaryUsuario = salaryUsuario;

        }


        

        public void SelectArticle()
        {
            if (Select.ToLower() == "shampo" || Select.ToLower() == "crema" || Select.ToLower() == "escala")
            {
                if (Select.ToLower() == "shampo" && priceArticle.Shampo < SalaryUsuario.SalaryUsuario)
                {
                    Console.WriteLine("gracias por su compra");
                }
                else if (Select.ToLower() == "crema" && priceArticle.Crema < SalaryUsuario.SalaryUsuario)
                {

                    Console.WriteLine("gracias por su compra");
                }
                else if (Select.ToLower() == "escala" && priceArticle.Escala < SalaryUsuario.SalaryUsuario)
                {
                    Console.WriteLine("gracias por su compra");

                }
                else
                {
                    Console.WriteLine("saldo insuficiente");
                }



            }
        }
    }
}

