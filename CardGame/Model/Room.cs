using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class Room
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Player PlayerThree { get; set; }
        public Player PlayerFour { get; set; }
        public Deck DeckCard { get; set; }

        public Room()
        {
            PlayerOne = new Player();
            PlayerTwo = new Player();
            PlayerThree = new Player();
            PlayerFour = new Player();
            DeckCard = new Deck();
        }
    }
}