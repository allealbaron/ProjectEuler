using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task032
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            List <Int64> numbers = ((from m1 in Enumerable.Range(0, 10000)
                      from m2 in Enumerable.Range(0, 10000)
                      where ((m1.ToString() + m2.ToString() + (m1 * m2).ToString()).Length == 9)
                      && (Pandigital.IsPandigital(m1.ToString() + m2.ToString() + (m1 * m2).ToString()))
                      select  (Int64)(m1 * m2)).Distinct().ToList<Int64>());


            Console.WriteLine("Solution: {0}", numbers.Sum());
        }
    }
}
