using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Black_Ward : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=236
            *  
            *  Enchant creature
Enchanted creature has protection from black. This effect doesn't remove Black Ward.
            *  
            * Rulings

            *  
            */
        public Black_Ward() : base()
        {
            MultiverseId = 236;
            Name = "Black Ward";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Black Ward");
        }
        public Black_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
