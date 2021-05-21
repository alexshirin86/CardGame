using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Model
{
    public class Room
    {
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public Room()
        {
            PlayerOne = new Player();
            PlayerTwo = new Player();
            
        }
    }
}