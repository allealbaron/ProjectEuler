using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task002
{
    class Program
    {
	    /// <summary>
        /// Top Value
        /// </summary>
        const int TOP_VALUE = 4000000;
		
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            Int64 temp = 0;
            int i = 3;

            while (temp < TOP_VALUE)
            {
                temp = Fibonacci.GetFibonacciTermAsInt64(i);
                i++;
            }

            Int64 solution = (from f in Fibonacci.GetListFibonacci()
                              where (Int64.Parse(f) % 2 == 0) && (Int64.Parse(f)<TOP_VALUE)
                       select Int64.Parse(f)).Sum();
            
            Console.WriteLine("Solution: {0}", solution);

        }
    }
}
