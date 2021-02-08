using System.Text;

namespace Utilities.Math
{
    /// <summary>
    /// Class that transforms numbers to words
    /// </summary>
    public class NumberToWords
    {
        /// <summary>
        /// Numbers 0-9
        /// </summary>
        public enum Number
        {
            zero = 0,
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9
        }

        /// <summary>
        /// Numbers 10-19
        /// </summary>
        public enum FirstTen
        {
            ten = 10,
            eleven = 11,
            twelve = 12,
            thirteen = 13,
            fourteen = 14,
            fifteen = 15,
            sixteen = 16,
            seventeen = 17,
            eighteen = 18,
            nineteen = 19
        }

        /// <summary>
        /// Tens: 20,30,40...
        /// </summary>
        public enum Tens
        {
            twenty = 2,
            thirty = 3,
            forty = 4,
            fifty = 5,
            sixty = 6,
            seventy = 7,
            eighty = 8,
            ninety = 9
        }

        /// <summary>
        /// Given a number (for example, 342), returns
        /// the number as a string: "three hundred and forty two",
        /// without whitespaces
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Number as a string</returns>
        static public string GetNumberAsString(int number)
        {
            StringBuilder result = new StringBuilder();

            if (number >= 1000)
            {

                result.Append((Number)(number / 1000));
                result.Append("thousand");

                number %= 1000;

                if (number > 0)
                {
                    result.Append("and");
                }

            }

            if (number >= 100)
            {

                result.Append((Number)(number / 100));
                result.Append("hundred");

                number %= 100;

                if (number > 0)
                {
                    result.Append("and");
                }

            }

            if (number >= 10 && number <= 19)
            {
                result.Append((FirstTen)number);
                number = 0;
            }
            else
            {
                if (number >= 20)
                {
                    result.Append((Tens)(number / 10));

                    number %= 10;
                }
            }

            if (number > 0)
            {
                result.Append((Number)number);
            }


            return result.ToString();

        }

    }
}
