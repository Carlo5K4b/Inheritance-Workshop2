using POO.Library.Inheritance;
using System;

namespace POO.Library.Inheritance
{
    public class Trapeze : GeometricFigure
    {
        private double _base1;
        private double _base2;
        private double _height;
        private double _side1;
        private double _side2;

        private double Base1
        {
            get;
            set;
        }
        private double Base2
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

        public Trapeze(string name, double _base1, double _base2, double _height, double _side1, double _side2)
        {
            Name = name;
            Base1 = _base1;
            Base2 = _base2;
            height = _height;
            side1 = _side1;
            side2 = _side2;
        }

        public override double CalculateArea()
        {
            return (Base1 * Base2 * side1);

        }

        public override double CalculatePerimeter()
        {
            return Base1 + Base2 + side1 + height;
        }
    }
}
