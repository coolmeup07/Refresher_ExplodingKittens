using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class CardPile
    {
        public List<Card> Cards = new List<Card>();
        private GameManager gm;

        public CardPile(GameManager gameManager)
        {
            gm = gameManager;
        }

        public void DisplayCards() { gm.DisplayList(Cards, false); }
        public void ShuffleCards() { gm.ShuffleList(Cards); }
    }
}
