using System;

namespace POO.Library.Inheritance
{

    public class Square : GeometricFigure
    {
        private double _side;

        private double side
        {

            get => _side;
            set => _side = ValidateSide(value);
        }

        private double ValidateSide(double side, double minSide = 10)
        {
            if (side < minSide)
            {
                throw new Exception(
                    $"The side: {side:F2}, is less than the minimum allowed ({minSide:F2})."
                );
            }

            return side;
        }

        public Square(string name, double _side)
        {
            Name = name;
            side = _side;
        }

        public override double CalculateArea()
        {
            return side * side;
        }

        public override double CalculatePerimeter()
        {
            return 4 * side;
        }
    }

}