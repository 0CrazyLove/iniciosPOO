using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MisionExploracion misionExploracion = new MisionExploracion("jungla", 15, "planeta jungla");
            misionExploracion.decriptionInfo();
            misionExploracion.ExeCuteMision();

            MisionInvestigation misionInvestigation = new MisionInvestigation("selva", 20, "investigar fenomenos");
            misionInvestigation.decriptionInfo();
            misionInvestigation.ExeCuteMision();
        }
    }
}
