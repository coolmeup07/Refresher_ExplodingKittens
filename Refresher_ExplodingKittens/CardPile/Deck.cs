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
                cards.Add(new Attack());
                cards.Add(new Skip());
                cards.Add(new Favor());
                cards.Add(new Shuffle());
                cards.Add(new CatCard(CatCard.CatCardType.BeardCat));
                cards.Add(new CatCard(CatCard.CatCardType.Cattermelon));
                cards.Add(new CatCard(CatCard.CatCardType.HairyPotatoCat));
                cards.Add(new CatCard(CatCard.CatCardType.RainbowRalphingCat));
                cards.Add(new CatCard(CatCard.CatCardType.TacoCat));
            }
            for (int x = 0; x < 5; x++)
            {
                //Cards.Add(new Nope());
                cards.Add(new SeeTheFuture());
            }
        }

        public void DealCards(Player player, int amount)
        {
            for (int x = 0; x < amount; x++)
                player.AddCard(DrawCard());
        }

        /// <summary>
        /// Adds Defuse and Exploding Kitten Cards based on the # of players
        /// </summary>
        /// <param name="playerCount">Number of Players in game</param>
        public void CompleteDeck(int playerCount)
        {
            if (playerCount <= 3)
            {
                for(int x = 0; x < 2; x++)
                    cards.Add(new Defuse());
            } 
            else
            {
                for (int x = 0; x < 6-playerCount; x++)
                    cards.Add(new Defuse());
            }
            for (int x = 0; x < playerCount-1; x++)
                cards.Add(new ExplodingKitten());
        }

        /// <summary>
        /// Draws card from CardPile
        /// </summary>
        /// <returns>Card at top of pile (last card in the list)</returns>
        public Card DrawCard()
        {
            var temp = cards[cards.Count - 1];
            cards.Remove(cards[cards.Count - 1]);
            return temp;
        }


        /// <summary>
        /// Displays cards based on amount from the top of the deck.
        /// </summary>
        /// <param name="amount">Number of Cards to show</param>
        public void DisplayCards(int amount)
        {
            for (int x = 0; x < amount; x++)
                Console.WriteLine(cards[cards.Count-x]);
        }
    }
}
