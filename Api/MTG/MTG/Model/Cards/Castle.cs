using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Castle : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=240
            *  
            *  Untapped creatures you control get +0/+2.
            *  
            * Rulings

            *  
            */
        public Castle() : base()
        {
            MultiverseId = 240;
            Name = "Castle";
	Add(Enumerations.Colors.White);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Castle");
        }
        public Castle(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
