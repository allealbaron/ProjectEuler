using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task041
{
    class Program
    {
        /// <summary>
        /// Max number
        /// </summary>
        private const int MAX_NUMBER = 9999999;

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            PrimeNumber.CalculateTermsUntilValue(MAX_NUMBER);

            List<Int64> solution = (from p in PrimeNumber.GetListPrimes()
                    where ((p.ToString().Length == 4) || (p.ToString().Length == 7)) 
                        && Pandigital.IsPandigital(p)
                     select p).ToList();

            Console.WriteLine("Solution: {0}", solution.Max());

        }
    }
}