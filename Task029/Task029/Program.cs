using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task029
{
    class Program
    {
        /// <summary>
        /// List of numbers with their factorization
        /// </summary>
        static readonly Dictionary<int, List<Pow>> numbers = new Dictionary<int, List<Pow>>();

        /// <summary>
        /// Different pows as string
        /// </summary>
        static readonly HashSet<string> pows = new HashSet<string>();

        /// <summary>
        /// Given a number, return its factorization
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Factorization</returns>
        static List<Pow> GetFactorization(int number)
        {
            List<Pow> result = new List<Pow>();

            int i = 2;

            Pow tempPow = new Pow();

            while (i <= number)
            {
                if (number % i == 0)
                {
                    tempPow.Base = i;
                    tempPow.Exponent++;
                    number /= i;
                }
                else
                {
                    if (tempPow.Base != 0)
                    {
                        result.Add(tempPow);
                        tempPow = new Pow();
                    }
                    i++;
                }
            }

            if (tempPow.Base != 0)
            {
                result.Add(tempPow);
            }

            if (number != 1)
            {
                result.Add(new Pow() { Base= number, Exponent = 1 });
            }

            return result;

        }

        static void Main()
        {
            const int MAX_NUMBER = 100;

            for (int i = 2; i <= MAX_NUMBER; i++)
            {
                numbers.Add(i, GetFactorization(i));
            }

            for (int i = 2; i <= MAX_NUMBER; i++)
            {
                foreach (KeyValuePair<int, List<Pow>> kvp in numbers)
                {
                    StringBuilder powDescribed = new StringBuilder();

                    foreach (Pow p in kvp.Value)
                    {
                        powDescribed.Append(p.Base.ToString("D4")).Append("@").Append((p.Exponent*i).ToString("D4"));
                    }
                    if (!pows.Contains(powDescribed.ToString()))
                    {
                        pows.Add(powDescribed.ToString());
                    }                    
                }
            }

            Console.WriteLine("Solution: {0}", pows.Count);

        }
    }
}
