using System;
using System.Collections.Generic;
using System.Text;

namespace Class_interface
{
    public class Triangle : Figure, IСount
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Height { get; set; }
        public Triangle(double perimeter, double area, FigureType typeFigure, double side1, double side2, double side3,double height) : base(perimeter, area, typeFigure)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Height = height;
        }
        public double PerimetrCount()
        {
            Perimeter = Side1+Side2+Side3;
            return Perimeter;
        }
        public double AreaCount()
        {
            Area = 0.5*Height*Side1;
            return Area;
        }
    }
}
