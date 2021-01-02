using System;
using System.Collections.Generic;
using System.Linq;

namespace Task007
{
    class Program
    {
        static void Main()
        {

            const int maxItem = 10001;
            List<int> primes = new List<int>() { 2, 3, 5, 7, 11, 13 };

            int counter = 15;

            while (primes.Count != maxItem)
            {
                bool isPrime = true;

                int i = 0;

                while (isPrime && primes[i]<= Math.Sqrt(counter))
                {
                    isPrime = (counter % primes[i]!=0);
                    i++;
                }

                if (isPrime)
                {
                    primes.Add(counter);
                }

                counter += 2;
            }

            Console.WriteLine("Solution: {0}", primes[maxItem-1]);
        }
    }
}
