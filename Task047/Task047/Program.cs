using System;
using System.Collections.Generic;
using Utilities.Math;

namespace Task047
{
    class Program
    {
        /// <summary>
        /// Number of factors
        /// </summary>
        const int FACTORS = 4;

        /// <summary>
        /// Compares two dictionaries which contains integer factorizations
        /// </summary>
        /// <param name="d1">First Dictionary</param>
        /// <param name="d2">Second Dictionary</param>
        /// <returns>True if both elements contains <see cref="FACTORS"/> factors and different factors</returns>
        static bool CompareFactorizations(Dictionary<Int64, Int64> d1, Dictionary<Int64, Int64> d2)
        {
            if (d1.Count == FACTORS && d2.Count == FACTORS)
            {
                foreach (Int64 k1 in d1.Keys)
                {
                    if (d2.ContainsKey(k1) && d1[k1] == d2[k1])
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            bool itemNotFound = true;

            for (int i = 1; itemNotFound; i++)
            {
                Dictionary<Int64, Int64> d1 = PrimeNumber.GetIntegerFactorization(i);
                Dictionary<Int64, Int64> d2 = PrimeNumber.GetIntegerFactorization(i + 1);
                Dictionary<Int64, Int64> d3 = PrimeNumber.GetIntegerFactorization(i + 2);
                Dictionary<Int64, Int64> d4 = PrimeNumber.GetIntegerFactorization(i + 3);

                bool distinctPrimes = CompareFactorizations(d1, d2) && CompareFactorizations(d1, d3) && CompareFactorizations(d1, d4)
                                     && CompareFactorizations(d2, d3) && CompareFactorizations(d2, d4)
                                     && CompareFactorizations(d3, d4);

                if (distinctPrimes)
                {
                    itemNotFound = false;
                    Console.WriteLine("Solution: {0}", i);
                }

            }

        }
    }
}
