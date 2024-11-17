using Polygon.Interfaces;

namespace Polygon.Shapes;

public class Square : ICalculateParameters
{
    public double LengthOfSide { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }
    public double CalculateArea()
    {
        return Area = LengthOfSide * LengthOfSide;
    }

    public double CalculatePerimeter()
    {
        return Perimeter = 4*LengthOfSide;
    }
}