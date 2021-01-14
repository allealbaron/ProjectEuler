using System;
using Utilities.Math;

namespace Task097
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            string solution = Arithmetic.AddNumbers("1", Arithmetic.MultiplyNumbers(Arithmetic.ModPow("2", 7830457, 10000000000), "28433"));

            Console.WriteLine("Solution: {0}", solution[^10..]);

        }
    }
}
