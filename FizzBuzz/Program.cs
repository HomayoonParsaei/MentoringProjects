
using FizzBuzz;

Console.WriteLine("Plese entter the number");

DivisibilityChecker.InputNumber = int.Parse(Console.ReadLine());
var fizz = DivisibilityChecker.IsDivisibleBy3();
var buzz =DivisibilityChecker.IsDivisibleBy5();
FizzBuzzResult(fizz,buzz);

FizzBuzzResult
