using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task087
{
    class Program
    {

        static void Main()
        {

            const int MAX_NUMBER = 50000000;

            PrimeNumber.CalculateTermsUntilValue((int)(Math.Sqrt(MAX_NUMBER) + 1));

            HashSet<double> solutions = new HashSet<double>();

            List<Int64> primes = PrimeNumber.GetListPrimes();

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
