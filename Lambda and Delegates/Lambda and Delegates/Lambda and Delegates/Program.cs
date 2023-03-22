using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_and_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // 1. Find odd - Lambda Expression – without curly brackets
            var odds = numbers.Where(n => n % 2 == 1);
            Console.WriteLine("Odd numbers: " + string.Join(", ", odds));

            // 2. Find Even - Lambda Expression – with curly brackets
            var evens = numbers.Where(n =>
            {
                return n % 2 == 0;
            });
            Console.WriteLine("Even numbers: " + string.Join(", ", evens));

            // 3. Find Prime – Anonymous Method
            var primes = numbers.Where(delegate (int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            });
            Console.WriteLine("Prime numbers: " + string.Join(", ", primes));

            // 4. Find Prime Another – Lambda Expression
            Func<int, bool> isPrime = n =>
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            };
            var primes2 = numbers.Where(isPrime);
            Console.WriteLine("Prime numbers (another way): " + string.Join(", ", primes2));

            // 5. Find Elements Greater Than Five – Method Group Conversion Syntax

            Predicate<int> greaterThanFive = x => x > 5;
            var greater = numbers.FindAll(greaterThanFive);
            Console.WriteLine("Numbers greater than 5: " + string.Join(", ", greater));

            // 6. Find Less than Five – Delegate Object in Where – Method Group Conversion Syntax in Constructor of Object
            var lessThanFive = numbers.Where(x => x < 5);
            Console.WriteLine("Numbers less than 5: " + string.Join(", ", lessThanFive));

            // 7. Find 3k – Delegate Object in Where –Lambda Expression in Constructor of Object 
            var threeK = numbers.Where(new Func<int, bool>(n => n % 3 == 0));
            Console.WriteLine("Numbers divisible by 3: " + string.Join(", ", threeK));

            // 8. Find 3k + 1 - Delegate Object in Where –Anonymous Method in Constructor of Object
            var modOne = numbers.Where(delegate (int x)
            {
                return (x - 1) % 3 == 0;
            });
            Console.WriteLine("Numbers of the form 3k+1: " + string.Join(", ", modOne));

            // 9. Find 3k + 2 - Delegate Object in Where –Lambda Expression Assignment
            Func<int, bool> threeKPlusTwo = n => (n - 2) % 3 == 0;
            var threeKPlusTwoNumbers = numbers.Where(threeKPlusTwo);
            Console.WriteLine("Numbers of the form 3k + 2: " + string.Join(", ", threeKPlusTwoNumbers));

        }
    }
}
