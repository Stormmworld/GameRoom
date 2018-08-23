using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Gloom : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=66
            *  
            *  White spells cost {3} more to cast.
Activated abilities of white enchantments cost {3} more to activate.
            *  
            * Rulings
		2004-10-04: The extra mana is not considered part of the activation cost. It is a separate cost.
		2004-10-04: The additional mana is paid at the same time the spell/ability is cast/activated.
		2004-10-04: The extra mana is part of the total cost, so cost reducers can be applied to this cost.
		2016-06-08: Activated abilities contain a colon. They're generally written "[Cost]: [Effect]." Some keywords are activated abilities and will have colons in their reminder text.

            *  
            */
        public Gloom() : base()
        {
            MultiverseId = 66;
            Name = "Gloom";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Gloom");
        }
        public Gloom(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
