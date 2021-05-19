using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class Deck
    {
        private string[] suits = { "diamond" , "spade", "club", "heart" };
        private string[] names = { "7", "8", "9", "10", "J", "Q", "K", "A" };

        public List<Card> DeckCards { get; set; }

        public Deck()
        {
            foreach (string suit in suits)
            {
                foreach (string name in names)
                {
                    DeckCards.Add(new Card(suit, name, 0));             
                }
            }
            
        }
    }
}