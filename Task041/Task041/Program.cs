using System;
using System.Collections.Generic;
using System.Linq;

namespace Task041
{
    class Program
    {
        /// <summary>
        /// List of calculated prime numbers
        /// </summary>
        static readonly List<Int64> primes = new List<Int64>() { 2 };

        /// <summary>
        /// Special primes
        /// </summary>
        static readonly List<Int64> specialPrimes = new List<Int64>();

        /// <summary>
        /// Max number
        /// </summary>
        const Int64 MAX_NUMBER = 9999999;

        /// <summary>
        /// Returns if a number is prime
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if the number is prime, false otherwise</returns>
        static bool IsPrime(Int64 number)
        {
            bool isPrime = true;

            int i = 1;

            while (isPrime && i < primes.Count && primes[i] <= Math.Sqrt(number))
            {
                isPrime = (number % primes[i] != 0);
                i++;
            }

            return isPrime;

        }

        /// <summary>
        /// Checks if a number is Pandigital
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Returns true if the number is pandigital</returns>
        static bool IsPandigital(Int64 number)
        {
            Dictionary<Int64, int> repeatedNumbers =
                                                 (number.ToString().ToCharArray()
                                                     .GroupBy(c => c)
                                                     .ToDictionary(
                                                         c => Int64.Parse(c.Key.ToString()),
                                                         c => c.Count()));

            bool result = true;

            for (int j = 1; result && j <= number.ToString().Length; j++)
            {
                result = repeatedNumbers.ContainsKey(j);
            }

            return result;

        }

        static void Main()
        {

            Int64 i = 3;

            while (i < MAX_NUMBER)
            {
                if (IsPrime(i))
                {

                    primes.Add(i);

                    /*
                     * Pandigital formed by 2, 3, 5, 6, 8, 9 digits are divisible by 3, ergo,
                     * they can not be primes.
                     * 12 -> 1 + 2 = 3
                     * 123 (132, 213, 231, 312, 321) -> 1 + 2 + 3 = 6
                     * We have to check only 4 and 7 digit pandigital numbers.
                     */
                    if ((i >= 1000 && i <= 9999) || (i >= 1000000 && i <= 9999999))
                    {
                     
                        if (IsPandigital(i))
                        {
                            specialPrimes.Add(i);
                        }
                    }
                }

                i += 2;

            }

            Console.WriteLine("Solution: {0}", specialPrimes.Max());

        }
    }
}