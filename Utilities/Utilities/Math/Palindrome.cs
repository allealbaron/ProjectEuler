using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Math
{
    /// <summary>
    /// Palindrome related functions
    /// </summary>
    public class Palindrome
    {
        /// <summary>
        /// Given a number, returns if it is palindromic
        /// </summary>
        /// <param name="number">Number to evaluate</param>
        /// <returns>True if the number is palindromic, false otherwise</returns>
        public static bool IsPalindromic(int number)
        {
            string numberToString = number.ToString();

            bool result = true;

            for (int i = 0; result && i < numberToString.Length / 2; i++)
            {
                result = (numberToString[i].Equals(numberToString[numberToString.Length-i-1]));
            }

            return result;

        }
    }
}
