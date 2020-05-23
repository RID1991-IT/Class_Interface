using System;
using System.Collections.Generic;
using System.Text;

namespace Class_interface
{
    public class Circle:Figure, IСount
    {
        public double Radius { get; set; }
        public const double Pi = 3.14;
        public Circle(double perimeter, double area, FigureType typeFigure, double radius) : base(perimeter, area, typeFigure)
        {
            Radius = radius;
        }
        public double PerimetrCount()
        {
            Perimeter = 2 * Pi * Radius;
            return Perimeter;
        }
        public double AreaCount()
        {
            Area = 2 * Pi * (Radius * Radius);
            return Area;
        }
    }
}
