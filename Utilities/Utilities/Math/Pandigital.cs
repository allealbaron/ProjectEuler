using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities.Math
{
    /// <summary>
    /// Pandigital related functions
    /// </summary>
    public class Pandigital
    {

        /// <summary>
        /// Checks if a number is Pandigital
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Returns true if the number is pandigital</returns>
        static public bool IsPandigital(Int64 number)
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

    }
}
