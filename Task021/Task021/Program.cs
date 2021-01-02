using System;
using System.Linq;
using System.Collections.Generic;

namespace Task021
{
    class Program
    {

        /// <summary>
        /// List of SumDivisors
        /// </summary>
        static readonly Dictionary<int, int> SumDivisors = new Dictionary<int,int>();

        /// <summary>
        /// Given a number, return the sum of its divisors
        /// </summary>
        /// <param name="number">Numbers</param>
        /// <returns>Sum of divisors</returns>
        static int GetSumDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i < (number/2) + 1; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors.Sum();
        }

        static void Main()
        {

            for (int i = 1; i < 10000; i++)
            {
                SumDivisors.Add(i, GetSumDivisors(i));
            }

            int result = (from r1 in SumDivisors
                    from r2 in SumDivisors
                    where r1.Key == r2.Value && r2.Key == r1.Value
                    && r1.Key != r2.Key  
                    select r1.Value).Sum();

            Console.WriteLine("Hello World! {0}", result);
        }
    }
}
