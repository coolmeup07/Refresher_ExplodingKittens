using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    abstract class Card
    {       
        public string CardName { get; set; }
        private string cardName;

        public virtual void OnCardUsing(Player target, Deck deck, GameManager gm) {}
        public virtual void Use(Player target, Deck deck, GameManager gm) { }
    }
}
