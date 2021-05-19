using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame
{
    public class Player
    {
        public string Nickname { get; set; }
        public List<Card> Hand { get; set; }
        public int PlayerPoints { get; set; }



    public Player(string nickname)
        {
            Nickname = nickname;
            PlayerPoints = 0;
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

    }
}