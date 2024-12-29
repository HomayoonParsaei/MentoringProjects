

namespace FizzBuzz
{
    public class BuzzChecker : IDivisibilityChecker
    {
        public string IsDividable (int number)
        {
            return number % 5 == 0 ? "Buzz" : string.Empty;
        }
    }
}
