using DAY8_C_Sharp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    internal class Rectangle : Shape
    {
        public  double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
           return Width * Height;
        }
    }
}
