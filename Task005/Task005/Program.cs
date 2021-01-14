using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task005
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            const int maxNumber = 20;

            Dictionary<Int64, Int64> factors = new Dictionary<Int64, Int64>();

            for (int i = 2; i < maxNumber; i++)
            {
                foreach (KeyValuePair<Int64, Int64> kvp in PrimeNumber.GetIntegerFactorization(i))
                {
                    if (factors.ContainsKey(kvp.Key))
                    {
                        if (kvp.Value > factors[kvp.Key])
                        {
                            factors[kvp.Key] = kvp.Value;
                        }
                    }
                    else
                    {
                        factors.Add(kvp.Key, kvp.Value);
                    }
                }
            }

            Int64 result = (from p in factors
                     select Int64.Parse(Math.Pow(p.Key, p.Value).ToString())).Aggregate((total, next) => total* next);

            Console.WriteLine("Solution: {0}", result);
        }
    }
}
