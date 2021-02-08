using System;
using System.Linq;

namespace Task092
{
    class Program
    {
        /// <summary>
        /// Given a number, returns its loop number (1 or 89)
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>LoopNumber</returns>
        static int GetLoopNumber(Int64 number)
        {
            int newNumber;

            int result = 0;

            while (result == 0)
            {
                newNumber = 0;

                foreach (char c in number.ToString().ToCharArray())
                {
                    newNumber += (int)(Math.Pow(int.Parse(c.ToString()), 2));
                }

                if (newNumber == 1 || newNumber == 89)
                {
                    result = newNumber;
                }

                number = newNumber;

            }

            return result;

        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int solution = (from t in Enumerable.Range(1, 10000000)
                            where GetLoopNumber(t) == 89
                            select t).Count();

            Console.WriteLine("Solution: {0}", solution);

        }
    }
}
