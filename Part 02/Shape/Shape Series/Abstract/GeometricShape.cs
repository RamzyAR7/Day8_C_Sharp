using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Abstract
{
    internal abstract class GeometricShape
    {
        public double Dimension1 { get; set; }

        public double Dimension2 { get; set; }
        public abstract double Perimeter { get; }

        protected GeometricShape(double dimension1, double dimension2)
        {
            Dimension1 = dimension1;
            Dimension2 = dimension2;
        }
        public abstract double CalculateArea();

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
    }
}
