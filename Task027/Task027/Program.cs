using System;
using Utilities.Math;

namespace Task027
{
    class Program
    {
        /// <summary>
        /// Calculates Iteration
        /// </summary>
        /// <param name="a">a factor</param>
        /// <param name="b">b factor</param>
        /// <param name="n">iteration</param>
        /// <returns>value</returns>
        static int CalculateIteration(int a, int b, int n)
        {
            return ((n * n) + a * n + b);
        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int maxPrimeSequence = 0;
            int a = 0;
            int b = 0;

            for (int i = -999; i < 1000; i++)
            {
                for (int j = -1000; j <= 1000; j++)
                {

                    int n = 0;

                    while (PrimeNumber.IsPrime(CalculateIteration(i, j, n)))
                    {
                        n++;
                    }

                    if (n > maxPrimeSequence)
                    {
                        maxPrimeSequence = n;
                        a = i;
                        b = j;
                    }

                }
            }

            Console.WriteLine("Solution: a = {0} , b = {1}, n = {2}, a * b = {3}", a, b, maxPrimeSequence, a * b);

        }
    }
}
