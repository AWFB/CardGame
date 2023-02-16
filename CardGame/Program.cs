using System;
using System.Collections.Generic;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }
    }

    public abstract class Deck
    {
        protected List<PlayingCard> fullDeck = new List<PlayingCard>();
        protected List<PlayingCard> drawPile = new List<PlayingCard>();
        protected List<PlayingCard> discardPile = new List<PlayingCard>();

        public void CreateDeck()
        {

        }

        public virtual void ShuffleDeck()
        {

        }

        public abstract List<PlayingCard> DealCard();

        public virtual PlayingCard RequestCard()
        {

        }
    }

    public class PlayingCard
    {
        public CardSuit Suit { get; set; }
        public int CardValue { get; set; }
    }

    public enum CardValue
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public enum CardSuit
    {
        Hearts,
        Clubs,
        Spades,
        Diamond
    }
}
