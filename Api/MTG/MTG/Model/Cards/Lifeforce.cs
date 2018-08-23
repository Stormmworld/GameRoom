using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Lifeforce : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=162
            *  
            *  {G}{G}: Counter target black spell.
            *  
            * Rulings

            *  
            */
        public Lifeforce() : base()
        {
            MultiverseId = 162;
            Name = "Lifeforce";
	Add(Enumerations.Colors.Green);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Lifeforce");
        }
        public Lifeforce(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
