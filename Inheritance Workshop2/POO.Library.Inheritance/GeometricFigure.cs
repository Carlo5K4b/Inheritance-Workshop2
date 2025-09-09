using System;
using System.Globalization;

namespace POO.Library.Inheritance
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return string.Format(
        "  {0,-14}  => {1,-8} {2,15:N5} {3,-4}  {4,-6} {5,14:N5}",
        Name, "Area ..... :", CalculateArea(),
        "", "Perimeter :", CalculatePerimeter()
    );
        }
    }
}
