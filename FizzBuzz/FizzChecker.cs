

namespace FizzBuzz
{
    public class FizzChecker : IDivisibilityChecker
    {
        public string IsDividable (int number)
        {
            return number % 3 == 0 ? "Fizz" : string.Empty;
        }
    }
}
