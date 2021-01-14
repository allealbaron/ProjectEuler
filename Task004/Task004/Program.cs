using System;
using System.Linq;
using Utilities.Math;

namespace Task004
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int maxElement = (from e1 in Enumerable.Range(100, 900)
                    from e2 in Enumerable.Range(100, 900)
                    where Palindrome.IsPalindromic(e1 * e2)
                    select e1*e2 ).Max();

            Console.WriteLine("Solution: {0}", maxElement);

        }
    }
}
