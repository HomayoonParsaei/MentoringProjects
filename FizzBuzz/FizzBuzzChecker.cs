

namespace FizzBuzz
{
    public class FizzBuzzChecker : IDivisibilityChecker
    {
        public string IsDividable (int number)
        {
            return number % 15 == 0 ? "FizzBuzz" : string.Empty;
        }
    }
}
