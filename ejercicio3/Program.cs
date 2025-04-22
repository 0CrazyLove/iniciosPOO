using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una clase llamada Auto que use un constructor personalizado para asignar los valores de marca,
            //modelo y año.

            Auto auto = new Auto("toyota" , "D2_2" , 1989); //esta informacion es falsa , me la invente :v
            Auto auto2 = new Auto("ford", "cc2-22", 2002); //esta informacion es falsa , me la invente :v x2

            auto.displayInformation();
            auto2.displayInformation();



        }
    }
}
