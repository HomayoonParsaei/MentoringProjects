using Polygon.Interfaces;
using System;

namespace Polygon.Shapes;

public class Circle : ICalculateParameters
{
    const double pi = Math.PI;
    public double Radius { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }

    public double CalculateArea()
    {
        return Area = 2 * pi * Radius;
    }

    public double CalculatePerimeter()
    {
        return Perimeter = pi * Radius * Radius;//Math.Pow(Radius, 2)
    }

}