using System;

namespace CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gameChoice;
            do
            {
                Console.WriteLine("Deal hand of cards for blackjack or poker (bj / poker / quit)");
                gameChoice = Console.ReadLine();

                if (gameChoice.ToLower() == "bj")
                {
                    BlackjackDeck bjDeck = new BlackjackDeck();

                    Console.WriteLine("Now dealing cards for Blackjack");
                    Console.WriteLine();
                    var hand = bjDeck.DealCards();

                    foreach (var card in hand)
                    {
                        Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()} ");
                    }
                    Console.ReadLine();
                }
                else if (gameChoice.ToLower() == "poker")
                {
                    PokerDeck pokerDeck = new PokerDeck();

                    Console.WriteLine("Now dealing cards for Poker");
                    Console.WriteLine();
                    var hand = pokerDeck.DealCards();

                    foreach (var card in hand)
                    {
                        Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()} ");
                    }
                    Console.ReadLine();
                } 
            } while (gameChoice != "quit");
        }
    }


}
