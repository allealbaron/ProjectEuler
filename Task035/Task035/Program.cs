using System;
using System.Linq;
using Utilities.Math;

namespace Task035
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            const int MAX_NUMBER = 1000000;

            PrimeNumber.CalculateTermsUntilValue(MAX_NUMBER);

            int result = (from p in PrimeNumber.GetListPrimes()
                          where PrimeNumber.IsCircularPrime(p)
                          select p).Count();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
