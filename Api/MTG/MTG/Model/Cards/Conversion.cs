using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Conversion : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=246
            *  
            *  At the beginning of your upkeep, sacrifice Conversion unless you pay {W}{W}.
All Mountains are Plains.
            *  
            * Rulings
		2004-10-04: The Conversion effect is a continuous effect. There is no chance to tap a just-played mountain for red mana before it becomes a plains.
		2006-10-15: Will not add or remove Snow Supertype to or from a land.

            *  
            */
        public Conversion() : base()
        {
            MultiverseId = 246;
            Name = "Conversion";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Conversion");
        }
        public Conversion(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
