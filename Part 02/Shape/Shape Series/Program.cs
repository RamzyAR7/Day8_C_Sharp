using Shape_Series.Abstract;
using Shape_Series.Classes;
using Shape_Series.Interface;
using System;

namespace Shape_Series
{
    internal class Program
    {
        //Create a Shape Series
        public static void PrintTenShapes(IShapeSeries series)
        {
            Console.WriteLine($"display the first 10 areas of {series.GetType().Name}");
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine($"area {i + 1} ==> {series.CurrentShapeArea}");
            }
            series.ResetSeries();
        }
        //  Implement Your Own Sorting
        public static void SelectionSort<T>(T [] numbers) where T : IComparable<T>
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j].CompareTo(numbers[j + 1]) > 0)
                    {
                        Swap(ref numbers[j], ref numbers[j + 1]);
                    }
                }
            }
        }
        public static void Swap<T>(ref T n1, ref T n2)
        {
            T temp = n1;
            n1 = n2;
            n2 = temp;
        }
        static void Main(string[] args)
        {
            IShapeSeries squareSeries = new SquareSeries();
            IShapeSeries circleSeries = new CircleSeries();

            PrintTenShapes(squareSeries);
            Console.WriteLine();
            PrintTenShapes(circleSeries);

            Console.WriteLine("============================================");
            //Implement Sorting for Shapes

            Shape[] shapes =
            {
                new Shape("Square", 20.5),
                new Shape("Circle", 6.65),
                new Shape("Rectangle", 10.54)
            };

            Array.Sort(shapes);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
            Console.WriteLine("============================================");

            //Extend the Shape Hierarchy

            GeometricShape triangle = new Triangle(3, 2);
            Console.WriteLine("Triangle");
            Console.WriteLine($"Area ==> {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter ==> {triangle.Perimeter}");
            Console.WriteLine("-----------------------------------------");

            GeometricShape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Rectangle");
            Console.WriteLine($"Area ==> {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter ==> {rectangle.Perimeter}");

            Console.WriteLine("===============================================");

            //  Implement Your Own Sorting

            int[] numbers = { 8, 4, 6, 9, 11, 3, 0 };

            SelectionSort(numbers);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-----------------------------------------------");
            SelectionSort(shapes);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.WriteLine("===============================================");
            //  Implement Factory Pattern

            GeometricShape rectangle2 = ShapeFactory.CreateShape("rectangle", 5, 10);
            Console.WriteLine(rectangle2);
            Console.WriteLine("--------------");
            GeometricShape triangle2 = ShapeFactory.CreateShape("triangle", 4, 6);
            Console.WriteLine(triangle2);
        }
    }
}
