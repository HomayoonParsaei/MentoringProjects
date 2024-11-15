using RegularPolygon.Interfaces;

namespace RegularPolygon;

public class Ellipse : ICalculateParameters
{
    const double pi = Math.PI;
    public double MinorAxis { get; set; }
    public double MajorAxis { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }

    public double CalculateArea()
    {
        return Area=0.5* MajorAxis*MinorAxis*pi;
    }

    public double CalculatePerimeter()
    {
        throw new NotImplementedException();
    }
}