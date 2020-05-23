using System;
using System.Collections.Generic;
using System.Text;

namespace Class_interface
{
    public enum FigureType { square, circle, triangle}
    public abstract class Figure
    {
        public double Perimeter { get; set; }
        public double Area { get; set; }
        public FigureType TypeFigure { get; set; }
        public Figure( double perimeter, double area, FigureType typeFigure)
        {
            Perimeter = perimeter;
            Area = area;
            TypeFigure = typeFigure;
        }
    }
}
