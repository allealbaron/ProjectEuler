using System;
using System.Collections.Generic;
using System.Linq;

namespace Task032
{
    class Program
    {

        /// <summary>
        /// Checks if a number is Pandigital
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Returns true if the number is pandigital</returns>
        static bool IsPandigital(string number)
        {
            Dictionary<Int64, int> repeatedNumbers =
                                                 (number.ToCharArray()
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

            List <Int64> numbers = ((from m1 in Enumerable.Range(0, 10000)
                      from m2 in Enumerable.Range(0, 10000)
                      where ((m1.ToString() + m2.ToString() + (m1 * m2).ToString()).Length == 9)
                      && (IsPandigital(m1.ToString() + m2.ToString() + (m1 * m2).ToString()))
                      select  (Int64)(m1 * m2)).Distinct().ToList<Int64>());


            Console.WriteLine("Solution: {0}", numbers.Sum());
        }
    }
}
