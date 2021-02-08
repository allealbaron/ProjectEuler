using System;
using System.Collections.Generic;
using System.Linq;

namespace Task044
{
    class Program
    {
        /// <summary>
        /// /Gets pentagonal number
        /// </summary>
        /// <param name="n">index</param>
        /// <returns>Pentagonal Number</returns>
        static int GetPentagonal(int n)
        {
            return n * ((3 * n) - 1) / 2;
        }

        /// <summary>
        /// List of pentagonals numbers
        /// </summary>
        static readonly List<int> pentagonals = new List<int>();

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            pentagonals.Add(GetPentagonal(1));
            pentagonals.Add(GetPentagonal(2));

            int cont = 3;

            int difference = 0;

            while (difference == 0)
            {
                pentagonals.Add(GetPentagonal(cont));
                cont++;

                for (int i = 0; difference == 0 && i < pentagonals.Count - 2; i++)
                {
                    int j = i + 1;
                    while (j < pentagonals.Count - 1 && pentagonals[i] + pentagonals[j] <= pentagonals.Last() && difference == 0)
                    {
                        if (pentagonals[i] + pentagonals[j] == pentagonals.Last())
                        {
                            if (pentagonals.Contains(pentagonals[j] - pentagonals[i]))
                            {
                                difference = pentagonals[j] - pentagonals[i];
                            }
                        }
                        j++;
                    }

                }
            }

            Console.WriteLine("Solution: {0}", difference);

        }
    }
}
