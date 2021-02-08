using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Math;

namespace Task029
{
    class Program
    {
        /// <summary>
        /// List of numbers with their factorization
        /// </summary>
        static readonly Dictionary<int, Dictionary<Int64, Int64>> numbers = new Dictionary<int, Dictionary<Int64, Int64>>();

        /// <summary>
        /// Different pows as string
        /// </summary>
        static readonly HashSet<string> pows = new HashSet<string>();

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            const int MAX_NUMBER = 100;

            for (int i = 2; i <= MAX_NUMBER; i++)
            {
                numbers.Add(i, PrimeNumber.GetIntegerFactorization(i));
            }

            for (int i = 2; i <= MAX_NUMBER; i++)
            {
                foreach (KeyValuePair<int, Dictionary<Int64, Int64>> kvp in numbers)
                {
                    StringBuilder powDescribed = new StringBuilder();

                    foreach (KeyValuePair<Int64, Int64> p in kvp.Value)
                    {
                        powDescribed.Append(
                            p.Key.ToString("D4")).Append("@").Append((p.Value * i).ToString("D4"));
                    }
                    if (!pows.Contains(powDescribed.ToString()))
                    {
                        pows.Add(powDescribed.ToString());
                    }
                }
            }

            Console.WriteLine("Solution: {0}", pows.Count);

        }
    }
}
