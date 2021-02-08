using System;
using System.Linq;
using Utilities.Math;

namespace Task010
{
    class Program
    {
        /// <summary>
        /// Max value
        /// </summary>
        private const int MAX_VALUE = 2000000;

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            PrimeNumber.CalculateTermsUntilValue(MAX_VALUE);

            Console.WriteLine("Solution: {0}", PrimeNumber.GetListPrimes().Where(p => (p < MAX_VALUE)).Sum());

        }
    }
}
