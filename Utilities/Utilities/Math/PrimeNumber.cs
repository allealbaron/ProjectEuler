using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Math
{
    /// <summary>
    /// Class with functions related to prime numbers
    /// </summary>
    public class PrimeNumber
    {
        /// <summary>
        /// Prime numbers calculated
        /// </summary>
        private readonly static List<Int64> PrimesCalculated = new List<Int64>() { 2, 3 };

        /// <summary>
        /// Adds next item to <see cref="PrimesCalculated"/>
        /// </summary>
        public static void AddNextTerm()
        {
            
            Int64 counter = PrimesCalculated.Last()+2;
            bool isPrime = false;

            while (!isPrime)
            {
                
                isPrime = true;

                int i = 0;

                while (isPrime && PrimesCalculated[i] <= System.Math.Sqrt(counter))
                {
                    isPrime = (counter % PrimesCalculated[i] != 0);
                    i++;
                }

                if (isPrime)
                {
                    PrimesCalculated.Add(counter);

                }

                counter+=2;

            }

        }       

        /// <summary>
        /// List of Fibonacci items
        /// </summary>
        /// <returns>Fibonacci items</returns>
        public static List<Int64> GetListPrimes()
        {
            return PrimesCalculated.Select(item => item).ToList();
        }

        /// <summary>
        /// Calculate terms until index
        /// </summary>
        /// <param name="index">Index to achieve</param>
        public static void CalculateTermsUntilIndex(int index)
        {

            while (PrimesCalculated.Count < index)
            {
                AddNextTerm();
            }

        }

        /// <summary>
        /// Calculate terms until value
        /// </summary>
        /// <param name="value">Value to achieve</param>
        public static void CalculateTermsUntilValue(int value)
        {

            while (PrimesCalculated.Last() < value)
            {
                AddNextTerm();
            }

        }

        /// <summary>
        /// Returns if a number is prime
        /// </summary>
        /// <param name="number">Number< we need to know if it is prime/param>
        /// <returns>True if the number is prime</returns>
        public static bool IsPrime(int number)
        {
            
            CalculateTermsUntilValue(number);

            return (PrimesCalculated.Contains(number));

        }

        /// <summary>
        /// Return the Prime number at index. If it is not calculated,
        /// it will calculate it.
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns>Item</returns>
        public static Int64 GetPrimeTerm(int index)
        {

            CalculateTermsUntilIndex(index);

            return PrimesCalculated[index - 1];

        }

        /// <summary>
        /// Returns the list of numbers which are the prime factors of 
        /// <paramref name="number"/>
        /// Used in Task003, Task005, Task047
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>List of elements</returns>
        static public Dictionary<Int64, Int64> GetIntegerFactorization(Int64 number)
        {
            Dictionary<Int64, Int64> result = new Dictionary<Int64, Int64>();

            int divisor = 2;


            while (number % divisor == 0)
            {

                if (result.ContainsKey(divisor))
                {
                    result[divisor]++;
                }
                else
                {
                    result.Add(divisor, 1);
                }

                number /= divisor;
            }

            divisor = 3;

            while (divisor <= System.Math.Sqrt(number))
            {
                if (number % divisor == 0)
                {

                    if (result.ContainsKey(divisor))
                    {
                        result[divisor]++;
                    }
                    else
                    {
                        result.Add(divisor, 1);
                    }

                    number /= divisor;

                }
                else
                {
                    divisor += 2;
                }
            }

            if (number != 1)
            {
                if (result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result.Add(number, 1);
                }
            }

            return result;
        }

        /// <summary>
        /// List of divisors
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>List of divisors</returns>
        static public List<int> GetListDivisors(Int64 number)
        {
            
            List<int> divisors = new List<int>();

            for (int i = 1; i < (number / 2) + 1; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                }
            }

            divisors.Sort();

            return divisors;
        }

        /// <summary>
        /// Returns the sum of divisor of a number
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Sum of divisors</returns>
        static public Int64 GetSumDivisors(Int64 number)
        {
            return GetListDivisors(number).Sum();
        }

        /// <summary>
        /// Returns if <paramref name="number"/> is a circular prime
        /// (Example 197, 971 and 719 are primes)
        /// </summary>
        /// <param name="number">Number to evaluate</param>
        /// <returns>True or false</returns>
        static public bool IsCircularPrime(Int64 number)
        {
            bool IsCircular = true;

            if (number > 10)
            {
                string numberAsString = number.ToString();

                for (int i = 0; IsCircular && i < numberAsString.Length; i++)
                {
                    int borderIndex = numberAsString.Length - i - 1;
                    string nextNumber = numberAsString[borderIndex..] + numberAsString.Substring(0, borderIndex);
                    IsCircular = IsPrime(int.Parse(nextNumber));
                }

            }

            return IsCircular;

        }

    }

}
