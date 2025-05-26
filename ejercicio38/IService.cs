using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    interface IService
    {
        //metodo para mostrar la info
        void DisplayInfo();
        //metodo para caclular el precio final
        decimal CalculatePriceFinish();
    }
}