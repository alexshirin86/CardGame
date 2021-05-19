using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{  
    public class Card
    {
        public int PointCard { get; set; }
        public string Name { get; set; }
        public string Suit { get; set; }

        public Card(string suit, string name, int pointCard)
        {
            Name = name;
            Suit = suit;
            PointCard = pointCard;
        }
    }
}