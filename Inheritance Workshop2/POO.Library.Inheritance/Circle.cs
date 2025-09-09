using System;
using System.Xml.Linq;

namespace POO.Library.Inheritance
{
    public class Circle : GeometricFigure
    {

        private double _radius;
        private double radius
        {

            get => _radius;
            set => _radius = ValidateRadius(value);
        }

        public Circle(string name, double _radius)
        {
            Name = name;
            radius = _radius;

        }

        private double ValidateRadius(double radius)
        {
            const double MinRadius = 5.0;

            if (radius < MinRadius)
            {
                throw new Exception(
                    $"The radius: {radius:F2}, is less than the minimum radius ({MinRadius:F5})."
                );
            }

            return radius;
        }


        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
