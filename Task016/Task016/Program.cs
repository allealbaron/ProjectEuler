using System;
using System.Linq;
using Utilities.Math;

namespace Task016
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int result = (from c in Arithmetic.Pow("2", 1000).ToCharArray()
                          select int.Parse(c.ToString())).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
