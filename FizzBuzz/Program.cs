using FizzBuzz;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<IDivisibilityChecker> checkers = new List<IDivisibilityChecker>
        {
            new FizzChecker(),
            new BuzzChecker()
           // new FizzBuzzChecker()
        };

        for (int i = 1; i <= 100; i++)
        {
            string result = string.Empty;

            foreach (var checker in checkers)
            {
                result += checker.IsDividable(i);
            }

            Console.WriteLine(!string.IsNullOrEmpty(result) ? result : i.ToString());
        }
    }
}

