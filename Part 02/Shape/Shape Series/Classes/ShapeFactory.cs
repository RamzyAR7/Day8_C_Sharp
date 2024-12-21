using Shape_Series.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Series.Classes
{
    internal class ShapeFactory
    {
        public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    return new Rectangle(dim1, dim2);
                case "triangle":
                    return new Triangle(dim1, dim2);
                default:
                    Console.WriteLine("Invalid shape type");
                    return null;
            }
        }
    }
}
