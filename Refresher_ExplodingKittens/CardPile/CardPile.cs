using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class CardPile
    {
        public List<Card> Cards = new List<Card>();
        protected GameManager gm;

        public CardPile(GameManager gameManager)
        {
            gm = gameManager;
        }

        public void DisplayCards()
        {
            foreach (Card card in Cards)
                card.DisplayCard();
        }
        public void ShuffleCards() { gm.ShuffleList(Cards); }
    }
}
