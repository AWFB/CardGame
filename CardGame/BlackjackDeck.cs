using System.Collections.Generic;

namespace CardGame
{
    public class BlackjackDeck : Deck
    {

        public BlackjackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();

            // Draw 5 cards
            for (int i = 0; i < 2; i++) // blackjack you get 2 cards
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }


    }


}
