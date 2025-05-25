using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>();
            paymentMethods.Add(new CreditCardPayment("12345678"));
            paymentMethods.Add(new CashPayment());

            foreach (IPaymentMethod pay in paymentMethods)
            {
                pay.ProcessPayment(4431);
                System.Console.WriteLine(pay.GetDetails()); 
            }

        }
    }
}