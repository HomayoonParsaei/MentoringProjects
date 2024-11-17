using Polygon.Interfaces;

namespace Polygon.Shapes;

public class Rectangle : ICalculateParameters
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }
    public double CalculateArea()
    {
        return Area=Length*Width;
    }

    public double CalculatePerimeter()
    {
        return Perimeter=2*(Length+Width);
    }
}