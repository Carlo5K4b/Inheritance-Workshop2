  
using POO.Library.Inheritance;
using System;

namespace POO.ConsoleApp.Inheritance
{
    public class Pr_Geometry
    {
        public Pr_Geometry() { }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("                                         === GEOMETRIC FIGURES ===");
            Console.WriteLine("");
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("");

            var circle = new Circle(nameof(Circle), 5);
            var square = new Square(nameof(Square), 10);
            var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
            var kite = new Kite(nameof(Kite), 7, 6, 5, 8);
            var rectangle = new Rectangle(nameof(Rectangle), 4.568, 67.790);
            var parallelogram = new Parallelogram(nameof(Parallelogram), 54.67, 23.09, 14.65);
            var triangle = new Triangle(nameof(Triangle), 45.56, 12.34, 27.09, 15);
            var trapeze = new Trapeze(nameof(Trapeze), 10, 20, 30, 40, 20);

            var figures = new List<GeometricFigure>() { circle, square, rhombus, kite, rectangle, parallelogram, triangle, trapeze };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure);

            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("...................................=== A great success by CARLOS BELTRÁN ===..........................");
            Console.WriteLine("======================================================================================================");
            Console.WriteLine("");

            Console.WriteLine("  Hello, the program has ended..");
            Console.ReadKey();
        }
    }
}

