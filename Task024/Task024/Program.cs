using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task024
{
    class Program
    {
        /// <summary>
        /// Numbers 0-9 used to build the solution
        /// </summary>
        static readonly Dictionary<int, bool> numbers = new Dictionary<int, bool>();

        /// <summary>
        /// Target position
        /// </summary>
        const int TARGET = 1000000;

        /// <summary>
        /// Gets factorial
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Factorial</returns>
        static int Factorial(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void Main()
        {

            for (int j = 0; j < 10; j++)
            {
                numbers.Add(j, false);
            }

            int counter = 0;
            int position = 9;
            int i = 0;
            StringBuilder solution = new StringBuilder();

            while (counter < TARGET && i <numbers.Count)
            {
                if (!numbers[i])
                {
                    if (counter + Factorial(position) < TARGET)
                    {
                        counter += Factorial(position);
                    }
                    else
                    {
                        solution.Append(i);
                        numbers[i] = true;
                        position--;
                        i = -1;
                    }
                }
                i++;
            }

            foreach (int number in from n in numbers where (!n.Value) orderby n.Key select n.Key)
            {
                solution.Append(number);
            }
            
            Console.WriteLine("Solution: {0}", solution.ToString());
        }
    }
}
