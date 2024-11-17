using RegularPolygon.Interfaces;

namespace RegularPolygon;

public class Parallelogram : ICalculateParameters
{
    public double Base { get; set; }
    public double VerticalHeight { get; set; }
    public double Side { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }

    public double CalculateArea()
    {
        return Area = Base * VerticalHeight;
    }

    public double CalculatePerimeter()
    {
        return Perimeter =2*(Base*Side);
    }
}