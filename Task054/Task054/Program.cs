using System;
using System.Collections.Generic;
using System.IO;

namespace Task054
{
    class Program
    {
        /// <summary>
        /// Compare two hands
        /// </summary>
        /// <param name="player1">Player1</param>
        /// <param name="player2">Player2</param>
        /// <returns>Returns 1 if player 1 wins, 2 otherwise</returns>
        static int CompareCards(PokerHand player1, PokerHand player2)
        {
            for (int i = player1.Hand.Count-1; i >= 0; i--)
            {
                if (player1.Hand[i].Value > player2.Hand[i].Value)
                {
                    return 1;
                }
                if (player1.Hand[i].Value < player2.Hand[i].Value)
                {
                    return 2;
                }
            }
            return 0;
        }

        /// <summary>
        /// Compares Highestcard
        /// </summary>
        /// <param name="player1">Player1</param>
        /// <param name="player2">Player2</param>
        /// <returns>Returns 1 if player 1 wins, 2 otherwise</returns>
        static int CompareHighestCard(PokerHand player1, PokerHand player2)
        {
            if (player1.HighestCard > player2.HighestCard)
            {
                return 1;
            }
            if (player1.HighestCard < player2.HighestCard)
            {
                return 2;
            }
            if (player1.HighestCard == player2.HighestCard)
            {
                return CompareCards(player1, player2);
            }
            return 0;
        }

        /// <summary>
        /// Compares highest card and second highest card
        /// </summary>
        /// <param name="player1">Player1</param>
        /// <param name="player2">Player2</param>
        /// <returns>Returns 1 if player 1 wins, 2 otherwise</returns>
        static int CompareTwoCards(PokerHand player1, PokerHand player2)
        {
            if (player1.HighestCard > player2.HighestCard)
            {
                return 1;
            }
            if (player1.HighestCard < player2.HighestCard)
            {
                return 2;
            }
            if (player1.HighestCard == player2.HighestCard)
            {
                if (player1.SecondHighestCard > player2.SecondHighestCard)
                {
                    return 1;
                }
                if (player1.SecondHighestCard < player2.SecondHighestCard)
                {
                    return 2;
                }
                if (player1.SecondHighestCard == player2.SecondHighestCard)
                {
                    return 0;
                }
            }
            return 0;
        }

        /// <summary>
        /// Gets winner id
        /// </summary>
        /// <param name="player1">Player1</param>
        /// <param name="player2">Player2</param>
        /// <returns>Returns 1 if player 1 wins, 2 otherwise</returns>
        static int GetWinnerId(PokerHand player1, PokerHand player2)
        {

            if (player1.HandRank > player2.HandRank)
            {
                return 1;
            }

            if (player1.HandRank < player2.HandRank)
            {
                return 2;
            }

            if (player1.HandRank == player2.HandRank)
            {
                switch (player1.HandRank)
                {
                    case PokerHand.HandRankEnum.RoyalFlush:
                        return CompareHighestCard(player1, player2);
                    case PokerHand.HandRankEnum.StraightFlush:
                        return CompareHighestCard(player1, player2);
                    case PokerHand.HandRankEnum.FourOfAKind:
                        return CompareHighestCard(player1, player2);
                    case PokerHand.HandRankEnum.FullHouse:
                        return CompareTwoCards(player1, player2);
                    case PokerHand.HandRankEnum.Flush:
                        return CompareCards(player1, player2);
                    case PokerHand.HandRankEnum.Straight:
                        return CompareHighestCard(player1, player2);
                    case PokerHand.HandRankEnum.ThreeOfAKind:
                        return CompareHighestCard(player1, player2);
                    case PokerHand.HandRankEnum.TwoPairs:
                        return CompareTwoCards(player1, player2);
                    case PokerHand.HandRankEnum.OnePair:
                        return CompareHighestCard(player1, player2);
                    case PokerHand.HandRankEnum.HighCard:
                        return CompareCards(player1, player2);
                }
            }

            return 0;

        }

        /// <summary>
        /// Main Thread
        /// </summary>
        static void Main()
        {
            int winP1 = 0;
            int winP2 = 0;

            const Int32 BufferSize = 128;
            FileStream fs = File.OpenRead("poker.txt");
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8, true, BufferSize);
            String line;

            while ((line = sr.ReadLine()) != null)
            {
                string[] items = line.Split(' ');

                List<PokerCard> hand1 = new List<PokerCard>();
                List<PokerCard> hand2 = new List<PokerCard>();

                for (int i = 0; i < items.Length; i++)
                {
                    PokerCard card = new PokerCard(items[i][0..^1],items[i][^1..]);

                    if (i < 5)
                    {
                        hand1.Add(card);
                    }
                    else
                    {
                        hand2.Add(card);
                    }
                }

                PokerHand player1 = new PokerHand(hand1);
                PokerHand player2 = new PokerHand(hand2);

                if (GetWinnerId(player1, player2) == 1)
                {
                    winP1++;
                }
                else
                {
                    winP2++;
                }

            }

            Console.WriteLine("Matches w1: {0} - w2: {1}", winP1, winP2);

        }
    }
}
