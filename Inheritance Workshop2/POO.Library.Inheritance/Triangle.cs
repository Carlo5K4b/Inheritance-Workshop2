
using System;

namespace POO.Library.Inheritance
{
    public class Triangle : GeometricFigure
    {

        private double _base;
        private double _height;
        private double _side1;
        private double _side2;

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
        private double side1
        {
            get;
            set;
        }
        private double side2
        {
            get;
            set;
        }

        public Triangle(string name, double _base, double _height, double _side1, double _side2)
        {
            Name = name;
            Base = _base;
            height = _height;
            side1 = _side1;
            side2 = _side2;
        }

        public override double CalculateArea()
        {

            return (height * side2) / 2;

        }

        public override double CalculatePerimeter()
        {

            return Base + side1 + height;
        }
    }
}