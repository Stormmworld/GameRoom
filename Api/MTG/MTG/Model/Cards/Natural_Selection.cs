using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Natural_Selection : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=168
            *  
            *  Look at the top three cards of target player's library, then put them back in any order. You may have that player shuffle his or her library.
            *  
            * Rulings
		2007-07-15: This is now targeted.

            *  
            */
        public Natural_Selection() : base()
        {
            MultiverseId = 168;
            Name = "Natural Selection";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Natural Selection");
        }
        public Natural_Selection(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
