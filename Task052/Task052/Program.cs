using System;
using System.Collections.Generic;
using System.Linq;

namespace Task052
{
    class Program
    {
        /// <summary>
        /// Order the digits inside a number
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>List<char> with the numbers</char></returns>
        static List<char> OrderDigits(int number)
        {
            return number.ToString().ToList<char>().OrderBy(p => p).ToList<char>();
        }

        /// <summary>
        /// Compares two lists
        /// </summary>
        /// <param name="l1">List one</param>
        /// <param name="l2">List two</param>
        /// <returns>Comparation result</returns>
        static bool CompareList(List<char> l1, List<char> l2)
        {
            bool result = true;

            if (l1.Count != l2.Count)
            {
                result = false;
            }
            else
            {
                for (int i = 0; result && i < l1.Count; i++)
                {
                    result = l1[i].Equals(l2[i]);
                }
            }

            return result;

        }

        static void Main()
        {
            int solution = (from t in Enumerable.Range(1, 300000)
                    where CompareList(OrderDigits(t), OrderDigits(2 * t)) &&
                          CompareList(OrderDigits(t), OrderDigits(3 * t)) &&
                          CompareList(OrderDigits(t), OrderDigits(4 * t)) &&
                          CompareList(OrderDigits(t), OrderDigits(5 * t)) &&
                          CompareList(OrderDigits(t), OrderDigits(6 * t))
                    select t).Min();

            Console.WriteLine("Solution: {0}", solution);
        }
    }
}
