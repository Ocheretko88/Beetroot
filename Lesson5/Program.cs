namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Calculator class
            var calculator = new Calculator();

            // Call the Max method
            Console.WriteLine("Max value among 5, 7, 12: " + calculator.Max(5, 7, 12));

            // Call the Min method
            Console.WriteLine("Min value among 5, 7, 12: " + calculator.Min(5, 7, 12));

            // Use the TrySumIfOdd method
            int sum;
            bool isOdd = calculator.TrySumIfOdd(5, 10, out sum);
            Console.WriteLine($"Sum between 5 and 10 is {sum}. Is it odd? {isOdd}");

            // Use the Repeat method
            Console.WriteLine(calculator.Repeat("str", 3));
        }
    }

    class Calculator
    {
        // Method to find max value among all parameters
        public int Max(params int[] numbers)
        {
            return numbers.Max(); // Use Linq's Max function to get the maximum value
        }

        // Method to find min value among all parameters
        public int Min(params int[] numbers)
        {
            return numbers.Min(); // Use Linq's Min function to get the minimum value
        }

        // Method to check if the sum of numbers between two numbers is odd or even
        public bool TrySumIfOdd(int a, int b, out int sum)
        {
            sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum % 2 != 0; // If the remainder when divided by 2 is not 0, it's odd.
        }

        // Method to repeat a string N times
        public string Repeat(string s, int n)
        {
            return string.Concat(Enumerable.Repeat(s, n)); // Use Linq's Repeat and String's Concat function to repeat the string
        }
    }
}