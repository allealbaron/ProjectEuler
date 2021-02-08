namespace Utilities.Math
{
    /// <summary>
    /// Palindrome related functions
    /// </summary>
    public class Palindrome
    {

        public static bool IsPalindromic(int number)
        {
            return IsPalindromic(number.ToString());
        }

        /// <summary>
        /// Given a number, returns if it is palindromic
        /// </summary>
        /// <param name="number">Number to evaluate</param>
        /// <returns>True if the number is palindromic, false otherwise</returns>
        public static bool IsPalindromic(string number)
        {
            bool result = true;

            for (int i = 0; result && i < number.Length / 2; i++)
            {
                result = (number[i].Equals(number[number.Length - i - 1]));
            }

            return result;

        }
    }
}
