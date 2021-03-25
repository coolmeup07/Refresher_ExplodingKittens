using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class Defuse : Card
    {
        public Defuse() { CardName = "Defuse";  }

        public override void OnCardUsing(Player user, Player target, Deck deck)
        {
            throw new NotImplementedException();
        }
    }
}
