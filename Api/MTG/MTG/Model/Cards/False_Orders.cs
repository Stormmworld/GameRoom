using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class False_Orders : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=195
            *  
            *  Cast False Orders only during the declare blockers step.
Remove target creature defending player controls from combat. Creatures it was blocking that had become blocked by only that creature this combat become unblocked. You may have it block an attacking creature of your choice.
            *  
            * Rulings
		2004-10-04: If a creature is removed from being a blocker of a given attacker, any triggered abilities that would have happened because it was declared as a blocker still happen.

            *  
            */
        public False_Orders() : base()
        {
            MultiverseId = 195;
            Name = "False Orders";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("False Orders");
        }
        public False_Orders(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}