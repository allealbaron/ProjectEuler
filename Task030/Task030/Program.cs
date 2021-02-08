using System;
using System.Linq;

namespace Task030
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int solution = (from n1 in Enumerable.Range(0, 10)
                            from n2 in Enumerable.Range(0, 10)
                            from n3 in Enumerable.Range(0, 10)
                            from n4 in Enumerable.Range(0, 10)
                            from n5 in Enumerable.Range(0, 10)
                            from n6 in Enumerable.Range(0, 10)
                            where Math.Pow(n1, 5) + Math.Pow(n2, 5) + Math.Pow(n3, 5) + Math.Pow(n4, 5) + Math.Pow(n5, 5) + +Math.Pow(n6, 5)
                            == (n6 * 100000 + n5 * 10000 + n4 * 1000 + n3 * 100 + n2 * 10 + n1)
                            && (n6 * 100000 + n5 * 10000 + n4 * 1000 + n3 * 100 + n2 * 10 + n1) > 1
                            select (n6 * 100000 + n5 * 10000 + n4 * 1000 + n3 * 100 + n2 * 10 + n1)).Sum();


            Console.WriteLine("Solution: {0}", solution);

        }
    }
}
