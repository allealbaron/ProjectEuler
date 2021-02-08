using System;
using System.Linq;
using Utilities.Math;

namespace Task056
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            int solution = 0;
            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    string tempString = Arithmetic.Pow(i.ToString(), j);

                    int sum = (from c in tempString.ToCharArray()
                               select int.Parse(c.ToString())).Sum();

                    if (sum > solution)
                    {
                        solution = sum;
                    }

                }
            }

            Console.WriteLine("Solution: {0}", solution);

        }
    }
}
