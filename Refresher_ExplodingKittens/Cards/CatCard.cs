using System;
using System.Collections.Generic;
using System.Text;

namespace Refresher_ExplodingKittens
{
    class CatCard : Card
    {
        public enum CatCardType { TacoCat, Cattermelon, HairyPotatoCat, BeardCat, RainbowRalphingCat }
        private CatCardType catCardType;

        public CatCard(CatCardType ccType) 
        {
            catCardType = ccType;
            CardName = CreateCatCardName(ccType);  
        }

        public override void Use(Player user, Player target, Deck deck)
        {
            // Implement Cat Cards here
            throw new NotImplementedException();
        }

        private string CreateCatCardName(CatCardType cctype)
        {
            switch (cctype)
            {
                case CatCardType.TacoCat: return "Cat Card - TACOCAT";
                case CatCardType.Cattermelon: return "Cat Card - CATTERMELON";
                case CatCardType.HairyPotatoCat: return "Cat Card - HAIRY POTATO CAT";
                case CatCardType.BeardCat: return "Cat Card - BEARD CAT";
                case CatCardType.RainbowRalphingCat: return "Cat Card - RAINBOW-RALPHING CAT";
                default: return null;
            }

        }
    }
}
