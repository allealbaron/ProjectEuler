using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task025
{
    class Program
    {

        static List<String> fibonacciNumbers = new List<String>() { 1.ToString(), 1.ToString() };

        /// <summary>
        /// Add two numbers written as string
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Addition</returns>
        static string AddNumbers(string number1, string number2)
        {
            
            StringBuilder reversedSolution = new StringBuilder();

            int carryover = 0;

            if (number2.Length < number1.Length)
            {
                number2 = "0" + number2;
            }

            for (int i = number1.Length - 1; i >= 0; i--)
            {
                int sumColumn = int.Parse(number1[i].ToString()) + int.Parse(number2[i].ToString()) + carryover;

                reversedSolution.Append(sumColumn % 10);

                carryover = sumColumn / 10;

            }

            if (carryover != 0)
            {
                reversedSolution.Append(carryover);
            }

            StringBuilder result = new StringBuilder();

            for (int i = reversedSolution.Length - 1; i >= 0; i--)
            {
                result.Append(reversedSolution[i]);
            }

            return result.ToString();

        }

        static void Main()
        {

            while (fibonacciNumbers.Last().Length < 1000)
            {
                fibonacciNumbers.Add(AddNumbers(fibonacciNumbers[fibonacciNumbers.Count - 1], fibonacciNumbers[fibonacciNumbers.Count - 2]));
            }

            Console.WriteLine("Solution: {0}", fibonacciNumbers.Count());

        }
    }
}
