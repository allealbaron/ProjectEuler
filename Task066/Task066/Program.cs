using System;
using System.Collections.Generic;
using System.Numerics;

namespace Task066
{
    class Program
    {
        public static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        static readonly List<BigInteger> Solutions = new List<BigInteger>();

        /// <summary>
        /// Returns Y value for x if the value is entire
        /// </summary>
        /// <param name="x">x</param>
        /// <param name="d">d</param>
        /// <returns>Y</returns>
        static BigInteger GetY(BigInteger x, int d)
        {

            BigInteger subResult = Sqrt((BigInteger.Pow(x,2) - 1)/d);
            
            if (BigInteger.Pow(x, 2) - d* BigInteger.Pow(subResult, 2) == 1)
            {
                return subResult;
            }
            else
            {
                return 0;
            }
        }

        static void Main()
        {
            BigInteger MaxX = 0;
            int MaxD = 0;

            Solutions.Add(0);
            Solutions.Add(0);

            for (int d = 2; d <= 1000; d++)
            {
                if (Math.Sqrt(d) - Math.Floor(Math.Sqrt(d)) != 0)
                {
                    bool blnFound = false;
                    BigInteger x = (Int64)Math.Floor(Math.Sqrt(d));
                    BigInteger y = 0;

                    while (!blnFound)
                    {
                        while (BigInteger.Pow(x, 2) - d * BigInteger.Pow(y, 2) - 1 > 0)
                        {
                            y++;
                        }

                        if (BigInteger.Pow(x, 2) - d * BigInteger.Pow(y, 2) - 1 == 0)
                        {
                            blnFound = true;
                            Console.WriteLine("Solution for d = {1}: x= {0}, y = {2}", x, d, y);
                            if (x > MaxX)
                            {
                                MaxX = x;
                                MaxD = d;
                            }

                            Solutions.Add(x);
                        }
                        x++;

                    }
                    /*
                    while (y == 0)
                    {
                        y = GetY(x, d);

                        if (y==0 || (BigInteger.Pow(x, 2) - d * BigInteger.Pow(y, 2) != 1))
                        {
                            y = 0;
                            x++;
                        }
                    }
                    */
                    /*
                    Console.WriteLine("Solution for d = {1}: x= {0}, y = {2}", x, d, y);

                    if (x > MaxX)
                    {
                        MaxX = x;
                        MaxD = d;
                    }

                    Solutions.Add(x);
                    */
                }
                else
                {
                    Solutions.Add(0);
                }
            }

            Console.WriteLine("Solution: x= {0}, d = {1}", MaxX, MaxD);

        }
    }
}
