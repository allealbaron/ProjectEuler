using System;
using System.Collections.Generic;
using System.Linq;

namespace Task087
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

        static void Main()
        {

            const int MAX_NUMBER = 50000000;

            int cont = 3;

            while (cont < Math.Sqrt(MAX_NUMBER)+1)
            {
                if (IsPrime(cont))
                {
                    primes.Add(cont);
                }

                cont += 2;

            }

            HashSet<double> solutions = new HashSet<double>();

            for (int i = 0; i < primes.Count; i++)
            {
                double firstPow = Math.Pow(primes[i], 2);

                if (firstPow <= MAX_NUMBER)
                {
                    for (int j = 0; j < primes.Count; j++)
                    {
                        double secondPow = Math.Pow(primes[j], 3);
                        if (firstPow + secondPow <= MAX_NUMBER)
                        {
                            for (int k = 0; k < primes.Count; k++)
                            {
                                double result = firstPow + secondPow + Math.Pow(primes[k], 4);
                                if (result <= MAX_NUMBER)
                                {
                                    solutions.Add(result);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Solution: {0}", solutions.Count());
        }
    }
}
