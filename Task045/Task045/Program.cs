using System;

namespace Task045
{
    class Program
    {
        /// <summary>
        /// Given n, gets its triangle value
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>Triangle value</returns>
        static Int64 GetTriangleValue(Int64 n)
        {
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// Given a number n, checks if the Triangle value generated
        /// can also be a pentagonal value
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>A pentagonal index if it fits</returns>
        static int GetPentagonalIndex(int n)
        {

            double value = (1 + System.Math.Sqrt((1 + (4 * 2 * 3 * GetTriangleValue(n)))));

            if (value % 6 == 0)
            {
                return (int)(value / 6);
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// Given a number n, checks if the Triangle value generated
        /// can also be a hexagonal value
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>A hexagonal index if it fits</returns>

        static int GetHexagonalIndex(int n)
        {
            double value = (1 + System.Math.Sqrt((1 + (4 * 2 * GetTriangleValue(n)))));

            if (value % 4 == 0)
            {
                return (int)(value / 4);
            }
            else
            {
                return 0;
            }

        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            bool blnFound = false;
            int n = 286;

            while (!blnFound)
            {
                int pentagonalIndex = GetPentagonalIndex(n);

                if (pentagonalIndex > 0)
                {
                    int hexagonalIndex = GetHexagonalIndex(n);

                    if (hexagonalIndex > 0)
                    {
                        Console.WriteLine("Solution: T = {0}, P = {1}, H = {2}, Value = {3}",
                                            n, pentagonalIndex, hexagonalIndex, GetTriangleValue(n));
                        blnFound = true;
                    }
                }
                n++;
            }

        }
    }
}
