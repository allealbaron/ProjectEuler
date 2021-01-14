using System;
using Utilities.Math;
using System.Linq;

namespace Task003
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Solution: {0}", PrimeNumber.GetIntegerFactorization(600851475143).Last().Key);
        }
    }
}
