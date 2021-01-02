using System;
using System.Collections.Generic;
using System.Linq;

namespace Task005
{
    class Program
    {

        /// <summary>
        /// Returns the list of numbers which are the prime factors of 
        /// <paramref name="number"/>
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Dictionary of elements</returns>
        static Dictionary<Int64, Int64> GetPrimeFactors(Int64 number)
        {
            Dictionary<Int64, Int64> result = new Dictionary<Int64, Int64>();

            int divisor = 2;

            while (number % divisor == 0)
            {

                if (result.ContainsKey(divisor))
                {
                    result[divisor]++;
                }
                else
                {
                    result.Add(divisor, 1);
                }

                number /= divisor;
            }

            divisor = 3;

            while (divisor <= Math.Sqrt(number))
            {
                if (number % divisor == 0)
                {
                    
                    if (result.ContainsKey(divisor))
                    {
                        result[divisor]++;
                    }
                    else
                    {
                        result.Add(divisor, 1);
                    }

                    number /= divisor;

                }
                else
                {
                    divisor += 2;
                }
            }

            if (number != 1)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                }
            }

            return result;

        }
        static void Main(string[] args)
        {

            const int maxNumber = 20;

            Dictionary<Int64, Int64> factors = new Dictionary<Int64, Int64>();

            for (int i = 2; i < maxNumber; i++)
            {
                foreach (KeyValuePair<Int64, Int64> kvp in GetPrimeFactors(i))
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
