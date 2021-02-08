using System;
using System.Linq;
using Utilities.Math;

namespace Task021
{
    class Program
    {

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            var listElements = (from r1 in Enumerable.Range(1, 10000)
                                select new
                                {
                                    item = r1,
                                    sumDivisors = PrimeNumber.GetSumDivisors(Int64.Parse(r1.ToString()))
                                }).ToList();

            var result = from r1 in listElements
                         from r2 in listElements
                         where r1.item != r2.item
                         && r1.sumDivisors == r2.item
                         && r1.item == r2.sumDivisors
                         select r1.item;

            Console.WriteLine("Solution: {0}", result.Sum());
        }
    }
}
