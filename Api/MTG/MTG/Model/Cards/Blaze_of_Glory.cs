using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Blaze_of_Glory : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=237
            *  
            *  Cast Blaze of Glory only during combat before blockers are declared.
Target creature defending player controls can block any number of creatures this turn. It blocks each attacking creature this turn if able.
            *  
            * Rulings
		2004-10-04: Does not allow a tapped creature to block, or allow a creature to block any creatures it would not normally be able to block.
		2013-09-20: If a turn has multiple combat phases, this spell can be cast during any of them as long as it's before the beginning of that phase's Declare Blockers Step.

            *  
            */
        public Blaze_of_Glory() : base()
        {
            MultiverseId = 237;
            Name = "Blaze of Glory";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Blaze of Glory");
        }
        public Blaze_of_Glory(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
