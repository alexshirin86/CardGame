using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardGame.Model
{
    public class Deck
    {
        string entity = "\u0421\u0443\u0449\u0435\u0441\u0442\u0432\u043e";
        string spell = "\u0417\u0430\u043a\u043b\u0438\u043d\u0430\u043d\u0438\u0435";

        public System.Collections.Generic.List<Card> DeckCards { get; set; }

        public Deck()
        {
            DeckCards.Add(new Card(1, entity, "Застенчивый троль", "+3/-5", "", "Очень, очень застенчивый троль."));
            DeckCards.Add(new Card(2, entity, "Ночной козлик", "+1/-1", "", "Существо кричащее в ночи. Ну то под окнами."));
            DeckCards.Add(new Card(3, entity, "Упоротый орк", "+5/-1", "", "А зрачки то расширены!"));
            DeckCards.Add(new Card(4, entity, "Гиганавт", "+6/-5", "", "Существо. Гигант. Отдельные особи вырастают до 3 футов."));
            DeckCards.Add(new Card(5, entity, "Скелет", "+2/-1", "", "Просто скелет. Не, ну реально просто скелет."));
            DeckCards.Add(new Card(6, entity, "МагИк", "-2/-4", "", "Арзам Бурамзис Вармираниус Ик. Бух-Бах. И так всегда."));
            DeckCards.Add(new Card(7, entity, "Милый орчик", "+1/+2", "", "Ух ты какая милашка!"));
            DeckCards.Add(new Card(8, entity, "МегаКорова", "+3/-2", "", ""));
            DeckCards.Add(new Card(9, entity, "Гоблин", "+4/-5", "", ""));
            DeckCards.Add(new Card(10, entity, "Хоббоит", "+3/-5", "", ""));
            DeckCards.Add(new Card(11, entity, "Вампир", "+3/-5", "", ""));
            DeckCards.Add(new Card(12, entity, "Призрак", "+3/-5", "", ""));
            DeckCards.Add(new Card(13, entity, "Везунчик", "+3/-5", "", ""));
            DeckCards.Add(new Card(14, entity, "Ромашка", "+3/-5", "", ""));
            DeckCards.Add(new Card(15, entity, "Дино", "+3/-5", "", ""));
            DeckCards.Add(new Card(16, entity, "Пикачи-зззз", "+3/-5", "", "Незаменимый, если нужно зарядить телефон."));
            DeckCards.Add(new Card(17, spell, "Слёзы счастья", "-5", "", ""));
            DeckCards.Add(new Card(18, spell, "", "+3", "", ""));
            DeckCards.Add(new Card(19, spell, "", "-1", "", ""));
            DeckCards.Add(new Card(20, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(21, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(22, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(23, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(24, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(25, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(26, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(27, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(28, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(29, spell, "", "-5", "", ""));
            DeckCards.Add(new Card(30, spell, "", "-5", "", ""));
        }
    }
}