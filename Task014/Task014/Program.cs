using System;
using System.Collections.Generic;
using System.Linq;


namespace Task014
{
    class Program
    {
        /// <summary>
        /// Recursive function, gets the number of jumps 
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="jumpsTaken">Jumps taken</param>
        /// <returns>Number of jumps</returns>
        static int GetNumberJumps(Int64 number, int jumpsTaken)
        {
            int result = 0;

            if (number == 1)
            {
                result = jumpsTaken;
            }
            else
            {
                if (number % 2 == 0)
                {
                    jumpsTaken++;
                    result = GetNumberJumps(number / 2, jumpsTaken);
                }
                else
                {
                    jumpsTaken++;
                    result = GetNumberJumps((3*number)+1, jumpsTaken);
                }
            }
            return result;
        }
        static void Main()
        {
            int solution = (from n in Enumerable.Range(1, 1000000)
                     select new 
                        { n, 
                         jumps = GetNumberJumps(n, 1) }
                     ).OrderByDescending(p => p.jumps).First().n;
            
            Console.WriteLine("Solution: {0}", solution);
        }
    }
}
