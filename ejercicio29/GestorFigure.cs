using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio29
{
    class GestorFigure
    {
        private List<GeometricFigure> geometricFigures;
        public GestorFigure()
        {
            geometricFigures = new List<GeometricFigure>();
        }
        //metodo para agregar figuras a una lista
        public void AddFigure(GeometricFigure geometricFigure)
        {
            geometricFigures.Add(geometricFigure);
        }
        //metodos para mostrar las figuras
        public void DisplayFigures()
        {
            foreach (GeometricFigure geometricFigure in geometricFigures)
            {
                geometricFigure.DisplayInfo();
            }
        }
        //metodos para mostrar areas totales
        public void AreaTotales()
        {
            foreach (GeometricFigure geometricFigure in geometricFigures)
            {
                geometricFigure.CalculateArea();
            }
        }

    }
}