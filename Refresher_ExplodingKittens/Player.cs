using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    abstract class Player
    {
        public string PlayerName { get; set; }
        public int NumOfTurns { get; set; }
        public bool IsAlive { get; set; }

        public CardPile Hand;

        public virtual void EvaluateTurn() { }
        public virtual Player SelectTarget() { throw new NotImplementedException(); }
    }
}
