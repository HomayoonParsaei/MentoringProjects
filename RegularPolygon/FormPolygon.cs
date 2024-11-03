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
        double sideLenght;
        double perimeter;
        double area;
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
                sideLenght = double.Parse(textBoxSideLength.Text);

                PolygonPerimeterCalculator polygonPerimeterCalculator = new PolygonPerimeterCalculator();
                polygonPerimeterCalculator.CalculatePerimeter(numberOfEdge, sideLenght);
                labelPolygonPerimeter.Visible = true;
                labelPolygonPerimeter.Text = $"Perimeter = {polygonPerimeterCalculator.Perimeter:F2} ";

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
      
        public bool CheckInputValue()
        {
           return (!string.IsNullOrEmpty(textBoxSideLength.Text) && double.TryParse(textBoxSideLength.Text, out _)) ;

        }

       
        }
       
    }

    




