using System;
using System.Collections.Generic;


namespace DeckOfCards
{
    public class Player
    {
        private string name;
        private List<Card> hand;

        public Player(string playerName)
        {
            name = playerName;
            hand = new List<Card>();
        }

        public string Name
        {
            get {return name;}
        }

        public Card Draw(Deck theDeck)
        {
            Card drawnCard = theDeck.Deal();
            hand.Add(drawnCard);
            return drawnCard;
        }

        public Card Discard(int idx)
        {
            Card burnCard;
            if (idx < hand.Count)
            {
                burnCard = hand[idx];
                hand.RemoveAt(idx);
                return burnCard;
            }
            else
            {
                return null;
            }
        }
        
    }
}