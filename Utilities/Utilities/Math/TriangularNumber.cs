using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities.Math
{
    /// <summary>
    /// Triangular Number related functions
    /// </summary>
    public class TriangularNumber
    {
        /// <summary>
        /// TriangularNumber Calculated Terms
        /// </summary>
        private readonly static List<string> TriangularNumberCalculated = new List<string>() { "1"};

        /// <summary>
        /// Adds next item to <see cref="TriangularNumberCalculated"/>
        /// </summary>
        public static void AddNextTerm()
        {
            TriangularNumberCalculated.Add(Arithmetic.AddNumbers(TriangularNumberCalculated[^1], (TriangularNumberCalculated.Count()+1).ToString()));
        }

        /// <summary>
        /// List of TriangularNumber items
        /// </summary>
        /// <returns>TriangularNumber items</returns>
        public static List<string> GetListTriangularNumber()
        {
            return TriangularNumberCalculated.Select(item => item).ToList();
        }

        /// <summary>
        /// Calculate terms until index
        /// </summary>
        /// <param name="index">Index to achieve</param>
        public static void CalculateTermsUntilIndex(int index)
        {

            while (TriangularNumberCalculated.Count < index)
            {
                AddNextTerm();
            }

        }

        /// <summary>
        /// Calculate terms until index
        /// </summary>
        /// <param name="index">Index to achieve</param>
        public static void CalculateTermsUntilIndex(Int64 index)
        {

            while (TriangularNumberCalculated.Count < index)
            {
                AddNextTerm();
            }

        }

        /// <summary>
        /// Return the TriangularNumber item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static string GetTriangularNumberTerm(int index)
        {

            CalculateTermsUntilIndex(index);

            return TriangularNumberCalculated[index - 1];

        }

        /// <summary>
        /// Return the TriangularNumber item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static int GetTriangularNumberTermAsInt(int index)
        {

            CalculateTermsUntilIndex(index);

            return int.Parse(TriangularNumberCalculated[index - 1]);

        }

        /// <summary>
        /// Return the TriangularNumber item at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static Int64 GetTriangularNumberTermAsInt64(int index)
        {

            CalculateTermsUntilIndex(index);

            return Int64.Parse(TriangularNumberCalculated[index - 1]);

        }

    }
}
