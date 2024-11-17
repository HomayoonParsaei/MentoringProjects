using RegularPolygon.Interfaces;

namespace RegularPolygon;

public class Triangle : ICalculateParameters
{
    public double Base { get; set; }
    public double Height { get; set; }
    public double FirstSide { get; set; }
    public double SecondSide { get; set; }

    public double Area { get; set; }
    public double Perimeter { get; set; }
    public double CalculateArea()
    {
        return Area = 0.5 * Base * Height;
    }

    public double CalculatePerimeter()
    {
        return Perimeter = (Base + FirstSide + SecondSide);
    }
}