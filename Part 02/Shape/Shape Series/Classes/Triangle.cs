using Shape_Series.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Classes
{
    internal class Triangle : GeometricShape
    {
        public Triangle(double dimension1, double dimension2) : base(dimension1, dimension2) { }

        public override double Perimeter {
            get
            {
                return Dimension1 * 3;
            }
        }
        public override double CalculateArea()
        {
           return 0.5 * Dimension1 * Dimension2;
        }
    }
}
