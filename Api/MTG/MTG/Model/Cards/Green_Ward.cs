using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Green_Ward : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=251
            *  
            *  Enchant creature
Enchanted creature has protection from green. This effect doesn't remove Green Ward.
            *  
            * Rulings

            *  
            */
        public Green_Ward() : base()
        {
            MultiverseId = 251;
            Name = "Green Ward";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Green Ward");
        }
        public Green_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
