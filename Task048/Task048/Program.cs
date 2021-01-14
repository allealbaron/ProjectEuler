using System;
using Utilities.Math;

namespace Task048
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            string solution = "0";

            for (int i = 1; i <= 1000; i++)
            {
                solution = Arithmetic.AddNumbers(solution, Arithmetic.ModPow(i.ToString(), i, 10000000000));
            }

            Console.WriteLine("Solution: {0} ", solution[^10..]);

        }
    }
}
