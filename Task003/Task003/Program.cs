using System;
using System.Collections.Generic;
using System.Linq;

namespace Task003
{
    class Program
    {

        /// <summary>
        /// Returns the list of numbers which are the prime factors of 
        /// <paramref name="number"/>
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>List of elements</returns>
        static List<Int64> GetPrimeFactors(Int64 number)
        {
            List<Int64> result = new List<Int64>();

            int divisor = 2;
            
            if (number % divisor == 0)
            {
                result.Add(divisor);
                number /= divisor;
            }

            divisor = 3;

            while (divisor < number)
            {
                if (number % divisor == 0)
                {
                    result.Add(divisor);
                    number /= divisor;
                }
                else
                {
                    divisor += 2;
                }
            }

            result.Add(number);

            return result;
        }

        static void Main()
        {
            Console.WriteLine("Solution: {0}", GetPrimeFactors(600851475143).Max());
        }
    }
}
