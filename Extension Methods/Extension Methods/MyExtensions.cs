using System;


namespace Extension_Methods
{
    public static class MyExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static bool IsPrime(this int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsDivisibleBy(this int number, int divisor)
        {
            try { 
                return number / divisor!=0;
            }
            catch (DivideByZeroException)
            {
            Console.WriteLine("Cannot divide by zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }
            return false;
        }
    }
}

