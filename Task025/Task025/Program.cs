using System;
using System.Linq;
using Utilities.Math;

namespace Task025
{
    class Program
    {

        static void Main()
        {

            while (Fibonacci.GetListFibonacci().Last().Length < 1000)
            {
                Fibonacci.AddNextTerm();
            }

            Console.WriteLine("Solution: {0}", Fibonacci.GetListFibonacci().Count());

        }
    }
}
