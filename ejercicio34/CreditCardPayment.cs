using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio34
{
    class CreditCardPayment : IPaymentMethod
    {
        private string cardNumber = String.Empty;

        public CreditCardPayment(string cardNumber)
        {
           CardNumber = cardNumber;
        }

        public string CardNumber
        {
            get{ return cardNumber; }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("error. Numero de tarjeta no valida");

                }
                else
                {
                    cardNumber = value.Substring(value.Length - 4);
                }
                
            }
        }

        public void ProcessPayment(double amount)
        {
            System.Console.WriteLine("se ha pagado con la tarjeta correctamente!");
            System.Console.WriteLine($"se ha pagado: ${amount}COP");

        }
        public string GetDetails()
        {
            return $"Pago con tarjeta terminada en {CardNumber} \n ----------------------------------------------------";
        }
    }

}
