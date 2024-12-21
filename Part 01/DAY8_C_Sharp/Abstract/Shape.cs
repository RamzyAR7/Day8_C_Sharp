using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.Abstract
{
    internal abstract class Shape
    {
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine($"the Area of Shape is  : {GetArea()}");
        }
    }
}
