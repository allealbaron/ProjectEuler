using System;
using System.Collections.Generic;

namespace Task031
{
    class Program
    {
        /// <summary>
        /// Coins used in the United Kingdom
        /// </summary>
        static readonly List<int> Coins = new List<int>() { 1, 2, 5, 10, 20, 50, 100, 200 };

        /// <summary>
        /// Amount we want to achieve
        /// </summary>
        const int TARGET = 200;

        /// <summary>
        /// Recursive function which searchs how many solutiona are
        /// </summary>
        /// <param name="accumulated">Accumulated value</param>
        /// <param name="index">Coin index</param>
        /// <param name="solutions">Number of solutions</param>
        /// <returns>Partial number of solutions</returns>
        static int GetSolutions(int accumulated, int index, int solutions)
        {

            for (int i = 0; i <= TARGET / Coins[index]; i++)
            {
                int newValue = accumulated + (Coins[index] * i);

                if (newValue == TARGET)
                {
                    solutions++;
                }
                else
                {
                    if (newValue <= TARGET)
                    {
                        if (index + 1 < Coins.Count)
                        {
                            solutions = GetSolutions(newValue, index + 1, solutions);
                        }
                    }
                }
            }

            return solutions;

        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Solutions: {0}", GetSolutions(0, 0, 0));
        }
    }
}
