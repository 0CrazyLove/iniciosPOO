using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    class ServicePhotograph : Service
    {
        //atributo propio de la clase
        protected int amountPhotos;
        protected decimal PricePhotoExtra = 50.000m;

        //constructor
        public ServicePhotograph(string name, string description, decimal priceBase, int amountPhotos) : base(name, description, priceBase)
        {
            AmountPhotos = amountPhotos;

        }
        //propiedad publica de amountPhotos
        public int AmountPhotos
        {
            get { return amountPhotos; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("no se permite valores nulos en la cantidad de fotos");
                }
                else
                {
                    this.amountPhotos = value;
                }

            }
        }
        //metodos sobre escritos para esta clase
        public override decimal CalculatePriceFinish()
        {
            decimal PriceFinish = PriceBase + (AmountPhotos * PricePhotoExtra);
            return PriceFinish;

        }

        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Nombre del fotografo: {Name}");
            System.Console.WriteLine($"Descripcion del fotografp: {Description}");
            System.Console.WriteLine($"Precio base: {PriceBase}");
            System.Console.WriteLine($"Cantidad de fotos: {AmountPhotos}");
            System.Console.WriteLine($"Precio por fotos extras: {PricePhotoExtra}");
            System.Console.WriteLine($"Precio final: {CalculatePriceFinish}");
        }


    }
}