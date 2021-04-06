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
            hand.AddCard((new Defuse()));
        }

        public override void EvaluateTurn()
        {
            while(NumOfTurns > 0)
            {
                
            }
        }

        private void SelectAction()
        {
            throw new NotImplementedException();
        }

        public override Player SelectTarget(List<Player> targets)
        {
            return null;
        }
    }
}
