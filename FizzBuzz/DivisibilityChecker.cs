#nullable disable

namespace FizzBuzz
{
    public static class DivisibilityChecker
    {
        public static int InputNumber { get; set; }

        public static bool IsDivisibleBy3()
        {
            return InputNumber % 3 == 0;
        }

        public static bool IsDivisibleBy5()
        {
            return InputNumber % 5 == 0;
        }

    }
}
