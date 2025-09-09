using System;

namespace POO.Library.Inheritance
{
    public class Parallelogram : GeometricFigure
    {

        private double _base;
        private double _height;
        private double _side;

        private double Base
        {

            get;
            set;
        }

        private double height
        {

            get;
            set;
        }

        private double side
        {

            get;
            set;
        }

        public Parallelogram(string name, double _base, double _height, double _side)
        {
            Name = name;
            Base = _base;
            height = _height;
            side = _side;
        }

        public override double CalculateArea()
        {
            return Base * height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Base + side);
        }
    }
}
