

namespace RegularPolygon.Classes
{
    public class PolygonAreaCalculator
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

        private double _area;
        public double Area
        {
            get { return _area; }
        }

        public double CalculateArea(uint NumberOfEdges, double SideLenght)
        {
            return _area = NumberOfEdges * Math.Pow(SideLenght, 2) / (4 * Math.Tan(Math.PI / NumberOfEdges));
        }
    }
}
