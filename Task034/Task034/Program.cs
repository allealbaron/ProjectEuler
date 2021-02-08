using System;
using Utilities.Math;

namespace Task034
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            string totalSum = String.Empty;

            for (int i = 3; i < Factorial.GetFactorialTermAsInt(9) * 7; i++)
            {
                string factorialSum = String.Empty;

                foreach (char c in i.ToString().ToCharArray())
                {
                    factorialSum = Arithmetic.AddNumbers(factorialSum, Factorial.GetFactorialTerm(1 + int.Parse(c.ToString())));
                }

                if (factorialSum.Equals(i.ToString()))
                {
                    totalSum = Arithmetic.AddNumbers(totalSum, i.ToString());
                }

            }

            Console.WriteLine("Solution: {0}", totalSum);
        }
    }
}
