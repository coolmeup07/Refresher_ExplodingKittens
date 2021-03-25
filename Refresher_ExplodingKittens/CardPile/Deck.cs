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
                Cards.Add(new CatCard(CatCard.CatCardType.BeardCat));
                Cards.Add(new CatCard(CatCard.CatCardType.Cattermelon));
                Cards.Add(new CatCard(CatCard.CatCardType.HairyPotatoCat));
                Cards.Add(new CatCard(CatCard.CatCardType.RainbowRalphingCat));
                Cards.Add(new CatCard(CatCard.CatCardType.TacoCat));
            }
            for (int x = 0; x < 5; x++)
            {
                //Cards.Add(new Nope());
                Cards.Add(new SeeTheFuture());
            }
        }

        public void DealCards(Player player, int amount)
        {
            for (int x = 0; x < amount; x++)
                player.AddCard(DrawCard());
        }

        public void CompleteDeck(int playerCount)
        {
            if (playerCount <= 3)
            {
                for(int x = 0; x < 2; x++)
                    Cards.Add(new Defuse());
            } 
            else
            {
                for (int x = 0; x < 6-playerCount; x++)
                    Cards.Add(new Defuse());
            }
            for (int x = 0; x < playerCount-1; x++)
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


        /// <summary>
        /// Displays cards based on amount from the top of the deck.
        /// </summary>
        /// <param name="amount">Number of Cards to show</param>
        public void DisplayCards(int amount)
        {
            for (int x = 0; x < amount; x++)
                Console.WriteLine(Cards[Cards.Count-x]);
        }
    }
}
