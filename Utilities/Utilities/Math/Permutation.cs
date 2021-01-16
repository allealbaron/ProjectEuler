using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Utilities.Math
{
    /// <summary>
    /// Permutation related functions
    /// </summary>
    public class Permutation
    {
        /// <summary>
        /// Given two numbers, returns if they are permutations of the same number
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>True if they are permutations, false otherwise</returns>
        public static bool ArePermutations(Int64 number1, Int64 number2)
        {
            return ArePermutations(number1.ToString(), number2.ToString());
        }

        /// <summary>
        /// Given two numbers, returns if they are permutations of the same number
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>True if they are permutations, false otherwise</returns>
        public static bool ArePermutations(int number1, int number2)
        {
            return ArePermutations(number1.ToString(), number2.ToString());
        }

        /// <summary>
        /// Given two numbers, returns if they are permutations of the same number
        /// </summary>
        /// <param name="number1">number1</param>
        /// <param name="number2">number2</param>
        /// <returns>True if they are permutations, false otherwise</returns>
        public static bool ArePermutations(string number1, string number2)
        {
            bool result = true;

            if (number1.Length != number2.Length)
            {
                result = false;
            }
            else 
            {
                List<char> n1 = number1.ToCharArray().ToList();
                List<char> n2 = number2.ToCharArray().ToList();

                n1.Sort();
                n2.Sort();

                for (int i = 0; result && i < n1.Count; i++)
                {
                    result = n1[i].Equals(n2[i]);
                }

            }

            return result;

        }


    }
}
