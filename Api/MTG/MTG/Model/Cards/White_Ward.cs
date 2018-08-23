using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class White_Ward : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=275
            *  
            *  Enchant creature
Enchanted creature has protection from white. This effect doesn't remove White Ward.
            *  
            * Rulings

            *  
            */
        public White_Ward() : base()
        {
            MultiverseId = 275;
            Name = "White Ward";
	Add(Enumerations.Colors.White);
	Add(Enumerations.SubType.Aura);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("White Ward");
        }
        public White_Ward(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
