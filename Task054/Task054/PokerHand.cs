using System.Collections.Generic;
using System.Linq;

namespace Task054
{
    class PokerHand
    {
        /// <summary>
        /// Hand ranks
        /// </summary>
        public enum HandRankEnum
        {            
            HighCard,
            OnePair,
            TwoPairs,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush
        }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="Hand">List of <see cref="PokerCard"/></param>
        public PokerHand(List<PokerCard> Hand)
        {
            this.Hand = Hand;
            this.Hand.Sort();
            CalculateBestHand();
        }

        /// <summary>
        /// List of  <see cref="PokerCard"/>
        /// </summary>
        public readonly List<PokerCard> Hand = new List<PokerCard>();

        /// <summary>
        /// HandRank
        /// </summary>
        public HandRankEnum HandRank;

        /// <summary>
        /// Returns the highest card in the first rank
        /// </summary>
        public PokerCard.ValueEnum HighestCard;

        /// <summary>
        /// Returns the highest card in the second rank
        /// </summary>
        public PokerCard.ValueEnum SecondHighestCard;

        /// <summary>
        /// Calculates the best hand
        /// </summary>
        private void CalculateBestHand()
        {
            if (this.HasRoyalFlush())
            {
                HandRank = HandRankEnum.RoyalFlush;
            }
            else
            {
                if (this.HasStraightFlush())
                {
                    HandRank = HandRankEnum.StraightFlush;
                }
                else
                {
                    if (this.HasFourOfAKind())
                    {
                        HandRank = HandRankEnum.FourOfAKind;
                    }
                    else
                    {
                        if (this.HasFullHouse())
                        {
                            HandRank = HandRankEnum.FullHouse;
                        }
                        else
                        {
                            if (this.HasFlush())
                            {
                                HandRank = HandRankEnum.Flush;
                            }
                            else
                            {
                                if (this.HasStraight())
                                {
                                    HandRank = HandRankEnum.Straight;
                                }
                                else
                                {
                                    if (this.HasThreeOfAKind())
                                    {
                                        HandRank = HandRankEnum.ThreeOfAKind;
                                    }
                                    else
                                    {
                                        if (this.HasTwoPairs())
                                        {
                                            HandRank = HandRankEnum.TwoPairs;
                                        }
                                        else
                                        {
                                            if (this.HasOnePair())
                                            {
                                                HandRank = HandRankEnum.OnePair;
                                            }
                                            else
                                            {
                                                HandRank = HandRankEnum.HighCard;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Returns if the hand contains a Straight
        /// </summary>
        /// <returns></returns>
        private bool HasStraight()
        {
            bool result = true;

            PokerCard pivotCard = Hand[0];

            for (int i = 1; result && i < Hand.Count; i++)
            {
                result = (pivotCard.Value + 1 == Hand[i].Value);
                pivotCard = Hand[i];

                if (!result && i == Hand.Count - 1 &&
                    Hand[i].Value == PokerCard.ValueEnum.A && Hand[0].Value == PokerCard.ValueEnum.Two)
                {
                    result = true;
                }

            }

            if (result)
            {
                HighestCard = Hand.Last().Value;
            }

            return result;

        }

        /// <summary>
        /// Returns if the hand contains three of a kind
        /// </summary>
        /// <returns></returns>
        private bool HasThreeOfAKind()
        {

            bool result = true;
            int count = 1;
            const int three = 3;

            PokerCard pivotCard = Hand[0];

            for (int i = 1; result && count < three && i < Hand.Count; i++)
            {
                result = (pivotCard.Suit != Hand[i].Suit && pivotCard.Value == Hand[i].Value);
                count++;
            }

            if (!result)
            {
                result = true;
                count = 1;
                pivotCard = Hand[1];

                for (int i = 2; result && count < three && i < Hand.Count; i++)
                {
                    result = (pivotCard.Suit != Hand[i].Suit && pivotCard.Value == Hand[i].Value);
                    count++;
                }
            }

            if (!result)
            {
                result = true;
                count = 1;
                pivotCard = Hand[2];

                for (int i = 3; result && count < three && i < Hand.Count; i++)
                {
                    result = (pivotCard.Suit != Hand[i].Suit && pivotCard.Value == Hand[i].Value);
                    count++;
                }
            }

            if (result)
            {
                HighestCard = pivotCard.Value;
            }

            return result;

        }

        /// <summary>
        /// Returns if the hand contains a Flush
        /// </summary>
        /// <returns></returns>
        private bool HasFlush()
        {
            bool result = false;

            int count = (from c in Hand
                        where c.Suit == Hand[0].Suit
                        select c.Suit).Count();

            result = (count == 5);

            if (result)
            {
                HighestCard = Hand[4].Value;
            }

            return result;

        }

        /// <summary>
        /// Returns if the hand contains a Full House
        /// </summary>
        /// <returns></returns>
        private bool HasFullHouse()
        {
            bool result = false;

            if ((Hand[0].Value == Hand[1].Value && Hand[0].Value == Hand[2].Value) &&
                 Hand[3].Value == Hand[4].Value)
            {
                result = true;
                HighestCard = Hand[0].Value;
                SecondHighestCard = Hand[3].Value;

            }

            if ((Hand[2].Value == Hand[3].Value && Hand[2].Value == Hand[4].Value) &&
                 Hand[0].Value == Hand[1].Value)
            {
                result = true;
                HighestCard = Hand[2].Value;
                SecondHighestCard = Hand[0].Value;
            }

            return result;
        }

        /// <summary>
        /// Returns if the hand contains a Royal Flush
        /// </summary>
        /// <returns></returns>
        public bool HasRoyalFlush()
        {
            bool result = true;

            PokerCard pivotCard = Hand[0];

            if (pivotCard.Value == PokerCard.ValueEnum.T)
            {
                for (int i = 1; result && i < Hand.Count; i++)
                {
                    result = (pivotCard.Suit == Hand[i].Suit && pivotCard.Value + 1 == Hand[i].Value );
                    pivotCard = Hand[i];
                }
            }
            else
            {
                result = false;
            }

            if (result)
            {
                HighestCard = Hand.Last().Value;
            }

            return result;
        }

        /// <summary>
        /// Returns if the hand constains a straight flush
        /// </summary>
        /// <returns></returns>
        public bool HasStraightFlush()
        {
            bool result = true;

            PokerCard pivotCard = Hand[0];

            for (int i = 1; result && i < Hand.Count; i++)
            {
                result = (pivotCard.Suit == Hand[i].Suit && pivotCard.Value + 1 == Hand[i].Value);
                pivotCard = Hand[i];

                if (!result && i == Hand.Count-1 && Hand[0].Suit == Hand[i].Suit &&
                    Hand[i].Value == PokerCard.ValueEnum.A && Hand[0].Value == PokerCard.ValueEnum.Two)
                {
                    result = true;
                }

            }

            if (result)
            {
                HighestCard = Hand.Last().Value;
            }

            return result;
        }

        /// <summary>
        /// Returns if the hand contains four of a kind
        /// </summary>
        /// <returns></returns>
        public bool HasFourOfAKind()
        {
            bool result = true;
            int count = 1;
            const int four = 4;

            PokerCard pivotCard = Hand[0];

            for (int i = 1; result && count <four && i < Hand.Count; i++)
            {
                result = (pivotCard.Suit != Hand[i].Suit && pivotCard.Value == Hand[i].Value);
                count++;
            }

            if (!result)
            {
                result = true;
                count = 1;
                pivotCard = Hand[1];

                for (int i = 2; result && count < four && i < Hand.Count; i++)
                {
                    result = (pivotCard.Suit != Hand[i].Suit && pivotCard.Value == Hand[i].Value);
                    count++;
                }
            }

            if (result)
            {
                HighestCard = pivotCard.Value;
            }

            return result;

        }

        /// <summary>
        /// Returns if the hand contains at least a pair
        /// </summary>
        /// <returns></returns>
        public bool HasOnePair()
        {
            bool result = false;

            for (int i = 0; !result && i < Hand.Count; i++)
            {
                for (int j = i+1; !result && j < Hand.Count; j++)
                {
                    result = (Hand[i].Suit != Hand[j].Suit && Hand[i].Value == Hand[j].Value);

                    if (result)
                    {
                        HighestCard = Hand[j].Value;
                    }

                }
            }

            return result;

        }

        /// <summary>
        /// Returns if the hand contains tow a pairs
        /// </summary>
        /// <returns></returns>
        public bool HasTwoPairs()
        {
            bool result = false;

            int iteration = 0;
            PokerCard.ValueEnum valueFirstPair = PokerCard.ValueEnum.Two;

            for (int i = 0; !result && i < Hand.Count; i++)
            {
                for (int j = i + 1; !result && j < Hand.Count; j++)
                {
                    result = (Hand[i].Suit != Hand[j].Suit && Hand[i].Value == Hand[j].Value);
                    if (result)
                    {
                        iteration = i;
                        valueFirstPair = Hand[i].Value;
                        SecondHighestCard = Hand[i].Value;
                    }
                }
            }

            if (result)
            {
                result = false;

                for (int i = iteration + 1; !result && i < Hand.Count; i++)
                {
                    if (valueFirstPair != Hand[i].Value)
                    {
                        for (int j = i + 1; !result && j < Hand.Count; j++)
                        {
                            result = Hand[i].Suit != Hand[j].Suit && Hand[i].Value == Hand[j].Value;

                            if (result)
                            {
                                HighestCard = Hand[j].Value;
                            }
                        }
                    }
                }

            }

            return result;

        }
        
    }
}
