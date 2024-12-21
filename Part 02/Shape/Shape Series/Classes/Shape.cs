using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Classes
{
    internal class Shape:IComparable<Shape>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public override string ToString()
        {
            return $"the Name of Shape : {Name}, and it's Area : {Area}";
        }

        int IComparable<Shape>.CompareTo(Shape other)
        {

            if (this.Area > other.Area)
            {
                return 1;
            }
            else if (this.Area < other.Area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
