using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Karma : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=257
            *  
            *  At the beginning of each player's upkeep, Karma deals damage to that player equal to the number of Swamps he or she controls.
            *  
            * Rulings
		2004-10-04: Amount of damage is determined when the ability resolves and not when it is placed on the stack.

            *  
            */
        public Karma() : base()
        {
            MultiverseId = 257;
            Name = "Karma";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Karma");
        }
        public Karma(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
