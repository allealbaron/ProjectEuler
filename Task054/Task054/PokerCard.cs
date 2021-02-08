using System;
using System.Linq;

namespace Task054
{
    /// <summary>
    /// Poker Card
    /// </summary>
    public class PokerCard : IComparable
    {
        /// <summary>
        /// Suits: Hearts, Clubs, Spades, Diamonds
        /// </summary>
        public enum SuitEnum
        {
            C = 1, //Clubs
            H = 2, //Hearts
            S = 3, //Spades
            D = 4  //Diamonds
        }

        /// <summary>
        /// Value
        /// </summary>
        public enum ValueEnum
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            T = 10,
            J = 11,
            Q = 12,
            K = 13,
            A = 14
        }

        /// <summary>
        /// Value
        /// </summary>
        public readonly ValueEnum Value;

        /// <summary>
        /// Suit
        /// </summary>
        public readonly SuitEnum Suit;

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="value">Value as a string</param>
        /// <param name="suit">Suit as a string</param>
        public PokerCard(string value, string suit)
        {
            if (value.All(char.IsNumber))
            {
                Value = (ValueEnum)int.Parse(value);
            }
            else
            {
                Enum.TryParse(value, true, out Value);
            }
            Enum.TryParse(suit, true, out Suit);
        }

        public int CompareTo(object obj)
        {

            if (obj == null)
            {
                return 1;
            }
            else
            {
                PokerCard otherPokerCard = (PokerCard)obj;

                if (otherPokerCard != null)
                {
                    if (this.Value.CompareTo(otherPokerCard.Value) != 0)
                    {
                        return this.Value.CompareTo(otherPokerCard.Value);
                    }
                    else
                    {
                        return this.Suit.CompareTo(otherPokerCard.Suit);
                    }
                }
                else
                {
                    throw new ArgumentException("Object is not a PokerCard");
                }
            }
        }
    }
}
