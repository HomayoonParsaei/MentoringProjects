using RegularPolygon.Classes;
using RegularPolygon.Enums;
using RegularPolygon.Enums.EnumsFrindlyText;
using System.Reflection.Metadata;

namespace RegularPolygon
{
    public partial class FormPolygon : Form
    {
        uint numberOfEdge;
        //change to real and positive
        uint sideLenght;
        uint perimeter;
        uint area;
        public FormPolygon()
        {
            InitializeComponent();
            SetComboBoxesDataSource();

        }

        //if  comboBoxPolygoneType.SelectedIndex <> -1 then 



        private void buttonCalculate_Click(object sender, EventArgs e)
        {

            if (CheckInputValue())
            {
                numberOfEdge = (uint)(PolygonName)Enum.Parse(typeof(PolygonName), comboBoxPolygoneType.Text);
                sideLenght = uint.Parse(textBoxSideLength.Text);

                PolygonPerimeterCalculator polygonPerimeterCalculator = new PolygonPerimeterCalculator();
                polygonPerimeterCalculator.CalculatePerimeter(numberOfEdge, sideLenght);
                labelPolygonPerimeter.Visible = true;
                labelPolygonPerimeter.Text = $"Perimeter = {polygonPerimeterCalculator.Perimeter} ";

                PolygonAreaCalculator polygonAreaCalculator = new PolygonAreaCalculator();
                polygonAreaCalculator.CalculateArea(numberOfEdge, sideLenght);
                lablePolygonArea.Visible = true;
                lablePolygonArea.Text = $"Area = {polygonAreaCalculator.Area:F2}";



            }
            else
            {
                MessageBox.Show("Please enter valid number!");
                return;
            }

        }

        public void SetComboBoxesDataSource()
        {
            //comboBoxPolygoneType.DataSource = PolygonNameFriendlyText.GetFriendlyTextList();
            comboBoxPolygoneType.DataSource = Enum.GetValues(typeof(PolygonName));
            comboBoxPolygoneType.SelectedIndex = -1;
        }
        //Make it one line if
        public bool CheckInputValue()
        {

            if (!string.IsNullOrEmpty(textBoxSideLength.Text) && uint.TryParse(textBoxSideLength.Text, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void comboBoxPolygoneType_SelectedIndexChanged(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Define the points of the polygon
            Point[] points = new Point[]
            {
                new Point(100, 50),  // Vertex 1
                new Point(150, 100), // Vertex 2
                new Point(125, 150), // Vertex 3
                new Point(75, 150),  // Vertex 4
                new Point(50, 100)   // Vertex 5
            };

            // Draw the polygon
            g.DrawPolygon(Pens.Black, points);    // Draw outline with black color

        }

       
    }
}
    




