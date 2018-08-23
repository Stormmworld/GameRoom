using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Jump : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=108
            *  
            *  Target creature gains flying until end of turn.
            *  
            * Rulings
		2009-10-01: To work as an evasion ability, an attacking creature must already have flying when the declare blockers step begins. Once a creature has become blocked, giving it flying won't change that.

            *  
            */
        public Jump() : base()
        {
            MultiverseId = 108;
            Name = "Jump";
	Add(Enumerations.Colors.Blue);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Jump");
        }
        public Jump(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
