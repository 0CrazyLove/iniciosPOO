using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ejercicio16
{
    abstract class MisionSpecial
    {
        private string name;
        private int durationDays;

        public abstract void ExeCuteMision();
        public void decriptionInfo()
        {
            Console.WriteLine("description general");

        } 
        

    }
    class MisionExploracion : MisionSpecial
    {
        protected string DestinationPlanet;
        public override void ExeCuteMision()
        {
            Console.WriteLine("mision de exploracion");
            Console.WriteLine("muyyy peligrosa ñejeje");
            Console.WriteLine("te amo chat gpt");





        }

    }
    class MisionInvestigation : MisionSpecial
    {
        protected string typeExperiment;

        public override void ExeCuteMision()
        {
            Console.WriteLine("mision de investigacion yo que se");
        }


        
    }
    

    













    
}
