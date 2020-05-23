using System;
using System.Collections.Generic;
using System.Text;

namespace Class_interface
{
    public class Sqare:Figure, IСount
    {
        public double Side { get; set; }
        public Sqare(double perimeter, double area, FigureType typeFigure,double side):base(perimeter, area, typeFigure)
        {
            Side = side;
        }
        public double PerimetrCount()
        {
            Perimeter = 4 * Side;
            return Perimeter;
        }
        public double AreaCount()
        {
            Area = Side * Side;
            return Area;
        }
    }
}
