using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck simpleDeck = new Deck();
            simpleDeck.Shuffle();
            simpleDeck.PrintDeck();
        }
    }
}
