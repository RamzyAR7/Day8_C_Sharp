using Shape_Series.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Classes
{
    internal class Rectangle : GeometricShape
    {
        public Rectangle(double dimension1, double dimension2) : base(dimension1, dimension2) { }
        public override double Perimeter {
            get
            {
                return 2 * (Dimension1 *  Dimension2);
            }
        }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }
    }
}
