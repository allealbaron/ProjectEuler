using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Math;

namespace Task050
{
    class Program
    {
        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {

            const int MAX_VALUE = 1000000;

            Dictionary<Int64, int> Solutions = new Dictionary<long, int>();

            PrimeNumber.CalculateTermsUntilValue(MAX_VALUE);


            int i = 1;
            Int64 primeNumber = PrimeNumber.GetPrimeTerm(i);

            while (primeNumber < MAX_VALUE)
            {
                int index = 1;

                while (PrimeNumber.GetPrimeTerm((int)index) < System.Math.Sqrt(primeNumber))
                {
                    Int64 sum = 0;
                    int count = 0;
                    int j = index;

                    while (sum < primeNumber)
                    {
                        sum += PrimeNumber.GetPrimeTerm((int)j);
                        count++;
                        j++;
                    }

                    if (sum == primeNumber)
                    {

                        if (Solutions.ContainsKey(primeNumber))
                        {
                            if (count > Solutions[primeNumber])
                            {
                                Solutions[primeNumber] = count;
                            }
                        }

                        else
                        {
                            Solutions.Add(primeNumber, count);
                        }

                    }

                    index++;

                }

                i++;
                primeNumber = PrimeNumber.GetPrimeTerm(i);

            }

            Console.WriteLine("Solution: {0}", Solutions.Aggregate((l, r) => l.Value > r.Value ? l : r).Key);

        }
    }
}
