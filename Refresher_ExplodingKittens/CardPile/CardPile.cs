using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class CardPile
    {
        protected List<Card> cards = new List<Card>();
        protected GameManager gm;

        public CardPile(GameManager gameManager)
        {
            gm = gameManager;
        }

        public void DisplayCards()
        {
            foreach (Card card in cards)
                card.DisplayCard();
        }
        public void AddCard(Card card) { cards.Add(card); }
        public void RemoveCard(Card card) { cards.Add(card); }
        public void ShuffleCards() { gm.ShuffleList(cards); }
    }
}
