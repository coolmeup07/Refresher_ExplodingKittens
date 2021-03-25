using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string pName) : base(pName){ }

        public void CompleteHand()
        {
            hand.Cards.Add(new Defuse());
        }

        public override void EvaluateTurn()
        {
            
        }

        public override Player SelectTarget(List<Player> targets)
        {
            return null;
        }
    }
}
