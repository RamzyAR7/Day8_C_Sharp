using DAY8_C_Sharp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    internal class Circle : Shape
    {
        public double Redius { get; set; }
        public Circle(double redius) 
        {
            Redius = redius;
        }

        public override double GetArea()
        {
            return Math.PI * Redius * Redius;
        }

    }
}
