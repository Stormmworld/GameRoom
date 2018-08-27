using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Power_Surge : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=215
        *  
        *  At the beginning of each player's upkeep, Power Surge deals X damage to that player, where X is the number of untapped lands he or she controlled at the beginning of this turn.
        *  
        * Rulings
        * 2004-10-04: This card knows how many were untapped even if it was not on the battlefield at the beginning of the turn.

        *
        */
        public Power_Surge() : base()
        {
            MultiverseId = 215;
            Name = "Power Surge";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Power Surge");
        }
        public Power_Surge(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
