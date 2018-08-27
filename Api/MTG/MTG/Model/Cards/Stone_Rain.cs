using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Stone_Rain : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=225
        *  
        *  Destroy target land.
        *  
        * Rulings

        *
        */
        public Stone_Rain() : base()
        {
            MultiverseId = 225;
            Name = "Stone Rain";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Stone Rain");
        }
        public Stone_Rain(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
