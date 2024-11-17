using Polygon.Interfaces;


namespace Polygon.Shapes;

public class Trapezium : ICalculateParameters
{
    public double LengthOfFirstParallelBase { get; set; }
    public double LengthOfSecondParallelBase { get; set; }


    public double LengthOfFirstParallelSide { get; set; }
    public double LengthOfSecondParallelSide { get; set; }
    public double Height { get; set; }
    public double Area { get; set; }
    public double Perimeter { get; set; }
    public double CalculateArea()
    {
        return Area = 0.5*(LengthOfFirstParallelBase+ LengthOfSecondParallelBase) * Height;
    }

    public double CalculatePerimeter()
    {
        return Perimeter = (LengthOfFirstParallelBase + LengthOfSecondParallelBase + LengthOfFirstParallelSide + LengthOfSecondParallelSide);
    }
}