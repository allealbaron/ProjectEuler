using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task020
{
    class Program
    {
        /// <summary>
        /// /List which stores every factorial
        /// </summary>
        static readonly List<string> Factorials = new List<string>();

        /// <summary>
        /// Reverses a string
        /// </summary>
        /// <param name="input">String to reverse</param>
        /// <returns>String reversed</returns>
        static string ReverseString(string input)
        {
            
            StringBuilder result = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            return result.ToString();

        }

        /// <summary>
        /// Multiply a multiplicand as string by a multiplier
        /// </summary>
        /// <param name="multiplicandAsString">Number</param>
        /// <param name="multiplier">Multiplier</param>
        /// <returns>Result</returns>
        static string MultiplyNumbersOneDigit(string multiplicandAsString, int multiplier)
        {
            StringBuilder reversedSolution = new StringBuilder();

            int carryOver = 0;

            for (int i = multiplicandAsString.Length - 1; i >= 0; i--)
            {
                int product = (int.Parse(multiplicandAsString[i].ToString())* multiplier) + carryOver;

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
        static string MultiplyNumbers(string multiplicand, string multiplier)
        {

            string result = String.Empty;

            for (int i = multiplier.Length - 1; i >= 0; i--)
            {
                
                string line = MultiplyNumbersOneDigit(multiplicand, int.Parse(multiplier[i].ToString()));                
                
                line += new String('0', multiplier.Length - 1 - i);
                
                result = AddNumbers(line, result);

            }

            return result;

        }

        /// <summary>
        /// Adds two numbers written as string
        /// </summary>
        /// <param name="augend">Augend</param>
        /// <param name="addend">addend</param>
        /// <returns>Addition</returns>
        static string AddNumbers(string augend, string addend)
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

        static void Main()
        {

            Factorials.Add("1"); //Special case: 0!
            Factorials.Add("1"); //Special case: 1!
            Factorials.Add("2"); //Special case: 2!

            for (int i = 3; i <= 100; i++)
            {
                Factorials.Add(MultiplyNumbers(Factorials[i-1], i.ToString()));
            }

            int result = (from c in Factorials[100].ToCharArray()
                          select int.Parse(c.ToString())).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
