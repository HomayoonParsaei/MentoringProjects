using Polygon.Interfaces;
using System;

namespace Polygon.Shapes;

public class Ellipse : ICalculateParameters
{
    const double pi = Math.PI;
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }

    public double CalculateArea()
    {
        return Area=0.5* MajorAxis*MinorAxis*pi;
    }

    public double CalculatePerimeter()
    {
        return Perimeter = pi * (3 * (MajorAxis + MinorAxis) - Math.Sqrt((3 * MajorAxis + MinorAxis) * (MajorAxis + 3 * MinorAxis)));
    }

 

}