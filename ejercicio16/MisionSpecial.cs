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

        public MisionSpecial(string name, int durationDays)
        {
            Name = name;
            DurationDays = durationDays;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Error. Vuelva escribir su nombre");

                }
                else
                {
                    this.name = value;
                }

            }
        }
        public int DurationDays
        {
            get { return durationDays; }
            set
            {
                if (!(value <= 0))
                {
                    this.durationDays = value;
                }
                else
                {
                    Console.WriteLine("no se permite valores negativos");
                    this.durationDays = 0;
                }
            }
        }

        public abstract void ExeCuteMision();
        public void decriptionInfo()
        {
            Console.WriteLine($"mision: {Name} durara {DurationDays} dias");
        } 
    }
    class MisionExploracion : MisionSpecial
    {
        public MisionExploracion(string name, int durationDays, string destinationPlanet) : base(name, durationDays)
        {
            this.destinationPlanet = destinationPlanet;
            
        }
        protected string destinationPlanet;

        public override void ExeCuteMision()
        {
            Console.WriteLine($"Planeta destino: {destinationPlanet}");
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }

    class MisionInvestigation : MisionSpecial
    {
        protected string ExperimentMain;
        public MisionInvestigation(string name, int durationDays, string ExperimentMain) : base(name, durationDays)
        {
            this.ExperimentMain = ExperimentMain;
        }

        public override void ExeCuteMision()
        {

            Console.WriteLine($"Experimento pricipal: {ExperimentMain}");
        }



    }
    

    













    
}
