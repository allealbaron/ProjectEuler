﻿using System;
using System.Linq;
using Utilities.Math;

namespace Task036
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            int result = (from n in Enumerable.Range(1, 1000000)
                          where n % 2 == 1 && Palindrome.IsPalindromic(n)
                          && Palindrome.IsPalindromic(Convert.ToString(n, 2))
                          select n).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
