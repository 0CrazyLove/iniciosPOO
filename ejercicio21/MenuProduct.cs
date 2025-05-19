using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio21
{
    class MenuProduct
    {
        private int selectNumber;
        public MenuProduct(int selectNumber)
        {
            SelectNumber = selectNumber;
        }


        public int SelectNumber
        {
            set
            {
                if (!(value < 1) || !(value > 6))
                {
                    this.selectNumber = value;
                }
                else
                {
                    Console.WriteLine("error. opcion no valida");
                }
            }
        }
        







    }


}