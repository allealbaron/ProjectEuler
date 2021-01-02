using System;
using System.Linq;
using System.Text;

namespace Task016
{
    class Program
    {

        /// <summary>
        /// Duplicates a number stored as a text
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Number duplicated</returns>
        static string DuplicateNumberAsText(string number)
        {
            StringBuilder resultBackwards = new StringBuilder();

            int carry = 0;

            for (int i = number.Length - 1; i>=0; i--)
            {
                int newDigit =( 2 * int.Parse(number[i].ToString())) + carry;

                resultBackwards.Append((newDigit%10).ToString());

                carry = newDigit / 10;

            }

            if (carry > 0)
            {
                resultBackwards.Append(carry);
            }

            StringBuilder result = new StringBuilder();

            string temp = resultBackwards.ToString();

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                result.Append(temp[i]);
            }

            return result.ToString();

        }

        /// <summary>
        /// Returns, as text, two raised to the numberth 
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Two raised to the numberth</returns>
        static string PowBase2NumberAsText(int number)
        {
            string result = "2";

            for (int i = 1; i < number; i++)
            {
                result = DuplicateNumberAsText(result);
            }

            return result;

        }

        static void Main()
        {

            string twoRaisedOneThousand = PowBase2NumberAsText(1000);

            int result = (from c in twoRaisedOneThousand.ToCharArray()
                          select int.Parse(c.ToString())).Sum();

            Console.WriteLine("Solution: {0}", result);

        }
    }
}
