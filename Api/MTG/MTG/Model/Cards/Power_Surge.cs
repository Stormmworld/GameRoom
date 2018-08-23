using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Power_Surge : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=215
            *  
            *  At the beginning of each player's upkeep, Power Surge deals X damage to that player, where X is the number of untapped lands he or she controlled at the beginning of this turn.
            *  
            * Rulings
		2004-10-04: This card knows how many were untapped even if it was not on the battlefield at the beginning of the turn.

            *  
            */
        public Power_Surge() : base()
        {
            MultiverseId = 215;
            Name = "Power Surge";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Power Surge");
        }
        public Power_Surge(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
