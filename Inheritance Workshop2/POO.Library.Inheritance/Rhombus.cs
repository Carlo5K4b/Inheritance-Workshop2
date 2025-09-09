using System;

namespace POO.Library.Inheritance
{
    public class Rhombus : GeometricFigure
    {
        private double _diagonal1;
        private double _diagonal2;
        private double _side;

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
        private double side
        {

            get;
            set;
        }



        public Rhombus(string name, double _diagonal1, double _diagonal2, double _side)
        {
            Name = name;
            diagonal1 = _diagonal1;
            diagonal2 = _diagonal2;
            side = _side;
        }

        public override double CalculateArea()
        {
            return (diagonal2 * side) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 4 * diagonal1;
        }
    }
}
