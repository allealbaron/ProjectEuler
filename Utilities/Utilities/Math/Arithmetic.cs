using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Math
{
    /// <summary>
    /// Basic Arithmetic operations for huge numbers
    /// </summary>
    public class Arithmetic
    {
        /// <summary>
        /// Reverses a string
        /// </summary>
        /// <param name="input">String to reverse</param>
        /// <returns>String reversed</returns>
        private static string ReverseString(string input)
        {

            StringBuilder result = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            return result.ToString();

        }

        /// <summary>
        /// Adds two numbers written as string
        /// </summary>
        /// <param name="augend">Augend</param>
        /// <param name="addend">addend</param>
        /// <returns>Addition</returns>
        public static string AddNumbers(string augend, string addend)
        {

            StringBuilder reversedSolution = new StringBuilder();

            int carryOver = 0;

            if (addend.Length < augend.Length)
            {
                addend = new string('0', augend.Length - addend.Length) + addend;
            }
            else
            {
                if (augend.Length < addend.Length)
                {
                    augend = new string('0', addend.Length - augend.Length) + augend;
                }
            }

            for (int i = augend.Length - 1; i >= 0; i--)
            {
                int sumColumn = int.Parse(augend[i].ToString()) + int.Parse(addend[i].ToString()) + carryOver;

                reversedSolution.Append(sumColumn % 10);

                carryOver = sumColumn / 10;

            }

            if (carryOver != 0)
            {
                reversedSolution.Append(carryOver);
            }

            return ReverseString(reversedSolution.ToString());

        }

        /// <summary>
        /// Multiply a multiplicand as string by a multiplier
        /// </summary>
        /// <param name="multiplicandAsString">Number</param>
        /// <param name="multiplier">Multiplier</param>
        /// <returns>Result</returns>
        static private string MultiplyNumbersOneDigit(string multiplicandAsString, int multiplier)
        {
            StringBuilder reversedSolution = new StringBuilder();

            int carryOver = 0;

            for (int i = multiplicandAsString.Length - 1; i >= 0; i--)
            {
                int product = (int.Parse(multiplicandAsString[i].ToString()) * multiplier) + carryOver;

                reversedSolution.Append(product % 10);

                carryOver = product / 10;

            }

            if (carryOver != 0)
            {
                reversedSolution.Append(carryOver);
            }

            return ReverseString(reversedSolution.ToString());

        }

        /// <summary>
        /// Multiplies two numbers stored as string
        /// </summary>
        /// <param name="multiplicand">Multiplicand</param>
        /// <param name="multiplier">Multiplier</param>
        /// <returns>Product</returns>
        static public string MultiplyNumbers(string multiplicand, string multiplier)
        {

            string result = String.Empty;

            for (int i = multiplier.Length - 1; i >= 0; i--)
            {

                string line = MultiplyNumbersOneDigit(multiplicand, int.Parse(multiplier[i].ToString()));

                line += new String('0', multiplier.Length - 1 - i);

                result = Arithmetic.AddNumbers(line, result);

            }

            return result;

        }

        /// <summary>
        /// Returns Pow
        /// </summary>
        /// <param name="powBase">Base</param>
        /// <param name="powExponent">Exponent</param>
        /// <returns>Pow</returns>
        static public string Pow(string powBase, int powExponent)
        {
            string result = "0";

            if (powExponent == 0)
            {
                result = "1";
            }
            else
            {
                if (powExponent == 1)
                {
                    return powBase;
                }
                else
                {
                    if (powExponent > 1)
                    {
                        result = powBase;
                        for (int i = 1; i < powExponent; i++)
                        {
                            result = MultiplyNumbers(result, powBase);
                        }
                    }
                    else
                    {
                        // TODO Negative pows
                        throw new NotImplementedException("TODO Negative pows");
                    }
                }
            }

            return result;

        }

        /// <summary>
        /// Returns Modular Pow
        /// </summary>
        /// <param name="powBase">Base</param>
        /// <param name="powExponent">Exponent</param>
        /// <param name="mod">Module</param>
        /// <returns>Pow</returns>
        static public string ModPow(string powBase, int powExponent, Int64 mod)
        {
            string result = "0";

            if (powExponent == 0)
            {
                result = "1";
            }
            else
            {
                if (powExponent == 1)
                {
                    return powBase;
                }
                else
                {
                    if (powExponent > 1)
                    {
                        result = powBase;
                        for (int i = 1; i < powExponent; i++)
                        {
                            result = MultiplyNumbers(result, powBase);
                            result = (Int64.Parse(result) % mod).ToString();
                        }
                    }
                    else
                    {
                        // TODO Negative pows
                        throw new NotImplementedException("TODO Negative pows");
                    }
                }
            }

            return result;
        }

    }
}
