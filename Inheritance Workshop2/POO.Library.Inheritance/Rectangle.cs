using System;

namespace POO.Library.Inheritance
{
    public class Rectangle : GeometricFigure
    {

        private double _base;
        private double _height;

        private double Base
        {

            get => _base;
            set => _base = ValidateBase(value);
        }

        private double height
        {

            get => _height;
            set => _height = ValidateHeight(value);
        }

        private double ValidateBase(double value, double minBase = 4.568)
        {
            if (value < minBase)
            {
                throw new Exception(
                    $"The base: {value:F2}, is less than the minimum allowed ({minBase:F2})."
                );
            }

            return value;
        }

        private double ValidateHeight(double value, double minHeight = 67.790)
        {
            if (value < minHeight)
            {
                throw new Exception(
                    $"The height: {value:F2}, is less than the minimum allowed ({minHeight:F2})."
                );
            }

            return value;
        }


        public Rectangle(string name, double _base, double _height)
        {
            Name = name;
            Base = _base;
            height = _height;
        }

        public override double CalculateArea()
        {
            return Base * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Base + height);
        }

    }
}
