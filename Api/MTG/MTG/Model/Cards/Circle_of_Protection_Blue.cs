using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Circle_of_Protection_Blue : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=241
            *  
            *  {1}: The next time a blue source of your choice would deal damage to you this turn, prevent that damage.
            *  
            * Rulings
		2004-10-04: A source of damage is a permanent, a spell on the stack (including one that creates a permanent), or any object referred to by an object on the stack. A source doesn't need to be capable of dealing damage to be a legal choice.
		2004-10-04: Can be used even when there is no damage to prevent. It prevents the next damage (if any) from the source this turn.

            *  
            */
        public Circle_of_Protection_Blue() : base()
        {
            MultiverseId = 241;
            Name = "Circle of Protection: Blue";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Circle of Protection: Blue");
        }
        public Circle_of_Protection_Blue(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
