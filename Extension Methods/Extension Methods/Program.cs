using System;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to test: ");
            int number = GetInput();

            Console.WriteLine("\n{0} is odd: {1}", number, number.IsOdd());
            Console.WriteLine("{0} is even: {1}", number, number.IsEven());
            Console.WriteLine("{0} is prime: {1}", number, number.IsPrime());

            Console.Write("\nEnter a divisor to test: ");
            int divisor = GetInput();
            Console.WriteLine("\n{0} is divisible by {1}: {2}", number, divisor, number.IsDivisibleBy(divisor));
        }
        static int GetInput()
        {
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                input = GetInput();
            }
            return input;
        }

    }
}
