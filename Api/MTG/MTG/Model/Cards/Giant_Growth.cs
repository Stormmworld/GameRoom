using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Giant_Growth : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=153
        *  
        *  Target creature gets +3/+3 until end of turn.
        *  
        * Rulings

        *
        */
        public Giant_Growth() : base()
        {
            MultiverseId = 153;
            Name = "Giant Growth";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Instant);

            throw new NotImplementedException("Giant Growth");
        }
        public Giant_Growth(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
