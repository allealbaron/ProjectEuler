using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities.Math
{
    /// <summary>
    /// Fibonacci related functions
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// Fibonacci Calculated Terms
        /// </summary>
        private readonly static List<string> FibonacciCalculated = new List<string>() { "1", "1" };

        /// <summary>
        /// Adds next item to <see cref="FibonacciCalculated"/>
        /// </summary>
        public static void AddNextTerm()
        {
            FibonacciCalculated.Add(Arithmetic.AddNumbers(FibonacciCalculated[^1] , FibonacciCalculated[^2]));
        }

        /// <summary>
        /// List of Fibonacci items
        /// </summary>
        /// <returns>Fibonacci items</returns>
        public static List<string> GetListFibonacci()
        {
            return FibonacciCalculated.Select(item => item).ToList();
        }

        /// <summary>
        /// Calculate terms until index
        /// </summary>
        /// <param name="index">Index to achieve</param>
        public static void CalculateTermsUntilIndex(int index)
        {
            
            while (FibonacciCalculated.Count < index)
            {
                AddNextTerm();
            }

        }

        /// <summary>
        /// Return the Fibonacci item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static string GetFibonacciTerm(int index)
        {

            CalculateTermsUntilIndex(index);

            return FibonacciCalculated[index-1];

        }

        /// <summary>
        /// Return the Fibonacci item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static int GetFibonacciTermAsInt(int index)
        {

            CalculateTermsUntilIndex(index);

            return int.Parse(FibonacciCalculated[index - 1]);

        }

        /// <summary>
        /// Return the Fibonacci item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static Int64 GetFibonacciTermAsInt64(int index)
        {

            CalculateTermsUntilIndex(index);

            return Int64.Parse(FibonacciCalculated[index - 1]);

        }

    }
}
