using System;
using System.Collections.Generic;
using System.Linq;

namespace Task010
{
    class Program
    {
        /// <summary>
        /// List of calculated prime numbers
        /// </summary>
        static readonly List<Int64> primes = new List<Int64>() {2};

        /// <summary>
        /// Returns if a number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if the number is prime, false otherwise</returns>
        static bool IsPrime(Int64 number)
        {
            bool isPrime = true;

            int i = 1;

            while (isPrime && i<primes.Count && primes[i] <= Math.Sqrt(number))
            {
                isPrime = (number % primes[i] != 0);
                i++;
            }

            return isPrime;

        }

        static void Main()
        {
            const int MAX_NUMBER = 2000000;

            int i = 3;

            while (i < MAX_NUMBER)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }

                i += 2;

            }

            Console.WriteLine("Solution: {0}", primes.Sum());

        }
    }
}
