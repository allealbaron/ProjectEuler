using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task007
{
    class Program
    {

        /// <summary>
        /// Max item
        /// </summary>
        private const int MAX_ITEM = 10001;

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            Console.WriteLine("Solution: {0}", PrimeNumber.GetPrimeTerm(MAX_ITEM));

        }
    }
}
