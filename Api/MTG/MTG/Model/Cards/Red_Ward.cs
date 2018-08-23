using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Red_Ward : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=264
            *  
            *  Enchant creature
Enchanted creature has protection from red. This effect doesn't remove Red Ward.
            *  
            * Rulings

            *  
            */
        public Red_Ward() : base()
        {
            MultiverseId = 264;
            Name = "Red Ward";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Red Ward");
        }
        public Red_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
