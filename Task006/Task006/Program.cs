using System;
using System.Linq;

namespace Task006
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            const int maxItem = 100;

            Int64 secondTerm = (from i in Enumerable.Range(1, maxItem)
                                select i * i).Sum();

            Int64 firstTerm = (from i in Enumerable.Range(1, maxItem)
                               select i).Sum();

            Console.WriteLine("Solution: {0}", (firstTerm * firstTerm) - secondTerm);

        }
    }
}
