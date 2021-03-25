using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class Deck : CardPile
    {
        public Deck(GameManager gameManager) :base(gameManager)
        {
            CreateDeck();
        }

        public void CreateDeck()
        {
            for (int x = 0; x < 4; x++)
            {
                Cards.Add(new Attack());
                Cards.Add(new Skip());
                Cards.Add(new Favor());
                Cards.Add(new Shuffle());
                // Implement Cat Cards here

            }
            for (int x = 0; x < 5; x++)
            {
                Cards.Add(new Nope());
                Cards.Add(new SeeTheFuture());
            }
        }

        public void CompleteDeck(int playerCount)
        {
            for (int x = 0; x < playerCount - 1; x++)
                Cards.Add(new ExplodingKitten());
        }

        /// <summary>
        /// Draws card from CardPile
        /// </summary>
        /// <returns>Card at top of pile (last card in the list) </returns>
        public Card DrawCard()
        {
            var temp = Cards[Cards.Count - 1];
            Cards.Remove(Cards[Cards.Count - 1]);
            return temp;
        }
    }
}
