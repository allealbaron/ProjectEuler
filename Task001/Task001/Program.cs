using System;
using System.Linq;

namespace Task001
{
    class Program
    {
        static void Main()
        {

            int result = (from i in Enumerable.Range(1, 999)
                     where (i % 3 == 0 || i % 5 == 0) 
                     select i).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
