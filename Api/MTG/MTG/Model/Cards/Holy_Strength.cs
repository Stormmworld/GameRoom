using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Holy_Strength : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=255
            *  
            *  Enchant creature
Enchanted creature gets +1/+2.
            *  
            * Rulings

            *  
            */
        public Holy_Strength() : base()
        {
            MultiverseId = 255;
            Name = "Holy Strength";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Holy Strength");
        }
        public Holy_Strength(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
