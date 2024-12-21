using DAY8_C_Sharp.Abstract;
using DAY8_C_Sharp.CLasses;
using DAY8_C_Sharp.Interface;
using DAY8_C_Sharp.Struct;
using System;

namespace DAY8_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem01
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.StartEngine();
            car.StopEngine();

            bike.StartEngine();
            bike.StopEngine();

            /**
             * Why is it better to code against an interface rather than a concrete class?
             * 
             * because it promotes flexibility, reduces coupling, supports polymorphism, 
             * and makes code easier to test and extend. It focuses on "what" the code should do, not "how,"
             * aligning with solid design principles like the Dependency Inversion and Open/Closed principles.
             */
            #endregion

            #region Problem02
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(10, 8);
            circle.Display();
            rectangle.Display();


            /**
             * When should you prefer an abstract class over an interface? 
             * 
             * Prefer an abstract class when:
             *   You need to share common behavior or state across related classes.
             *   You want to provide a default implementation for some methods.
             *   The classes have an "is-a" relationship and share a base hierarchy.
             * Use interfaces when you only need to define a contract for unrelated classes to implement, or when multiple inheritance is required.
             */
            #endregion

            #region Problem03
            Product[] products =
            {
                new Product(1, "Pasta", 20),
                new Product(2, "Tea", 15),
                new Product(4, "Suger", 19),
                new Product(3, "Chips", 17)
            };

            Array.Sort(products);
            Console.WriteLine("=======================================");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product}, ");
            }

            /**
             * 
             * How does implementing IComparable improve flexibility in sorting? 
             * 
             * Implementing IComparable improves flexibility in sorting by allowing you to define custom sorting logic based on the specific attributes of your class (e.g., `Price` for a `Product`).
             * This way, you can sort objects in different ways without modifying the sorting code itself, just by changing the `CompareTo` method. It also allows you to use standard sorting methods 
             * like `Array.Sort`, which automatically apply your custom comparison logic.
             */
            #endregion

            #region Problem04
            Student s1 = new Student(1, "ahmed", 95);

            Console.WriteLine("===========================================================");


            Student scopy = s1; // shallow copy
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(scopy.GetHashCode());
            Console.WriteLine("------------------------------------");
            Student s2 = new Student(s1); // deep copy
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine($"s2 ==> {s1}");
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine($"s2 ==> {s2}");

            /**
             * What is the primary purpose of a copy constructor in C#?
             * 
             * The primary purpose of a copy constructor in C# is to create a new instance of a class that is a duplicate of an existing object.
             * It initializes the new object with the same values as the original, ensuring that the copy is independent of the original (especially for complex types or objects with references).
             * This is useful for performing deep copies or when you need a separate instance with identical data.
             * 
             */

            #endregion

            #region Problem05
            Console.WriteLine("============================================================");
            IWalkable robot = new Robot();
            robot.Walk();

            Robot robot1 = new Robot();
            //robot1.Walk(); // error
            robot1.Watch();

            /**
             * How does explicit interface implementation help in resolving naming conflicts? 
             * 
             * allowing you to implement methods from multiple interfaces with the same method name without causing ambiguity.
             * When a class implements multiple interfaces that define the same method, explicit implementation ensures that each method can be accessed through its specific interface reference, preventing name clashes in the class itself.
             */
            #endregion

            #region Problem06
            Account c1 = new Account(1, "ramzy", 5005.25);

            Console.WriteLine("==========================================================");
            Console.WriteLine(c1.Balance);
            c1.Balance = 100000;
            Console.WriteLine(c1.Balance);

            /**
             * What is the key difference between encapsulation in structs and classes?
             * 
             * Structs:
             * encapsulate data and provide the same access control (private fields, public properties),
             * but because they are value types, they are copied when passed to methods.
             * 
             * Classes:
             * also encapsulate data, but since they are reference types, they are passed by reference,
             * meaning changes to a class instance affect all references to that instance.
             */


            /**
             *  what is abstraction as a guideline, what’s its relation with encapsulation? 
             *  
             * Abstraction:
             * is the concept of hiding complex implementation details and showing only the essential features of an object or system.
             * It focuses on "what" an object does rather than "how" it does it. In programming, abstraction is typically implemented using abstract classes or interfaces.
             * 
             * Encapsulation:
             * on the other hand, is the practice of hiding an object's internal state and requiring all interaction to occur through well-defined methods or properties.
             * It focuses on "how" the data is protected and accessed.
             */

            #endregion

            #region Problem07
            Console.WriteLine("==============================================");
            ILogger logger = new ConsoleLogger();
            logger.Log();// log from  ConsoleLogger

            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(); // log from  ConsoleLogger

            /**
             * How do default interface implementations affect backward compatibility in C#?
             * 
             * Default interface implementations in C# allow you to add new methods to an interface without breaking existing implementations.
             * This ensures backward compatibility, as existing classes are not required to implement the new method.
             * If needed, classes can override the default method to provide custom behavior. 
             * This approach helps evolve interfaces without forcing changes in all implementing classes.
             */

            #endregion

            #region Problem08

            Console.WriteLine("===============================");
            Book book1 = new Book();
            Console.WriteLine(book1);

            Book book2 = new Book("C# Programming");
            Console.WriteLine(book2);

            Book book3 = new Book("Head First Java", "Kathy Sierra");
            Console.WriteLine(book3);


            /**
             * How does constructor overloading improve class usability?
             * 
             * Constructor overloading improves class usability by providing multiple ways to instantiate an object,
             * depending on the available data. It allows users of the class to create objects with different levels of detail 
             * (e.g., with or without certain parameters) without needing to use additional setter methods or change the class structure.
             * This makes the class more flexible and easier to use in different scenarios.
             */
            #endregion
        }
    }
}
