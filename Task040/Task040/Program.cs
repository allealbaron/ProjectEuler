using System;
using System.Text;

namespace Task040
{
    class Program
    {
        static void Main()
        {
            const int maxIndex = 1000000;
            int i = 0;

            StringBuilder number = new StringBuilder();

            while (number.Length <= maxIndex)
            {
                number.Append(i.ToString());
                i++;
            }

            int solution = 1;

            for (int j = 1; j < maxIndex; j *= 10)
            {
                solution *= int.Parse(number[j].ToString());
            }

            Console.WriteLine("Solution: {0}", solution);

        }
    }
}
