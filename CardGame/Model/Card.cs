using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Model
{
    public class Card
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Effect { get; set; }
        public string TypeCard { get; set; }
        public string ImageCard { get; set; }
        public string Flavour { get; set; }
        public string SkinCard { get; set; }

        public Card(int number, string type, string name, string effect, string image, string flavour)
        {
            Name = name;
            Number = number;
            Effect = effect;
            TypeCard = type;
            ImageCard = image;
            Flavour = flavour;
        }
        private CardGame.Model.Skin skinCard;

    }
}