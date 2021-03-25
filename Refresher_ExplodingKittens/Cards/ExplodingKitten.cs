using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class ExplodingKitten : Card
    {
        public ExplodingKitten() { CardName = "Exploding Kitten"; }

        public override void OnCardUsing(Player user, Player target, Deck deck)
        {
            throw new NotImplementedException();
        }
    }
}
