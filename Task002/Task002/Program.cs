using System;
using System.Collections.Generic;
using System.Linq;

namespace Task002
{
    class Program
    {
				
		static int TOP_VALUE = 4000000;
		
        static void Main()
        {
            List<int> fibonacci = new List<int>();

            fibonacci.Add(1);
            fibonacci.Add(2);

            int result = 0;

            while (result < TOP_VALUE)
            {
                result = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
                fibonacci.Add(result);
            }

            int sum = (from f in fibonacci
                       where (f % 2 == 0) && (f<TOP_VALUE)
                       select f).Sum();

            Console.WriteLine("Solution: {0}", sum);
        }
    }
}
