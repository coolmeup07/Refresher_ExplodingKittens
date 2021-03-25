using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class Shuffle : Card
    {
        public Shuffle() { CardName = "Shuffle"; }

        public override void Use(Player user, Player target, Deck deck)
        {
            deck.ShuffleCards();
        }
    }
}
