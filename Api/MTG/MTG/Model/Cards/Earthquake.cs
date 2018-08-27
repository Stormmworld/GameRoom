using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Earthquake : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=194
        *  
        *  Earthquake deals X damage to each creature without flying and each player.
        *  
        * Rulings
        * 2004-10-04: Whether or not a creature is without flying is only checked on resolution.

        *
        */
        public Earthquake() : base()
        {
            MultiverseId = 194;
            Name = "Earthquake";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Earthquake");
        }
        public Earthquake(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
