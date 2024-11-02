

namespace RegularPolygon.Classes
{
    public class PolygonPerimeterCalculator
    {
        private uint _numberOfEdges;
        public uint NumberOfEdges
        {
            set { NumberOfEdges = value; }
        }

        private uint _sideLength;
        public uint SideLenght
        {
            set { SideLenght = value; }
        }

        private uint _perimeter;
        public uint Perimeter
        {
            get { return _perimeter; }
        }

        public uint CalculatePerimeter(uint NumberOfEdges, uint SideLenght)
        {
            return _perimeter = NumberOfEdges * SideLenght;
        }
    }

}
