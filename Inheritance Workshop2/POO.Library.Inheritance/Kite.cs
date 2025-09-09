using System;

namespace POO.Library.Inheritance
{
    public class Kite : GeometricFigure
    {
        private double _diagonal1;
        private double _diagonal2;
        private double _side1;
        private double _side2;

        private double diagonal1
        {

            get;
            set;
        }
        private double diagonal2
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



        public Kite(string name, double _diagonal1, double _diagonal2, double _side1, double _side2)
        {
            Name = name;
            diagonal1 = _diagonal1;
            diagonal2 = _diagonal2;
            side1 = _side1;
            side2 = _side2;
        }

        public override double CalculateArea()
        {
            return (diagonal2 * side1) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (diagonal1 + side2);
        }
    }
}
