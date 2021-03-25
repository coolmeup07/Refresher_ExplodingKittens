using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class Skip : Card
    {
        public Skip() { CardName = "Skip"; }

        public override void Use(Player user, Player target, Deck deck)
        {
            user.NumOfTurns -= 1;
        }
    }
}
