using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Berserk : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=141
            *  
            *  Cast Berserk only before the combat damage step.
                Target creature gains trample and gets +X/+0 until end of turn, where X is its power. 
                At the beginning of the next end step, destroy that creature if it attacked this turn.
            *  
            * Rulings
		        2004-10-04: If the permanent stops being a creature before the end of the turn, it is still destroyed.

            *  
            */
        public Berserk() : base()
        {
            MultiverseId = 141;
            Name = "Berserk";
            Add(Enumerations.Colors.Green);
            Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Berserk");
        }
        public Berserk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
