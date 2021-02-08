using System;
using System.Linq;
using Utilities.Math;

namespace Task017
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int result = (from n in Enumerable.Range(1, 1000)
                          select NumberToWords.GetNumberAsString(n).Length).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
