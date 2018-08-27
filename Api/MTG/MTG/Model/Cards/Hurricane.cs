using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Hurricane : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=156
        *  
        *  Hurricane deals X damage to each creature with flying and each player.
        *  
        * Rulings
        * 2004-10-04: Whether or not a creature has flying is only checked on resolution.

        *
        */
        public Hurricane() : base()
        {
            MultiverseId = 156;
            Name = "Hurricane";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Hurricane");
        }
        public Hurricane(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
