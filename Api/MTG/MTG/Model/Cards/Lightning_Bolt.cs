using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Lightning_Bolt : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=209
        *  
        *  Lightning Bolt deals 3 damage to target creature or player.
        *  
        * Rulings

        *
        */
        public Lightning_Bolt() : base()
        {
            MultiverseId = 209;
            Name = "Lightning Bolt";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);

            throw new NotImplementedException("Lightning Bolt");
        }
        public Lightning_Bolt(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
