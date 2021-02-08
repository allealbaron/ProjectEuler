using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task012
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            Int64 i = 0;
            List<int> divisors = new List<int>();
            string solution = String.Empty;

            while (divisors.Count<500)
            {
                i++;

                TriangularNumber.AddNextTerm();

                solution = TriangularNumber.GetListTriangularNumber().Last();

                divisors = PrimeNumber.GetListDivisors(Int64.Parse(solution));

            }


            Console.WriteLine("Solution: {0}", solution);
        }
    }
}
