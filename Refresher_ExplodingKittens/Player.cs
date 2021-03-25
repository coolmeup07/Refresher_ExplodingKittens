using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    abstract class Player
    {
        public string PlayerName { get; set; }
        public bool IsAlive { get; set; }
        public int TurnOrder { get; set; }
        public int NumOfTurns { get; set; }

        protected CardPile hand;

        public Player(string pName)
        {
            PlayerName = pName;
            IsAlive = true;
        } 

        public void AddCard(Card card) { hand.Cards.Add(card); }
        public void DisplayHand() { hand.DisplayCards(); }

        public virtual void EvaluateTurn() { }
        public virtual Player SelectTarget(List<Player> targets) { throw new NotImplementedException(); }
    }
}
