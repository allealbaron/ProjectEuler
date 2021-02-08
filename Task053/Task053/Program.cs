using System;
using System.Numerics;
using Utilities.Math;

namespace Task053
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            Factorial.CalculateTermsUntilIndex(101);

            int solution = 0;

            for (int n = 1; n <= 100; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    BigInteger product = 1;
                    for (int j = 0; j < r; j++)
                    {
                        product *= (n - j);
                    }
                    BigInteger result = product / BigInteger.Parse(Factorial.GetFactorialTerm(r + 1));

                    if (result > 1000000)
                    {
                        solution++;
                    }

                }
            }


            Console.WriteLine("Solution: {0}", solution);
        }
    }
}
