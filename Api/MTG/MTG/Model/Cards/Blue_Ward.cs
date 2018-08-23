using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Blue_Ward : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=239
            *  
            *  Enchant creature
Enchanted creature has protection from blue. This effect doesn't remove Blue Ward.
            *  
            * Rulings

            *  
            */
        public Blue_Ward() : base()
        {
            MultiverseId = 239;
            Name = "Blue Ward";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Blue Ward");
        }
        public Blue_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
