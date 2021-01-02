using System;
using System.Linq;

namespace Task004
{
    class Program
    {
        /// <summary>
        /// Given a number, returns if it is palindromic
        /// </summary>
        /// <param name="number">Number to evaluate</param>
        /// <returns>result</returns>
        static bool IsPalindromic(int number)
        {
            string numberToString = number.ToString();

            bool result = true;

            for (int i = 0; result && i < numberToString.Length / 2; i++)
            {
                result = (numberToString[i].Equals(numberToString[numberToString.Length-i-1]));
            }

            return result;

        }

        static void Main()
        {

            int maxElement = (from e1 in Enumerable.Range(100, 900)
                    from e2 in Enumerable.Range(100, 900)
                    where IsPalindromic(e1 * e2)
                    select e1*e2 ).Max();

            Console.WriteLine("Solution: {0}", maxElement);
        }
    }
}
