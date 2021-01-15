using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task038
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            List<string> solutions = new List<string>();

            for (int i = 9; i < 10000; i++)
            {
                int j = 2;
                string possiblePanDigital = i.ToString();

                while (possiblePanDigital.Length < 9)
                {
                    possiblePanDigital += (i * j).ToString();
                    j++;
                }

                if (Pandigital.IsPandigital(possiblePanDigital))
                {
                    solutions.Add(possiblePanDigital);
                }

            }

            Console.WriteLine("Solution: {0}", solutions.Max());

        }
    }
}
