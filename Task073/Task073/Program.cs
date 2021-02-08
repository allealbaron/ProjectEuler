using System;
using System.Collections.Generic;
using System.Linq;

namespace Task073
{
    class Program
    {
        /// <summary>
        /// 1/2
        /// </summary>
        private const double half = 1.0 / 2;

        /// <summary>
        /// 1/3
        /// </summary>
        private const double third = 1.0 / 3;

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            HashSet<double> solutions = new HashSet<double>();

            for (int i = 1; i < 12000; i++)
            {
                for (int j = 2; j <= 12000; j++)
                {
                    double r = (double)i / j;

                    if (r < half && r > third)
                    {
                        solutions.Add(r);
                    }

                }
            }

            Console.WriteLine("Solution: {0}", solutions.Count());

        }
    }
}
