

namespace RegularPolygon.Classes
{
    public class PolygonPerimeterCalculator
    {
        private uint _numberOfEdges;
        public uint NumberOfEdges
        {
            set { NumberOfEdges = value; }
        }

        private double _sideLength;
        public double SideLenght
        {
            set { SideLenght = value; }
        }

        private double _perimeter;
        public double Perimeter
        {
            get { return _perimeter; }
        }

        public double CalculatePerimeter(uint NumberOfEdges, double SideLenght)
        {
            return _perimeter = NumberOfEdges * SideLenght;
        }
    }

}
