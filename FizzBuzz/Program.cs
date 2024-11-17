
using FizzBuzz;
while (true) 
{
    Console.Write("Plese enter the number : ");

    DivisibilityChecker.InputNumber = int.Parse(Console.ReadLine());
    var fizz = DivisibilityChecker.IsDivisibleBy3();
    var buzz = DivisibilityChecker.IsDivisibleBy5();

    if (fizz && buzz)
    {
        Console.WriteLine("FizzBuzz!\n");
    }

    else if (buzz)
    {
        Console.WriteLine("Buzz!\n");
    }
    else if (fizz)
    {
        Console.WriteLine("Fizz!\n");
    }
    else
    {
        Console.WriteLine("No FizzBuzz!!\n");
    }
}
