using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class SeeTheFuture : Card
    {
        public SeeTheFuture() { CardName = "See The Future (3x)"; }

        public override void Use(Player user, Player target, Deck deck)
        {
            deck.DisplayCards(3);
        }
    }
}
