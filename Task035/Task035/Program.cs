using System;
using System.Collections.Generic;
using System.Linq;

namespace Task035
{
    class Program
    {
        /// <summary>
        /// List of calculated prime numbers
        /// </summary>
        static readonly List<Int64> primes = new List<Int64>() { 2 };

        /// <summary>
        /// Returns if a number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if the number is prime, false otherwise</returns>
        static bool IsPrime(Int64 number)
        {
            bool isPrime = true;

            int i = 0;

            while (isPrime && i < primes.Count && primes[i] <= Math.Sqrt(number))
            {
                isPrime = (number % primes[i] != 0);
                i++;
            }

            return isPrime;

        }

        /// <summary>
        /// Returns if <paramref name="number"/> is a circular prime
        /// (Example 197, 971 and 719 are primes)
        /// </summary>
        /// <param name="number">Number to evaluate</param>
        /// <returns>True or false</returns>
        static bool IsCircularPrime(Int64 number)
        {
            bool IsCircular = true;

            if (number > 10)
            {
                string numberAsString = number.ToString();
                for (int i =0; IsCircular && i< numberAsString.Length;i++)
                {
                    int borderIndex = numberAsString.Length - i - 1;
                    string nextNumber = numberAsString.Substring(borderIndex) + numberAsString.Substring(0, borderIndex);
                    IsCircular = IsPrime(Int64.Parse(nextNumber));
                }
            }

            return IsCircular;
        }

        static void Main()
        {
            const int MAX_NUMBER = 1000000;

            int i = 3;

            while (i < MAX_NUMBER)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }

                i += 2;

            }

            int result = (from p in primes
                    where IsCircularPrime(p)
                    select p).Count();

            Console.WriteLine("Solution: {0}", result);
        }
    }
}
