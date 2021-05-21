using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Model
{
    public class Player
    {
        public string Nickname { get; set; }
        public System.Collections.Generic.List<CardGame.Model.Card> Hand { get; set; }
        public int PlayerPoints { get; set; }

        public Deck PlayerDeck { get; set; }



        public Player(string nickname)
        {
            Nickname = nickname;
            PlayerPoints = 0;
            DeckCard = new Deck();
        }

        public Player()
        {
            Nickname = "NoName";
            PlayerPoints = 0;
        }

        public void AddCard()
        {

        }

        public void RemoveCard()
        {

        }

        private CardGame.Model.Deck deckCard;

        public CardGame.Model.Deck DeckCard {
            get {
                return deckCard;
            }
            set {
                deckCard = value;
            }
        }

    }
}