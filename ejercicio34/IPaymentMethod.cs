using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio34
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount); //amount es cantidad en ingles
        string GetDetails();

    }
}
