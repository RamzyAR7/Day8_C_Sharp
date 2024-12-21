using Shape_Series.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Classes
{
    internal class SquareSeries : IShapeSeries
    {
        private int sidelength;
        public int CurrentShapeArea {  get; set; }

        public SquareSeries()
        {
            ResetSeries();
        }
        public void GetNextArea()
        {
            CurrentShapeArea = sidelength * sidelength;
            sidelength++;
        }

        public void ResetSeries()
        {
            sidelength = 1;
            CurrentShapeArea = 0;
        }
    }
}
