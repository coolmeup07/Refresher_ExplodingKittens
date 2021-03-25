using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class Attack : Card
    {
        public Attack() { CardName = "Attack";  }

        public override void Use(Player user, Player target, Deck deck)
        {
            user.NumOfTurns = 0;
            target.NumOfTurns += 2;
        }
    }
}
