using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class OpinionUsuario
    {
        public string Opinion;


        public OpinionUsuario(string opinion)
        {
            Opinion = opinion;
        }



        public void OpinionAnswer()
        {

            if (Opinion.Equals("si"))
            {
                Console.Write("->");
         
            } else if (Opinion.Equals("no"))
            {
                Console.WriteLine("Gracias por tu tiempo");
                Environment.Exit(0);//este metodo termina el programa
            }
            else
            {
                Console.WriteLine("No valido.");
                Environment.Exit(0);//este metodo termina el programa
            }


        }



    }
}
