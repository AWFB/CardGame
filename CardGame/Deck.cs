using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    public abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        protected void CreateDeck()
        {
            fullDeck.Clear();

            // create full deck in order 
            for (int suit = 0; suit < 4; suit++) // 4 suits, 0 - 3
            {
                for (int val = 0; val < 13; val++) // 14 cards, 0 - 13
                {
                    fullDeck.Add(new PlayingCardModel { 
                        Suit = (CardSuit)suit, // cast interger value for enum
                        Value = (CardValue)val // cast interger value for enum
                    }); 
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rand = new Random();
            drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        public abstract List<PlayingCardModel> DealCards();

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First(); // take does not remove entry/card from deck
            drawPile.Remove(output);

            return output;
        }
    }


}
