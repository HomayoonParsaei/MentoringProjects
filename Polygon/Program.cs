using Polygon.Shapes;

while (true) // Infinite loop; will exit when user chooses
{
    Console.WriteLine("Please Select the Shape you want to calculate the Area and Perimeter :\n");
    Console.WriteLine("1.Circle\n2.Triangle\n3.Square\n4.Rectangle\n5.Parallelogram\n6.Trapezium\n7.Ellipse\n");
    int selectedShape = int.Parse(Console.ReadLine());
    Console.WriteLine("\n");
    switch (selectedShape)
    {
        case 1:
            var c = new Circle();
            Console.WriteLine("Please enter the Radius : ");
            c.Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {c.CalculateArea():F2}\nPerimeter = {c.CalculatePerimeter():F2}\n");
            break;
        case 2:
            var tri = new Triangle();
            Console.Write("Please enter Base : ");
            tri.Base = double.Parse(Console.ReadLine());

            Console.Write("Please enter Height : ");
            tri.Height = double.Parse(Console.ReadLine());

            Console.Write("Please enter FirstSide : ");
            tri.FirstSide = double.Parse(Console.ReadLine());

            Console.Write("Please enter SecondSide : ");
            tri.SecondSide = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {tri.CalculateArea():F2}\nPerimeter = {tri.CalculatePerimeter():F2}\n");
            break;

        case 3:
            var sq = new Square();
            Console.WriteLine("Please enter Length : ");
            sq.LengthOfSide = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {sq.CalculateArea():F2}\nPerimeter = {sq.CalculatePerimeter():F2}\n");
            break;

        case 4:
            var rec = new Rectangle();
            Console.WriteLine("Please enter Length : ");
            rec.Length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Width : ");
            rec.Width = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {rec.CalculateArea():F2}\nPerimeter = {rec.CalculatePerimeter():F2}\n");
            break;

        case 5:
            var par = new Parallelogram();
            Console.WriteLine("Please enter Base : ");
            par.Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Vertical Height : ");
            par.VerticalHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Side : ");
            par.Side = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {par.CalculateArea():F2}\nPerimeter = {par.CalculatePerimeter():F2}\n");
            break;

        case 6:
            var tra = new Trapezium();
            Console.WriteLine("Please enter Length of first parallel base : ");
            tra.LengthOfFirstParallelBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Length of second parallel base : ");
            tra.LengthOfSecondParallelBase = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {tra.CalculateArea():F2}\nPerimeter = {tra.CalculatePerimeter():F2}\n");
            break;


        case 7:
            var ell = new Ellipse();
            Console.WriteLine("Please enter Length of Major Axis : ");
            ell.MajorAxis = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Length of Minor Axis : ");
            ell.MinorAxis = double.Parse(Console.ReadLine());

            Console.WriteLine($"Area = {ell.CalculateArea():F2}\nApproximate Perimeter ~ {ell.CalculatePerimeter():F2}\n");
            break;

        default:
            Console.WriteLine("Please Enter valid number.");
            break;
    }
}

