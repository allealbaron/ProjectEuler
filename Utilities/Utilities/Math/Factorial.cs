using System.Collections.Generic;
using System.Linq;

namespace Utilities.Math
{
    /// <summary>
    /// Factorial related functions
    /// </summary>
    public class Factorial
    {
        /// <summary>
        /// Factorial Calculated Terms
        /// </summary>
        private readonly static List<string> FactorialCalculated = new List<string>() { "1", "1", "2" };

        /// <summary>
        /// Adds next item to <see cref="FactorialCalculated"/>
        /// </summary>
        public static void AddNextTerm()
        {
            FactorialCalculated.Add(Arithmetic.MultiplyNumbers(FactorialCalculated[^1],
                                        FactorialCalculated.Count.ToString()));
        }

        /// <summary>
        /// List of Factorial items
        /// </summary>
        /// <returns>Factorial items</returns>
        public static List<string> GetListFactorial()
        {
            return FactorialCalculated.Select(item => item).ToList();
        }

        /// <summary>
        /// Calculate terms until index
        /// </summary>
        /// <param name="index">Index to achieve</param>
        public static void CalculateTermsUntilIndex(int index)
        {

            while (FactorialCalculated.Count < index)
            {
                AddNextTerm();
            }

        }

        /// <summary>
        /// Return the Factorial item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static string GetFactorialTerm(int index)
        {

            CalculateTermsUntilIndex(index);

            return FactorialCalculated[index - 1];

        }

        /// <summary>
        /// Return the Factorial item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static int GetFactorialTermAsInt(int index)
        {

            CalculateTermsUntilIndex(index);

            return int.Parse(FactorialCalculated[index - 1]);

        }

    }
}
