using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task049
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            PrimeNumber.CalculateTermsUntilValue(10000);

            List<Int64> primes = PrimeNumber.GetListPrimes();

            string solution = (from p1 in primes
                               from p2 in primes
                               from p3 in primes
                               where p1 > 1487 && p2 - p1 == 3330 && p3 - p2 == 3330
                               && Permutation.ArePermutations(p1, p2)
                               && Permutation.ArePermutations(p2, p3)
                               select p1.ToString() + p2.ToString() + p3.ToString()).FirstOrDefault();

            Console.WriteLine("Solution: {0}", solution);

        }
    }
}
