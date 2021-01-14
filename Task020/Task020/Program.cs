using System;
using System.Linq;
using Utilities.Math;

namespace Task020
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            Factorial.CalculateTermsUntilIndex(100);

            int result = (from c in Factorial.GetFactorialTerm(100).ToCharArray()
                          select int.Parse(c.ToString())).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
