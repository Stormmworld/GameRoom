using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Natural_Selection : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=168
        *  
        *  Look at the top three cards of target player's library, then put them back in any order. You may have that player shuffle his or her library.
        *  
        * Rulings
        * 2007-07-15: This is now targeted.

        *
        */
        public Natural_Selection() : base()
        {
            MultiverseId = 168;
            Name = "Natural Selection";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Instant);

            throw new NotImplementedException("Natural Selection");
        }
        public Natural_Selection(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
