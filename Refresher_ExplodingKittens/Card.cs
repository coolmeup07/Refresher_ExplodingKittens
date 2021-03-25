using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    abstract class Card
    {       
        protected string CardName { get; set; }

        public virtual void OnCardUsing(Player user, Player target, Deck deck) {}
        public virtual void Use(Player user, Player target, Deck deck) { }
        public virtual void DisplayCard(){ Console.WriteLine(CardName); }
    }
}
