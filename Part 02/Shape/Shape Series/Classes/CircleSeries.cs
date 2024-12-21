using Shape_Series.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Classes
{
    internal class CircleSeries : IShapeSeries
    {
        private int redius;
        public int CurrentShapeArea {  get; set; }

        public CircleSeries()
        {
            ResetSeries();
        }
        public void GetNextArea()
        {
            CurrentShapeArea = (int)(Math.PI * redius * redius);
            redius++;
        }

        public void ResetSeries()
        {
            redius = 1;
            CurrentShapeArea = 0;
        }

    }
}
