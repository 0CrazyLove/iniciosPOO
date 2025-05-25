using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio34
{
    class CashPayment : IPaymentMethod
    {
        public void ProcessPayment(double mount)
        {
            System.Console.WriteLine("Se ha pagado con ejectivo!!!");
        }
         public string GetDetails(){

            return "Pago en efectivo.";
        }
    }
}