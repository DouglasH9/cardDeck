using System;
using System.Collections.Generic;


namespace DeckOfCards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;

        public Card Draw()
        {
            Card topCard = Deck.Cards[0];
            return topCard;
        }

        public Card discard(int idx)
        {
            Card lostCard = Hand.RemoveAt(idx);
        }
    }
}